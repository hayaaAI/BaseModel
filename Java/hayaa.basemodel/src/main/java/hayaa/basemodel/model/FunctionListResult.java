package hayaa.basemodel.model;

import java.util.List;

public class FunctionListResult<T extends BaseData> extends BaseFunctionResult {
    public FunctionListResult() {
        super();
    }

    public FunctionListResult(boolean actionResult) {
        super(actionResult, false);
    }

    private List<T> data;

    public List<T> getData() {
        return data;
    }

    public void setData(List<T> list) {
        data = list;
        if ((data != null) && (data.size() > 0)) {
            this.setHavingData(true);
        }
    }


}
