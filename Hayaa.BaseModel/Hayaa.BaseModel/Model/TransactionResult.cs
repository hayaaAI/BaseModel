using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.BaseModel.Model
{
    /// <summary>
    /// 传输结果容器
    /// </summary>
    [Serializable]
    public class TransactionResult<T>
    {
        /// <summary>
        /// 返回码
        /// </summary>
        public int Code { set; get; }
        /// <summary>
        /// 提示信息、异常信息
        /// </summary>
        public String Message { set; get; }
        /// <summary>
        /// 数据结果
        /// </summary>
        public T Data { set; get; }
    }
}
