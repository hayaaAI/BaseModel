package hayaa.basemodel.model;

import java.io.Serializable;

public class BaseFunctionOpenResult implements Serializable {
    public BaseFunctionOpenResult()
    {
        this.ActionResult = true;
    }
    public BaseFunctionOpenResult(boolean actionResult) {
        this.ActionResult = actionResult;
    }

    private boolean ActionResult;
    private int ErrorCode;
    private String ErrorMsg;

    public boolean isActionResult() {
        return ActionResult;
    }

    public void setActionResult(boolean actionResult) {
        ActionResult = actionResult;
    }

    public int getErrorCode() {
        return ErrorCode;
    }

    public void setErrorCode(int errorCode) {
        ErrorCode = errorCode;
    }

    public String getErrorMsg() {
        return ErrorMsg;
    }

    public void setErrorMsg(String errorMsg) {
        ErrorMsg = errorMsg;
    }


}
