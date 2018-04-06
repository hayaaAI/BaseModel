using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.BaseModel
{
    /// <summary>
    /// 分页数据容器类,2147483647数据量内使用此类
    /// </summary>
    [Serializable]
    public class GridPager<T>: FunctionListResult<T> where T:BaseData
    {
        /// <summary>
        /// 当前指向数据页
        /// </summary>
        public int CurrentIndex { set; get; }
        /// <summary>
        /// 数据页尺寸
        /// </summary>
        public int PageSize { set; get; }
        /// <summary>
        ///数据总量
        /// </summary>
        public int Total { set; get; }
       
    }
}
