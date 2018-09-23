package hayaa.basemodel.model.GridPager;

import hayaa.basemodel.model.BaseData;
import hayaa.basemodel.model.FunctionListResult;

public class GridPager<T extends BaseData> extends FunctionListResult<T> {
    private int CurrentIndex;
    private int PageSize;
    private int Total;
    public GridPager(int current,int size){
        this.CurrentIndex=current;
        this.PageSize=size;
    }
    public int getCurrentIndex() {
        return CurrentIndex;
    }

    public void setCurrentIndex(int currentIndex) {
        CurrentIndex = currentIndex;
    }

    public int getPageSize() {
        return PageSize;
    }

    public void setPageSize(int pageSize) {
        PageSize = pageSize;
    }

    public int getTotal() {
        return Total;
    }

    public void setTotal(int total) {
        Total = total;
    }


}
