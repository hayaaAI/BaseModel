using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.BaseModel
{
    /// <summary>
    /// 大数据分页参数
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BigGridPagerPamater<T> where T:class,new() 
    {
        /// <summary>
        /// 请求页
        /// </summary>
        public long Current { set; get; }
        /// <summary>
        /// 数据页尺寸
        /// </summary>
        public long PageSize { set; get; }
        /// <summary>
        /// 搜素参数
        /// </summary>
        public T SearchPamater { set; get; }
        /// <summary>
        /// 分组字段，get输出时为已排序
        /// </summary>
       public List<GroupBy> GroupBy { set; get; }
        /// <summary>
        /// 排序字段，get输出时为已排序
        /// </summary>
        public List<OrderBy> OrderBy { set; get; }
    }
}
