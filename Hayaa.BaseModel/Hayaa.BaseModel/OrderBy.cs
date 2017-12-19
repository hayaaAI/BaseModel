using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.BaseModel
{
    /// <summary>
    /// 排序元数据
    /// </summary>
   public class OrderBy
    {
        /// <summary>
        /// 数据要排序属性名称
        /// </summary>
        public String OrderByName { set; get; }
        /// <summary>
        /// 排序类型
        /// </summary>
        public OrderDirection OrderByDirection { set; get; }
        /// <summary>
        /// 排序优先级别，小数字靠前，相同数字则随机
        /// </summary>
        public int SortIndex { set; get; }
    }
}
