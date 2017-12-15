using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.BaseModel
{
    /// <summary>
    /// 大数据分页数据容器类
    /// </summary>
  public  class BigGridPager<T>: FunctionResult<T> where T:BaseData
    {
        /// <summary>
        /// 当前指向数据页
        /// </summary>
        public long CurrentIndex { set; get; }
        /// <summary>
        /// 数据页尺寸
        /// </summary>
        public long PageSize { set; get; }
        /// <summary>
        /// 总页数
        /// </summary>
        public long PageTotal { set; get; }
    }
}
