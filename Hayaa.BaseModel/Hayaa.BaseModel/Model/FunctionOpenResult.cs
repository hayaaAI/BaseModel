using System;

namespace Hayaa.BaseModel
{
    /// <summary>
    /// 函数执行结果容器
    /// 跨模块方法使用此容器，耦合强的类之间不使用
    /// </summary>
    /// <typeparam name="T">开放数据类型</typeparam>
    [Serializable]
    public class FunctionOpenResult<T>: BaseFunctionOpenResult 
    {
        public FunctionOpenResult():base()
        {

        }
        public FunctionOpenResult(bool actionResult) : base(actionResult)
        {

        }
         /// <summary>
        /// 函数执行返回结果:数据、业务码、业务返回信息
        /// </summary>
        public  T Data
        {
            set;get;
        }
    }
}
