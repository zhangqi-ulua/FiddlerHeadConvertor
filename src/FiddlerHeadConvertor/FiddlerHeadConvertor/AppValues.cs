using System.Collections.Generic;

namespace FiddlerHeadConvertor
{
    public class AppValues
    {
        // HTTP请求的八种方法
        public static readonly HashSet<string> HTTP_REQ_TYPE;
        // Header参数的排序规则
        public static readonly List<string> HEADER_KEY_SECQUENCE;
        // 忽略掉的参数
        public static readonly List<string> IGNORE_HEADER_KEY;

        static AppValues()
        {
            HTTP_REQ_TYPE = new HashSet<string>();
            HTTP_REQ_TYPE.Add("GET");
            HTTP_REQ_TYPE.Add("POST");
            HTTP_REQ_TYPE.Add("HEAD");
            HTTP_REQ_TYPE.Add("OPTIONS");
            HTTP_REQ_TYPE.Add("PUT");
            HTTP_REQ_TYPE.Add("DELETE");
            HTTP_REQ_TYPE.Add("TRACE");
            HTTP_REQ_TYPE.Add("CONNECT");

            HEADER_KEY_SECQUENCE = new List<string>();
            HEADER_KEY_SECQUENCE.Add("Host");
            HEADER_KEY_SECQUENCE.Add("User-Agent");
            HEADER_KEY_SECQUENCE.Add("Referer");
            HEADER_KEY_SECQUENCE.Add("Origin");
            HEADER_KEY_SECQUENCE.Add("sec-ch-ua");
            HEADER_KEY_SECQUENCE.Add("sec-ch-ua-mobile");
            HEADER_KEY_SECQUENCE.Add("Sec-Fetch-Dest");
            HEADER_KEY_SECQUENCE.Add("Sec-Fetch-Mode");
            HEADER_KEY_SECQUENCE.Add("Sec-Fetch-Site");
            HEADER_KEY_SECQUENCE.Add("X-Requested-With");
            HEADER_KEY_SECQUENCE.Add("Cookie");

            IGNORE_HEADER_KEY = new List<string>();
            IGNORE_HEADER_KEY.Add("Connection");
            IGNORE_HEADER_KEY.Add("Content-Length");
            IGNORE_HEADER_KEY.Add("Accept");
            IGNORE_HEADER_KEY.Add("Accept-Encoding");
            IGNORE_HEADER_KEY.Add("Accept-Language");            
        }
    }
}
