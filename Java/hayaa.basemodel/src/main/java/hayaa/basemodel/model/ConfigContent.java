package hayaa.basemodel.model;

import java.util.List;

public abstract class ConfigContent {
    private AppSettings appSettings;
    private ConnectionStrings connectionStrings;
    private List<MariadbConfig> dbConfigs;
    public List<MariadbConfig> getDbConfigs() {
        return dbConfigs;
    }
    public void setDbConfigs(List<MariadbConfig> dbConfigs) {
        this.dbConfigs = dbConfigs;
    }
    public AppSettings getAppSettings() {
        return appSettings;
    }

    public void setAppSettings(AppSettings appSettings) {
        this.appSettings = appSettings;
    }

    public ConnectionStrings getConnectionStrings() {
        return connectionStrings;
    }

    public void setConnectionStrings(ConnectionStrings connectionStrings) {
        this.connectionStrings = connectionStrings;
    }


}
