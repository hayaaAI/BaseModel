package hayaa.basemodel.service;

import hayaa.basemodel.model.BaseData;
import hayaa.basemodel.model.FunctionListResult;
import hayaa.basemodel.model.FunctionOpenResult;
import hayaa.basemodel.model.FunctionResult;
import hayaa.basemodel.model.GridPager.GridPager;
import hayaa.basemodel.model.GridPager.GridPagerPamater;


import java.util.List;

public interface IBaseService<T extends BaseData,SEARCHPAMATER>  {
    FunctionResult<T> Create(T info);
    FunctionOpenResult<Boolean> UpdateByID(T info);
    FunctionOpenResult<Boolean> DeleteByID(List<Integer> idList);
    GridPager<T> GetPager(GridPagerPamater<SEARCHPAMATER> searchParam);
    FunctionResult<T> Get(int Id);
    FunctionListResult<T> GetList(SEARCHPAMATER pamater);
}
