package hayaa.basemodel.model.GridPager;

public class OrderBy {
    private String OrderByName;
    private OrderDirection OrderByDirection;
    private int SortIndex;

    public String getOrderByName() {
        return OrderByName;
    }

    public void setOrderByName(String orderByName) {
        OrderByName = orderByName;
    }

    public OrderDirection getOrderByDirection() {
        return OrderByDirection;
    }

    public void setOrderByDirection(OrderDirection orderByDirection) {
        OrderByDirection = orderByDirection;
    }

    public int getSortIndex() {
        return SortIndex;
    }

    public void setSortIndex(int sortIndex) {
        SortIndex = sortIndex;
    }


}
