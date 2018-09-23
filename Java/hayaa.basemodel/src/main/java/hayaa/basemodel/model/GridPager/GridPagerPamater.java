package hayaa.basemodel.model.GridPager;

import java.util.List;

public class GridPagerPamater<T> {
    private int Current;
    private int PageSize;
    private T SearchPamater;
    private List<GroupBy> GroupBy;
    private List<OrderBy> OrderBy;

    public int getCurrent() {
        return Current;
    }

    public void setCurrent(int current) {
        Current = current;
    }

    public int getPageSize() {
        return PageSize;
    }

    public void setPageSize(int pageSize) {
        PageSize = pageSize;
    }

    public T getSearchPamater() {
        return SearchPamater;
    }

    public void setSearchPamater(T searchPamater) {
        SearchPamater = searchPamater;
    }

    public List<hayaa.basemodel.model.GridPager.GroupBy> getGroupBy() {
        return GroupBy;
    }

    public void setGroupBy(List<hayaa.basemodel.model.GridPager.GroupBy> groupBy) {
        GroupBy = groupBy;
    }

    public List<hayaa.basemodel.model.GridPager.OrderBy> getOrderBy() {
        return OrderBy;
    }

    public void setOrderBy(List<hayaa.basemodel.model.GridPager.OrderBy> orderBy) {
        OrderBy = orderBy;
    }


}
