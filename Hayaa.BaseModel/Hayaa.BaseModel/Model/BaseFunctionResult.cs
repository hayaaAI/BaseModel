using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.BaseModel
{
    /// <summary>
    /// 函数执行过程结果类
    /// </summary>
   public class BaseFunctionResult
    {
        public BaseFunctionResult()
        {
            this.ActionResult = true;
            this.HavingData = false;
        }
        public BaseFunctionResult(bool actionResult,bool havingData=false)
        {
            this.ActionResult = actionResult;
            this.HavingData = havingData;
            if (!actionResult)
            {
                this.HavingData = false;
            }
           
        }
        /// <summary>
        /// 函数执行过程true表示正常，false表示有异常
        /// </summary>
        public bool ActionResult { set; get; }       
        /// <summary>
        /// 函数异常码
        /// </summary>
        public int ErrorCode { set; get; }
        /// <summary>
        /// 函数执行异常返回信息
        /// </summary>
        public string ErrorMsg { set; get; }
        /// <summary>
        /// 是否有数据,true表示有数据false表示没有
        /// </summary>
        public bool HavingData { set; get; }
    }
}
