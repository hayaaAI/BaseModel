using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.BaseModel.Service
{
  public  interface IBaseService<T,SEARCHPAMATER> where T: BaseData where SEARCHPAMATER : class,new()
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
        /// 根据主键获取数据
        /// </summary>
        /// <param name="Id">主键</param>
        /// <returns></returns>
        FunctionResult<T> Get(int Id);
        /// <summary>
        /// 根据参数获取列表
        /// </summary>
        /// <param name="pamater">参数类</param>
        /// <returns></returns>
        FunctionListResult<T> GetList(SEARCHPAMATER pamater);
        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name="searchParam">分页参数</param>
        /// <returns></returns>
        GridPager<T> GetPager(GridPagerPamater<SEARCHPAMATER> searchParam);
    }
}
