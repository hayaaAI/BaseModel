using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Common
{
    /// <summary>
    /// 错误码集合
    /// </summary>
   public class ErrorCode
    {
        /// <summary>
        /// 登陆失败
        /// </summary>
        public const int LoginFail = 1001;
        /// <summary>
        /// 密码破解攻击
        /// </summary>
        public const int PwdAttack = 1002;
    }
}
