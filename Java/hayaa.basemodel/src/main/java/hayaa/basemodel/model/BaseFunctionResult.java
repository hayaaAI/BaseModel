package hayaa.basemodel.model;

import java.io.Serializable;

public class BaseFunctionResult implements Serializable {
    public BaseFunctionResult() {
        this.ActionResult = true;
        this.HavingData = false;
    }

    public BaseFunctionResult(boolean actionResult, boolean havingData) {
        this.ActionResult = actionResult;
        this.HavingData = havingData;
        if (!actionResult) {
            this.HavingData = false;
        }

    }

    private boolean ActionResult;
    private int ErrorCode;
    private String ErrorMsg;
    private boolean HavingData;

    public boolean isHavingData() {
        return HavingData;
    }

    public void setHavingData(boolean havingData) {
        HavingData = havingData;
    }


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
