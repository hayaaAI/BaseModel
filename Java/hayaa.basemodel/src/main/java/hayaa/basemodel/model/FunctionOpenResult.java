package hayaa.basemodel.model;

public class FunctionOpenResult<T> extends BaseFunctionOpenResult {
    public FunctionOpenResult() {
        super();
    }

    public FunctionOpenResult(boolean actionResult) {
        super(actionResult);
    }
    private T data;
    public T getData() {
        return data;
    }

    public void setData(T data) {
        this.data = data;
    }


}
