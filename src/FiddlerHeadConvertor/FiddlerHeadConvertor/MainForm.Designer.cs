
namespace FiddlerHeadConvertor
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rtxInputRawHeader = new System.Windows.Forms.RichTextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRequestType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReqUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReqDecodeUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxToApiPostJson = new System.Windows.Forms.RichTextBox();
            this.rtxToJavaCode = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHttpVersion = new System.Windows.Forms.Label();
            this.btnAnalyzeUrlQueryParams = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rtxIgnoreHeader = new System.Windows.Forms.RichTextBox();
            this.txtContentType = new System.Windows.Forms.TextBox();
            this.chkIsPrettyPrint = new System.Windows.Forms.CheckBox();
            this.btnCopyApiPostJson = new System.Windows.Forms.Button();
            this.btnCopyJavaCode = new System.Windows.Forms.Button();
            this.rtxToCsCode = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCopyCsCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raw视图下Header原文：";
            // 
            // rtxInputRawHeader
            // 
            this.rtxInputRawHeader.Location = new System.Drawing.Point(12, 44);
            this.rtxInputRawHeader.Name = "rtxInputRawHeader";
            this.rtxInputRawHeader.Size = new System.Drawing.Size(940, 184);
            this.rtxInputRawHeader.TabIndex = 1;
            this.rtxInputRawHeader.Text = "";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(175, 13);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 2;
            this.btnAnalyze.Text = "分析";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "请求方法：";
            // 
            // lblRequestType
            // 
            this.lblRequestType.AutoSize = true;
            this.lblRequestType.Location = new System.Drawing.Point(82, 242);
            this.lblRequestType.Name = "lblRequestType";
            this.lblRequestType.Size = new System.Drawing.Size(23, 12);
            this.lblRequestType.TabIndex = 4;
            this.lblRequestType.Text = "GET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "请求地址：";
            // 
            // txtReqUrl
            // 
            this.txtReqUrl.Location = new System.Drawing.Point(82, 263);
            this.txtReqUrl.Multiline = true;
            this.txtReqUrl.Name = "txtReqUrl";
            this.txtReqUrl.Size = new System.Drawing.Size(870, 44);
            this.txtReqUrl.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "URL解码后\r\n的请求地址：";
            // 
            // txtReqDecodeUrl
            // 
            this.txtReqDecodeUrl.Location = new System.Drawing.Point(82, 313);
            this.txtReqDecodeUrl.Multiline = true;
            this.txtReqDecodeUrl.Name = "txtReqDecodeUrl";
            this.txtReqDecodeUrl.Size = new System.Drawing.Size(870, 44);
            this.txtReqDecodeUrl.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "转为ApiPost能导入的json形式：";
            // 
            // rtxToApiPostJson
            // 
            this.rtxToApiPostJson.Location = new System.Drawing.Point(11, 407);
            this.rtxToApiPostJson.Name = "rtxToApiPostJson";
            this.rtxToApiPostJson.Size = new System.Drawing.Size(450, 332);
            this.rtxToApiPostJson.TabIndex = 10;
            this.rtxToApiPostJson.Text = "";
            // 
            // rtxToJavaCode
            // 
            this.rtxToJavaCode.Location = new System.Drawing.Point(502, 407);
            this.rtxToJavaCode.Name = "rtxToJavaCode";
            this.rtxToJavaCode.Size = new System.Drawing.Size(450, 179);
            this.rtxToJavaCode.TabIndex = 11;
            this.rtxToJavaCode.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "转为Java代码文件：";
            // 
            // lblHttpVersion
            // 
            this.lblHttpVersion.AutoSize = true;
            this.lblHttpVersion.Location = new System.Drawing.Point(164, 242);
            this.lblHttpVersion.Name = "lblHttpVersion";
            this.lblHttpVersion.Size = new System.Drawing.Size(65, 12);
            this.lblHttpVersion.TabIndex = 13;
            this.lblHttpVersion.Text = "HTTP版本号";
            // 
            // btnAnalyzeUrlQueryParams
            // 
            this.btnAnalyzeUrlQueryParams.Location = new System.Drawing.Point(825, 234);
            this.btnAnalyzeUrlQueryParams.Name = "btnAnalyzeUrlQueryParams";
            this.btnAnalyzeUrlQueryParams.Size = new System.Drawing.Size(127, 23);
            this.btnAnalyzeUrlQueryParams.TabIndex = 14;
            this.btnAnalyzeUrlQueryParams.Text = "解析Query参数";
            this.btnAnalyzeUrlQueryParams.UseVisualStyleBackColor = true;
            this.btnAnalyzeUrlQueryParams.Click += new System.EventHandler(this.btnAnalyzeUrlQueryParams_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "Content-Type：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 756);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 60);
            this.label8.TabIndex = 17;
            this.label8.Text = "忽\r\n略\r\n的\r\n参\r\n数";
            // 
            // rtxIgnoreHeader
            // 
            this.rtxIgnoreHeader.Location = new System.Drawing.Point(43, 756);
            this.rtxIgnoreHeader.Name = "rtxIgnoreHeader";
            this.rtxIgnoreHeader.Size = new System.Drawing.Size(418, 60);
            this.rtxIgnoreHeader.TabIndex = 18;
            this.rtxIgnoreHeader.Text = "";
            // 
            // txtContentType
            // 
            this.txtContentType.Location = new System.Drawing.Point(354, 236);
            this.txtContentType.Name = "txtContentType";
            this.txtContentType.Size = new System.Drawing.Size(389, 21);
            this.txtContentType.TabIndex = 19;
            // 
            // chkIsPrettyPrint
            // 
            this.chkIsPrettyPrint.AutoSize = true;
            this.chkIsPrettyPrint.Checked = true;
            this.chkIsPrettyPrint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsPrettyPrint.Location = new System.Drawing.Point(194, 378);
            this.chkIsPrettyPrint.Name = "chkIsPrettyPrint";
            this.chkIsPrettyPrint.Size = new System.Drawing.Size(84, 16);
            this.chkIsPrettyPrint.TabIndex = 20;
            this.chkIsPrettyPrint.Text = "格式化输出";
            this.chkIsPrettyPrint.UseVisualStyleBackColor = true;
            this.chkIsPrettyPrint.CheckedChanged += new System.EventHandler(this.chkIsPrettyPrint_CheckedChanged);
            // 
            // btnCopyApiPostJson
            // 
            this.btnCopyApiPostJson.Location = new System.Drawing.Point(362, 374);
            this.btnCopyApiPostJson.Name = "btnCopyApiPostJson";
            this.btnCopyApiPostJson.Size = new System.Drawing.Size(99, 23);
            this.btnCopyApiPostJson.TabIndex = 21;
            this.btnCopyApiPostJson.Text = "复制到剪贴板";
            this.btnCopyApiPostJson.UseVisualStyleBackColor = true;
            this.btnCopyApiPostJson.Click += new System.EventHandler(this.btnCopyApiPostJson_Click);
            // 
            // btnCopyJavaCode
            // 
            this.btnCopyJavaCode.Location = new System.Drawing.Point(853, 374);
            this.btnCopyJavaCode.Name = "btnCopyJavaCode";
            this.btnCopyJavaCode.Size = new System.Drawing.Size(99, 23);
            this.btnCopyJavaCode.TabIndex = 22;
            this.btnCopyJavaCode.Text = "复制到剪贴板";
            this.btnCopyJavaCode.UseVisualStyleBackColor = true;
            this.btnCopyJavaCode.Click += new System.EventHandler(this.btnCopyJavaCode_Click);
            // 
            // rtxToCsCode
            // 
            this.rtxToCsCode.Location = new System.Drawing.Point(502, 637);
            this.rtxToCsCode.Name = "rtxToCsCode";
            this.rtxToCsCode.Size = new System.Drawing.Size(450, 179);
            this.rtxToCsCode.TabIndex = 23;
            this.rtxToCsCode.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(500, 610);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 24;
            this.label9.Text = "转为C#代码文件：";
            // 
            // btnCopyCsCode
            // 
            this.btnCopyCsCode.Location = new System.Drawing.Point(853, 605);
            this.btnCopyCsCode.Name = "btnCopyCsCode";
            this.btnCopyCsCode.Size = new System.Drawing.Size(99, 23);
            this.btnCopyCsCode.TabIndex = 25;
            this.btnCopyCsCode.Text = "复制到剪贴板";
            this.btnCopyCsCode.UseVisualStyleBackColor = true;
            this.btnCopyCsCode.Click += new System.EventHandler(this.btnCopyCsCode_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 828);
            this.Controls.Add(this.btnCopyCsCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rtxToCsCode);
            this.Controls.Add(this.btnCopyJavaCode);
            this.Controls.Add(this.btnCopyApiPostJson);
            this.Controls.Add(this.chkIsPrettyPrint);
            this.Controls.Add(this.txtContentType);
            this.Controls.Add(this.rtxIgnoreHeader);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAnalyzeUrlQueryParams);
            this.Controls.Add(this.lblHttpVersion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtxToJavaCode);
            this.Controls.Add(this.rtxToApiPostJson);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtReqDecodeUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReqUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRequestType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.rtxInputRawHeader);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Fiddler抓包Header信息转换器 by 张齐 （https://github.com/zhangqi-ulua）";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxInputRawHeader;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRequestType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReqUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReqDecodeUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxToApiPostJson;
        private System.Windows.Forms.RichTextBox rtxToJavaCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHttpVersion;
        private System.Windows.Forms.Button btnAnalyzeUrlQueryParams;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtxIgnoreHeader;
        private System.Windows.Forms.TextBox txtContentType;
        private System.Windows.Forms.CheckBox chkIsPrettyPrint;
        private System.Windows.Forms.Button btnCopyApiPostJson;
        private System.Windows.Forms.Button btnCopyJavaCode;
        private System.Windows.Forms.RichTextBox rtxToCsCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCopyCsCode;
    }
}

