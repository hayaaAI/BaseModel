using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.BaseModel.Service
{
  public  interface IBaseService<T,GRIDPAMATER> where T: BaseData where GRIDPAMATER:class,new()
    {
        /// <summary>
        /// 创建数据
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        FunctionResult<T> Create(T info);
        /// <summary>
        /// 根据主键更新
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        FunctionOpenResult<bool> UpdateByID(T info);
        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        FunctionOpenResult<bool> DeleteByID(List<int> idList);
        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name="searchParam"></param>
        /// <returns></returns>
        GridPager<T> GetPager(GridPagerPamater<GRIDPAMATER> searchParam);
    }
}
