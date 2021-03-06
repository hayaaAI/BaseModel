﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.BaseModel
{
    /// <summary>
    /// 函数执行过程结果类
    /// </summary>
    [Serializable]
    public class BaseFunctionOpenResult
    {
        public BaseFunctionOpenResult()
        {
            this.ActionResult = true;           
        }
        public BaseFunctionOpenResult(bool actionResult)
        {
            this.ActionResult = actionResult;          
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
       
    }
}
