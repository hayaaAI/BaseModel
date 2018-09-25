package hayaa.redis.client;
import java.util.List;

class RedisClientConfig {
    public List<RedisConfig> getRedisConfigs() {
        return RedisConfigs;
    }

    public void setRedisConfigs(List<RedisConfig> redisConfigs) {
        RedisConfigs = redisConfigs;
    }

    private List<RedisConfig> RedisConfigs;
}
