package hayaa.redis.client;

import Hayaa.ConfigSeed.ConfigTool;

class ConfigHelper extends ConfigTool<RedisClientConfig,RedisClientRootConfig> {
    public static ConfigHelper getInstance() {
        return _instance;
    }
    private static ConfigHelper _instance = new ConfigHelper();
    public ConfigHelper(int componentID, Class<RedisClientConfig> componentConfigType, Class<RedisClientRootConfig> appRootConfigType) {
        super(componentID, componentConfigType, appRootConfigType);
    }
    private ConfigHelper(){
        super(DefineTable.RedisClientComponetID,RedisClientConfig.class,RedisClientRootConfig.class);
    }
}
