package hayaa.basemodel.model.GridPager;

import hayaa.basemodel.model.BaseData;
import hayaa.basemodel.model.FunctionResult;

public class BigGridPager<T extends BaseData> extends FunctionResult<T> {
    private long CurrentIndex;
    private long PageSize;
    private long PageTotal;

    public long getCurrentIndex() {
        return CurrentIndex;
    }

    public void setCurrentIndex(long currentIndex) {
        CurrentIndex = currentIndex;
    }

    public long getPageSize() {
        return PageSize;
    }

    public void setPageSize(long pageSize) {
        PageSize = pageSize;
    }

    public long getPageTotal() {
        return PageTotal;
    }

    public void setPageTotal(long pageTotal) {
        PageTotal = pageTotal;
    }


}
