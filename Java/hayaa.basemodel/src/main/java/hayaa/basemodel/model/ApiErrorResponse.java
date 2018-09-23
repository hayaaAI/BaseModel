package hayaa.basemodel.model;

import java.io.Serializable;

public class ApiErrorResponse implements Serializable {
    public ApiErrorResponse(int errCode, String errMsg) {
        this.code = errCode;
        this.message = errMsg;
    }

    public int getCode() {
        return code;
    }

    public void setCode(int code) {
        this.code = code;
    }

    public String getMessage() {
        return message;
    }

    public void setMessage(String message) {
        this.message = message;
    }

    private int code;
    private String message;

}
