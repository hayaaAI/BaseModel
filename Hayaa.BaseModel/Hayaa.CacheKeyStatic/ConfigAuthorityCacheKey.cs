using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.CacheKeyStatic
{
   public class ConfigAuthorityCacheKey
    {
        /// <summary>
        /// 远程配置key，以AppId做为变量
        /// </summary>
        public const String AuthorityCacheKey = "configauth_token_{0}";
        
    }
}
