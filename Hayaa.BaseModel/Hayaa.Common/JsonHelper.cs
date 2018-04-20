using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Common
{
    /// <summary>
    /// 基于Newtonsoft.Json快捷方法封装
    /// </summary>
    public class JsonHelper
    {
        public static String Serlaize<T>(T data)
        {
            return JsonConvert.SerializeObject(data);
        }
        public static String SerializeObject(Object data)
        {
            return JsonConvert.SerializeObject(data);
        }
        public static String SerlaizeSafe<T>(T data)
        {
            String r = null;
            try
            {
                r = JsonConvert.SerializeObject(data);
            }
            catch { }
            return r;
        }
        public static T Deserialize<T>(String data)
        {
            return JsonConvert.DeserializeObject<T>(data);
          
        }
        public static Object DeserializeObject(String data)
        {
            return JsonConvert.DeserializeObject(data);

        }
        public static T DeserializeSafe<T>(String data)
        {
            T r = default(T);
            try
            {
                r = JsonConvert.DeserializeObject<T>(data);
            }
            catch
            {

            }
            return r;
        }
       
    }
}
