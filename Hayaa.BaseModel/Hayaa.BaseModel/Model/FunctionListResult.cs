using System;
using System.Collections.Generic;

namespace Hayaa.BaseModel
{
    /// <summary>
    /// 函数执行结果容器
    /// </summary>
    /// <typeparam name="T">业务数据模型类</typeparam>
    public class FunctionListResult<T> : BaseFunctionResult where T : BaseData
    {
        public FunctionListResult() : base()
        {

        }
        public FunctionListResult(bool actionResult) : base(actionResult)
        {

        }
        private List<T> g_data;
        /// <summary>
        /// 函数执行返回结果:数据、业务码、业务返回信息
        /// </summary>
        public List<T> Data
        {
            set
            {
                g_data = value;
                if ((g_data!= null) || (g_data.Count>0))
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
