using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
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
        private static JsonSerializerSettings settings = new JsonSerializerSettings()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            Formatting = Formatting.Indented
        };       
        public static String SerializeObject<T>(T data, bool small = false) where T : class
        {
            if (small)
                return JsonConvert.SerializeObject(data, settings);
            else
                return JsonConvert.SerializeObject(data);
        }
        public static String SerlaizeSafe<T>(T data, bool small = false) where T : class
        {
            String r = null;
            try
            {
                if (small)
                    r = JsonConvert.SerializeObject(data, settings);
                else
                    r = JsonConvert.SerializeObject(data);
            }
            catch { }
            return r;
        }
        public static T Deserialize<T>(String jsonData, bool small = false) where T : class
        {
            if (small)
                return JsonConvert.DeserializeObject<T>(jsonData, settings);
            else
                return JsonConvert.DeserializeObject<T>(jsonData);
        }
        public static T Deserialize<T>(String jsonData, Type type, bool small = false) where T:class
        {
            if (small)
                return (T)JsonConvert.DeserializeObject(jsonData, type, settings);
            else
                return (T)JsonConvert.DeserializeObject(jsonData, type);
        }
        public static Object DeserializeObject(String jsonData, Type type, bool small = false)
        {
            if (small)
                return JsonConvert.DeserializeObject(jsonData, type, settings);
            else
                return JsonConvert.DeserializeObject(jsonData, type);
        }
        public static T DeserializeSafe<T>(String data, bool small = false) where T : class
        {
            T r = default(T);
            try
            {
                r = Deserialize<T>(data, small);
            }
            catch
            {

            }
            return r;
        }
       
    }
}
