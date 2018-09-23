package hayaa.redis.client;

import org.redisson.Redisson;
import org.redisson.api.RedissonClient;
import org.redisson.config.Config;
import java.util.HashMap;
import java.util.Map;
import java.util.stream.Collectors;

class RedisFactory {
    private static Map<String, RedissonClient> redisService = new HashMap<>();
    private static Map<String, RedisConfig> redisConfig = null;
    static {
        RedisClientConfig config=ConfigHelper.getInstance().GetComponentConfig();
        if(config!=null){
            redisConfig=config.getRedisConfigs().stream().collect(Collectors.toMap(RedisConfig::getName,redisConfig->redisConfig));
        }else {
            System.out.println("Redis缺少配置");
        }
    }
    public static RedissonClient GetService(String name)
    {
        if (redisService.containsKey(name)) return redisService.get(name);
        RedisConfig config = redisConfig.containsKey(name) ? redisConfig.get(name): null;
        if (config == null) return null;
        Config redissssionConfig = new Config();
        redissssionConfig.useMasterSlaveServers().setMasterAddress("redis://"+config.getHostName()+":"+config.getPort())
                .addSlaveAddress("redis://"+config.getHostName()+":"+config.getPort());
        RedissonClient redisson = Redisson.create(redissssionConfig);
        redisService.put(name, redisson);
        return redisson;
    }
}
