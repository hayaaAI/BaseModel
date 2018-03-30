using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.BaseModel
{
    /// <summary>
    /// 分组元数据
    /// </summary>
    [Serializable]
    public  class GroupBy
    {
        /// <summary>
        /// 分组名称
        /// </summary>
        public String GroupByName { set; get; }
        /// <summary>
        /// 排序优先级别，小数字靠前，相同数字则随机
        /// </summary>
        public int SortIndex { set; get; }
    }
}
