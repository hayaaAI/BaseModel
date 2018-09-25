package hayaa.redis.client;

import org.redisson.api.RBucket;
import org.redisson.api.RKeys;
import org.redisson.api.RedissonClient;

import java.util.concurrent.TimeUnit;

/**
 *
 * @author hsieh
 */
public class RedisService {
    private RedisFactory redisFactory = null;
    public RedisService(RedisClientConfig config)
    {
        redisFactory = new RedisFactory(config);
    }
    public  <T> void set(String name, String key, T data) {
        RedissonClient redis = redisFactory.GetService(name);
        if (redis != null) {
            RBucket<T> bucket = redis.getBucket(key);
            bucket.set(data);
        }
    }
    public  <T> T get(String name, String key) {
        T data = null;
        RedissonClient redis = redisFactory.GetService(name);
        if (redis != null) {
            RBucket<T> bucket = redis.getBucket(key);
            data = bucket.get();
        }
        return data;
    }
    public  <T> void set(String name, String key, T data,int cacheSeconds) {
        RedissonClient redis = redisFactory.GetService(name);
        if (redis != null) {
            RBucket<T> bucket = redis.getBucket(key);
            bucket.set(data,cacheSeconds,TimeUnit.SECONDS);
        }
    }
    public  void delete(String name, String key)
    {
        RedissonClient redis = redisFactory.GetService(name);
        if (redis != null) {
            RKeys keys=redis.getKeys();
            keys.delete(key);
        }
    }
}
