using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.BaseModel
{
    /// <summary>
    /// 分页参数,2147483647数据量内使用此类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GridPagerPamater<T> where T : class, new()
    {
        /// <summary>
        /// 请求页
        /// </summary>
        public int Current { set; get; }
        /// <summary>
        /// 数据页尺寸
        /// </summary>
        public int PageSize { set; get; }
        /// <summary>
        /// 搜素参数
        /// </summary>
        public T SearchPamater { set; get; }
        private List<GroupBy> g_GroupB = new List<GroupBy>();
        /// <summary>
        /// 分组字段，get输出时为已排序
        /// </summary>
        public List<GroupBy> GroupBy
        {
            set { g_GroupB = value; }
            get
            {
                g_GroupB = GetSortedGroupBy(g_GroupB);
                return g_GroupB;
            }
        }
        /// <summary>
        /// 获取排序后的元数据
        /// </summary>
        /// <returns></returns>
        private List<GroupBy> GetSortedGroupBy(List<GroupBy> source)
        {
            source.Sort((x, y) =>
            {
                int result;
                if (x.SortIndex < y.SortIndex)
                {
                    result = 1;
                }
                else if (x.SortIndex == y.SortIndex)
                {
                    result = 0;
                }
                else
                {
                    result = -1;
                }
                return result;
            });
            return source;
        }
        private List<OrderBy> g_OrderBy = new List<OrderBy>();
        /// <summary>
        /// 排序字段，get输出时为已排序
        /// </summary>
        public List<OrderBy> OrderBy
        {
            set { g_OrderBy = value; }
            get
            {
                g_OrderBy = GetSortedOrderBy(g_OrderBy);
                return g_OrderBy;
            }
        }
        /// <summary>
        /// 获取排序后的元数据
        /// </summary>
        /// <returns></returns>
        private List<OrderBy> GetSortedOrderBy(List<OrderBy> source)
        {
            source.Sort((x, y) =>
            {
                int result;
                if (x.SortIndex < y.SortIndex)
                {
                    result = 1;
                }
                else if (x.SortIndex == y.SortIndex)
                {
                    result = 0;
                }
                else
                {
                    result = -1;
                }
                return result;
            });
            return source;
        }
    }
}
