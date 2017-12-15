using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.BaseModel
{
    /// <summary>
    /// 业务数据类约束抽象类,所有业务类必需继承此类
    /// </summary>
   
  public abstract  class BaseData
    {
        /// <summary>
        /// 业务返回码
        /// </summary>
        public int Code { set; get; }
        /// <summary>
        /// 业务返回提示信息
        /// </summary>
        public string Message { set; get; }
    }
}
