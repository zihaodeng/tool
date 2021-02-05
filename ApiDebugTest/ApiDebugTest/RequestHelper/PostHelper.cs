using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApiDebug.RequestHelper
{
    /**
     * .NET网络请求助手
     */ 
    public class PostHelper : INetRequest
    {

        /// <summary>
        /// 超时时间 单位毫秒
        /// </summary>
        private const int TIMEOUT = 10 * 1000;

        private const string CONTENT_TYPE = "application/json";

        private string method;
        public string Method
        {
            get { return method; }
        }

        private string url;
        public string Url
        {
            get { return url; }
        }

        public PostHelper(string requestType, string url)
        {
            this.method = requestType;
            this.url = url;
        }

        /// <summary>
        /// POST请求
        /// </summary>
        /// <param name="url">POST请求地址</param>
        /// <param name="postData">json格式的请求报文,例如：{"key1":"value1","key2":"value2"}</param>
        /// <returns></returns>
        public string PostRequest(string postData)
        {
            string result = string.Empty;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = method;
            //req.Timeout = TIMEOUT;//设置请求超时时间，单位为毫秒
            req.ContentType = CONTENT_TYPE;
#if KD
            //req.Headers.Add("cookie", COOKIE);
#endif
            byte[] data = Encoding.UTF8.GetBytes(postData);
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }

            using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
            {
                using (Stream stream = resp.GetResponseStream())
                {
                    //获取响应内容
                    using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                    {
                        result = reader.ReadToEnd();
                    }
                }
            }

            return result;
        }
    }
}