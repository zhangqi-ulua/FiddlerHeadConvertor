using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Windows.Forms;
using LitJson;

namespace FiddlerHeadConvertor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            txtContentType.Clear();
            txtReqUrl.Clear();
            txtReqDecodeUrl.Clear();
            rtxToApiPostJson.Clear();
            rtxToJavaCode.Clear();
            rtxIgnoreHeader.Clear();

            string inputRawHeaderString = rtxInputRawHeader.Text.Trim();
            string[] allHeadKeyValuePairString = inputRawHeaderString.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (allHeadKeyValuePairString.Length < 1)
            {
                MessageBox.Show(this, "检测不到有效行信息", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 首行为请求方法、URL、HTTP版本号
            string reqTypeAndUrlLineString = allHeadKeyValuePairString[0];
            string[] reqTypeAndUrlLineParams = reqTypeAndUrlLineString.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (reqTypeAndUrlLineParams.Length != 3)
            {
                MessageBox.Show(this, "首行不是请求方法、URL、HTTP版本号的定义，请把Fiddler中完整的Raw视图的Header信息粘贴过来", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (AppValues.HTTP_REQ_TYPE.Contains(reqTypeAndUrlLineParams[0]) == false)
            {
                MessageBox.Show(this, $"首行不是请求方法、URL、HTTP版本号的定义，因为请求方法未知，输入值为{reqTypeAndUrlLineParams[0]}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblRequestType.Text = reqTypeAndUrlLineParams[0];
            lblHttpVersion.Text = reqTypeAndUrlLineParams[2];

            txtReqUrl.Text = reqTypeAndUrlLineParams[1];
            // URL解码（对于javascript的encodeURIComponent函数，应使用utf-8解码）
            // 这里要处理被多次编码的情况
            string tempDecodeUrlString = reqTypeAndUrlLineParams[1];
            while (tempDecodeUrlString.Contains("%"))
            {
                tempDecodeUrlString = HttpUtility.UrlDecode(tempDecodeUrlString, Encoding.UTF8);
            }
            txtReqDecodeUrl.Text = tempDecodeUrlString;

            // 把AppValues中定义的Header key顺序，也按小写存一遍
            List<string> lowerCaseHeaderSeq = new List<string>();
            foreach (string headerKey in AppValues.HEADER_KEY_SECQUENCE)
                lowerCaseHeaderSeq.Add(headerKey.ToLower());
            // 把AppValues中定义的忽略的head，也按小写存一遍
            List<string> lowerCaseIgnore = new List<string>();
            foreach (string headerKey in AppValues.IGNORE_HEADER_KEY)
                lowerCaseIgnore.Add(headerKey.ToLower());
            /**
             * 除了首行以外的作为Header的键值对进行格式转换
             */
            List<KeyValuePair<string, string>> sortedHeader = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> ignoreHeader = new List<KeyValuePair<string, string>>();
            for (int i = 0; i < AppValues.HEADER_KEY_SECQUENCE.Count; i++)
                sortedHeader.Add(new KeyValuePair<string, string>(string.Empty, string.Empty));

            for (int i = 1; i < allHeadKeyValuePairString.Length; i++)
            {
                string str = allHeadKeyValuePairString[i];
                string[] keyAndValue = str.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                string value = keyAndValue.Length > 1 ? keyAndValue[1] : string.Empty;
                if ("Content-Type".Equals(keyAndValue[0], StringComparison.OrdinalIgnoreCase))
                    txtContentType.Text = value;
                else
                {
                    string lowCaseKey = keyAndValue[0].ToLower();
                    KeyValuePair<string, string> pair = new KeyValuePair<string, string>(keyAndValue[0], value);
                    if (lowerCaseIgnore.IndexOf(lowCaseKey) >= 0)
                        ignoreHeader.Add(pair);
                    else
                    {
                        int findIndex = lowerCaseHeaderSeq.IndexOf(lowCaseKey);
                        if (findIndex >= 0)
                            sortedHeader[findIndex] = pair;
                        else
                            sortedHeader.Add(pair);
                    }
                }
            }
            // 去掉没有出现在排序列表中的key
            for (int i = sortedHeader.Count - 1; i >= 0; i--)
            {
                if (sortedHeader[i].Key == string.Empty)
                    sortedHeader.RemoveAt(i);
            }
            // 以key-value形式打印忽略的header
            StringBuilder ignoreHeaderSB = new StringBuilder();
            foreach (KeyValuePair<string, string> pair in ignoreHeader)
                ignoreHeaderSB.AppendLine($"{pair.Key}:{pair.Value}");

            rtxIgnoreHeader.Text = ignoreHeaderSB.ToString();
            // 转为json
            JsonData jsonData = new JsonData();
            foreach (KeyValuePair<string, string> pair in sortedHeader)
                jsonData[pair.Key] = pair.Value;

            JsonWriter jsonWriter = new JsonWriter();
            jsonWriter.PrettyPrint = chkIsPrettyPrint.Checked;
            jsonData.ToJson(jsonWriter);
            rtxToApiPostJson.Text = jsonWriter.TextWriter.ToString().Trim();
            // 转为java代码
            StringBuilder javaSB = new StringBuilder();
            javaSB.AppendLine("Map<String, String> headers = new HashMap<String, String>();");
            foreach (KeyValuePair<string, string> pair in sortedHeader)
                javaSB.AppendLine($"headers.put(\"{pair.Key.Replace("\\", "\\\\").Replace("\"", "\\\"")}\", \"{pair.Value.Replace("\\", "\\\\").Replace("\"", "\\\"")}\");");

            rtxToJavaCode.Text = javaSB.ToString();
            // 转为cs代码
            StringBuilder csSB = new StringBuilder();
            csSB.AppendLine("Dictionary<string, string> headers = new Dictionary<string, string>();");
            foreach (KeyValuePair<string, string> pair in sortedHeader)
                csSB.AppendLine($"headers.Add(\"{pair.Key.Replace("\\", "\\\\").Replace("\"", "\\\"")}\", \"{pair.Value.Replace("\\", "\\\\").Replace("\"", "\\\"")}\");");

            rtxToCsCode.Text = csSB.ToString();
        }

        private void btnAnalyzeUrlQueryParams_Click(object sender, EventArgs e)
        {
            string decodeUrl = txtReqDecodeUrl.Text.Trim();
            if (string.IsNullOrEmpty(decodeUrl))
            {
                MessageBox.Show(this, "还未生成URL解码后的请求URL", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Uri uri = new Uri(decodeUrl);
            // uri.Query返回的string以?开头，要去掉?
            string query = uri.Query.Remove(0, 1);
            string[] keyValuePairs = query.Split(new string[] { "&" }, StringSplitOptions.RemoveEmptyEntries);
            if (keyValuePairs.Length < 1)
            {
                MessageBox.Show(this, "不含有任何Query键值对", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<KeyValuePair<string, string>> queryPairs = new List<KeyValuePair<string, string>>();
            int maxKeyNameLength = 0;
            foreach (string str in keyValuePairs)
            {
                // 这里要兼容没有对value赋值的情况
                if (str.Contains("=") == false)
                {
                    MessageBox.Show(this, $"解析Query错误，发现不含=的键值对为：{str}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string[] keyAndValue = str.Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
                if (maxKeyNameLength < keyAndValue[0].Length)
                    maxKeyNameLength = keyAndValue[0].Length;

                queryPairs.Add(new KeyValuePair<string, string>(keyAndValue[0], keyAndValue.Length > 1 ? keyAndValue[1] : string.Empty));
            }
            StringBuilder sb = new StringBuilder();
            // 注意：下面注释掉的写法和保留的写法，如果去掉\t，在文本框或控制台打印都是没问题的，在MessageBox中无法对齐
            //string lineFormat = "{0,-" + maxKeyNameLength + "}\t:{1}\n";
            foreach (KeyValuePair<string, string> pair in queryPairs)
            {
                //sb.AppendFormat(lineFormat, pair.Key, pair.Value);
                sb.AppendLine($"{pair.Key.PadRight(maxKeyNameLength)}\t:{pair.Value}");
            }
            MessageBox.Show(this, sb.ToString());
        }

        private void chkIsPrettyPrint_CheckedChanged(object sender, EventArgs e)
        {
            string json = rtxToApiPostJson.Text.Trim();
            if (string.IsNullOrEmpty(json))
                return;

            JsonData jsonData = null;
            try
            {
                jsonData = JsonMapper.ToObject(json);
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, $"json格式错误，原因为：\n{exception}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            JsonWriter jsonWriter = new JsonWriter();
            jsonWriter.PrettyPrint = chkIsPrettyPrint.Checked;
            jsonData.ToJson(jsonWriter);
            rtxToApiPostJson.Text = jsonWriter.TextWriter.ToString().Trim();
        }

        private void btnCopyApiPostJson_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtxToApiPostJson.Text);
        }

        private void btnCopyJavaCode_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtxToJavaCode.Text);
        }

        private void btnCopyCsCode_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtxToCsCode.Text);
        }
    }
}
