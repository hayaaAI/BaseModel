using System;

namespace Hayaa.BaseModel
{
    /// <summary>
    /// 函数执行结果容器
    /// 跨模块方法使用此容器，耦合强的类之间不使用
    /// </summary>
    /// <typeparam name="T">业务数据模型类</typeparam>
    [Serializable]
    public class FunctionResult<T>:BaseFunctionResult where T:BaseData
    {
        public FunctionResult():base()
        {

        }
        public FunctionResult(bool actionResult) : base(actionResult)
        {

        }
        private T g_data;
        /// <summary>
        /// 函数执行返回结果:数据、业务码、业务返回信息
        /// </summary>
        public  T Data
        {
            set
            {
                g_data = value;
                if (g_data != null) 
                {
                    this.HavingData = true;
                }
            }
            get
            {
                return g_data;
            }
        }
    }
}
