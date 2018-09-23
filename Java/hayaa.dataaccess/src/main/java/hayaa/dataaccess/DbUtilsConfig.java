package hayaa.dataaccess;

public class DbUtilsConfig {
    private String url;
    private String driverClass;
    private String dbUserName;
    private String dbUserPwd;
    private Boolean defaultAutoCommit;
     private Integer maxIdle;

    public String getUrl() {
        return url;
    }

    public void setUrl(String url) {
        this.url = url;
    }

    public String getDriverClass() {
        return driverClass;
    }

    public void setDriverClass(String driverClass) {
        this.driverClass = driverClass;
    }

    public String getDbUserName() {
        return dbUserName;
    }

    public void setDbUserName(String dbUserName) {
        this.dbUserName = dbUserName;
    }

    public String getDbUserPwd() {
        return dbUserPwd;
    }

    public void setDbUserPwd(String dbUserPwd) {
        this.dbUserPwd = dbUserPwd;
    }

    public Boolean getDefaultAutoCommit() {
        return defaultAutoCommit;
    }

    public void setDefaultAutoCommit(Boolean defaultAutoCommit) {
        this.defaultAutoCommit = defaultAutoCommit;
    }


    public Integer getMaxIdle() {
        return maxIdle;
    }

    public void setMaxIdle(Integer maxIdle) {
        this.maxIdle = maxIdle;
    }



}
