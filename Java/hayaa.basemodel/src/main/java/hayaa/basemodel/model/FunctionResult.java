package hayaa.basemodel.model;

public class FunctionResult<T extends BaseData> extends BaseFunctionResult {
    public FunctionResult() {
        super();
    }

    public FunctionResult(boolean actionResult) {
        super(actionResult, false);
    }

    private T data;

    public T getData() {
        return data;
    }

    public void setData(T data) {
        this.data = data;
        if (data != null) {
            this.setHavingData(true);
        }
    }
}
