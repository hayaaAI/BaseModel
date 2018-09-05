using Hayaa.Common;
using Hayaa.Redis.Client.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Redis.Client
{
   public class RedisService
    {
        private RedisFactory redisFactory = null;
        public RedisService(RedisClientConfig config)
        {
            redisFactory = new RedisFactory(config);
        }
        public  void Set<T>(String name, String key, T data) where T:class
        {
            var redis = redisFactory.GetService(name);
            if (redis != null)
            {
                redis.StringSet(key, JsonHelper.SerlaizeSafe<T>(data));
            }
        }
       
        public  T Get<T>(String name, String key) where T : class
        {
            T data = default(T);
            var redis = redisFactory.GetService(name);
            if (redis != null)
            {
              String redisResult=  redis.StringGet(key);
                if (!String.IsNullOrEmpty(redisResult))
                {
                    data = JsonHelper.Deserialize<T>(redisResult);
                }
            }
            return data;
        }
      

        public  void Set<T>(String name, String key, T data,int cacheSeconds) where T : class
        {
            var redis = redisFactory.GetService(name);
            if (redis != null)
            {
                redis.StringSet(key, JsonHelper.SerlaizeSafe<T>(data),new TimeSpan(0,0, cacheSeconds));
            }
        }
        public  void Delete(String name, String key)
        {
          
            var redis = redisFactory.GetService(name);
            if (redis != null)
            {
                redis.KeyDelete(key);
            }
        }
    }
}
