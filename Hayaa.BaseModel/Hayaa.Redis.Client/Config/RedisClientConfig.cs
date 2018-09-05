using Hayaa.Redis.Client.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Redis.Client.Config
{
    /// <summary>
    /// 服务配置类
    /// </summary>
    [Serializable]
    public class RedisClientConfig 
    {
        public List<RedisConfig> RedisConfigs { set; get;  }
      

    }
}
