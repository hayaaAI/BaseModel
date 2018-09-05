using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.CacheKeyStatic
{
   public class UserAuthorityCacheKey
    {
        public const String AuthorityCacheKey = "userauth_token_{0}";
        public const String PermissionCacheKey = "userauth_permission_{0}";
    }
}
