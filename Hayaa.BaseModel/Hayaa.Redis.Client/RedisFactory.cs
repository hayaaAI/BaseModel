﻿using Hayaa.Redis.Client.Config;
using Hayaa.Redis.Client.Model;
using StackExchange.Redis;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Hayaa.Redis.Client
{
    internal class RedisFactory
    {
        private  Dictionary<String, IDatabase> redisService = new Dictionary<string, IDatabase>();
        private  Dictionary<String, RedisConfig> redisConfig = null;
        internal RedisFactory(RedisClientConfig config)
        {
          
            if (config != null)
            {
                redisConfig = config.RedisConfigs.ToDictionary(k => k.Name, v => v);
            }
            else
            {
                throw new Exception("Redis缺少配置");
            }
        }
        public  IDatabase GetService(String name)
        {
            if (redisService.ContainsKey(name)) return redisService[name];
            var config = redisConfig.ContainsKey(name) ? redisConfig[name] : null;
            if (config == null) return null;
            ConfigurationOptions clientConfig = new ConfigurationOptions() {
                 Password= config.ServerPwd,
                EndPoints = { { config.HostName,config.Port} }
            };
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(clientConfig);
            IDatabase db = redis.GetDatabase();
            redisService.Add(name, db);
            return db;
        }
    }
}
