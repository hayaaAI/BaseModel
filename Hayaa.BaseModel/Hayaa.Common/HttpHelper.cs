using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Hayaa.Common
{
    public class HttpHelper
    {
        /// <summary>
        /// http请求封装
        /// UTF-8编码
        /// </summary>
        /// <param name="requestUrl">请求路径</param>
        /// <param name="urlParam">参数</param>
        /// <param name="method">方法类型:post、get</param>
        /// <param name="contentType">contentType类型</param>
        /// <returns></returns>
        public static string HttpRequest(string requestUrl, Dictionary<string, string> urlParam, string method = "post", string contentType = "application/x-www-form-urlencoded")
        {
            if (!requestUrl.Contains("http"))
                requestUrl = string.Format("http://{0}", requestUrl);
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(requestUrl);
            Encoding encoding = Encoding.UTF8;
            StringBuilder param = new StringBuilder("&");
            if (urlParam != null)
            {
                foreach (var kv in urlParam)
                {
                    param.Append(string.Format("{0}={1}&", kv.Key, kv.Value));
                }
            }
            byte[] bs = Encoding.ASCII.GetBytes(param.ToString().TrimEnd('&'));
            string responseData = String.Empty;
            req.Method = method;
            req.ContentType = contentType;
            req.ContentLength = bs.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(bs, 0, bs.Length);
                reqStream.Close();
            }
            using (HttpWebResponse response = (HttpWebResponse)req.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), encoding))
                {
                    responseData = reader.ReadToEnd().ToString();
                }

            }
            return responseData;
        }
        /// <summary>
        /// 以body形式发送json数据
        /// </summary>
        /// <param name="JSONData"></param>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static string PostJson(string JSONData, string Url,int timeout=60000)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(JSONData);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "POST";
            request.ContentLength = bytes.Length;
            request.ContentType = "application/json; charset=utf-8";
            Stream reqstream = request.GetRequestStream();
            reqstream.Write(bytes, 0, bytes.Length);

            //声明一个HttpWebRequest请求  
            request.Timeout = timeout;
            //设置连接超时时间  
            request.Headers.Set("Pragma", "no-cache");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream streamReceive = response.GetResponseStream();
            Encoding encoding = Encoding.UTF8;

            StreamReader streamReader = new StreamReader(streamReceive, encoding);
            string strResult = streamReader.ReadToEnd();
            streamReceive.Dispose();
            streamReader.Dispose();

            return strResult;
        }
    }
}
