using System;

namespace Hayaa.BaseModel
{
    /// <summary>
    /// 函数执行结果容器
    /// </summary>
    /// <typeparam name="T">业务数据模型类</typeparam>
    public class FunctionResult<T>:BaseFunctionResult where T:BaseData
    {
        public FunctionResult():base()
        {

        }
        public FunctionResult(bool actionResult) : base(actionResult)
        {

        }
        /// <summary>
        /// 函数执行返回结果:数据、业务码、业务返回信息
        /// </summary>
        public T Data { set; get; }
    }
}
