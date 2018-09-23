package hayaa.redis.client;

import org.redisson.api.RBucket;
import org.redisson.api.RKeys;
import org.redisson.api.RedissonClient;

import java.util.concurrent.TimeUnit;

public class RedisService {
    public static <T> void set(String name, String key, T data) {
        RedissonClient redis = RedisFactory.GetService(name);
        if (redis != null) {
            RBucket<T> bucket = redis.getBucket(key);
            bucket.set(data);
        }
    }
    public static <T> T get(String name, String key) {
        T data = null;
        RedissonClient redis = RedisFactory.GetService(name);
        if (redis != null) {
            RBucket<T> bucket = redis.getBucket(key);
            data = bucket.get();
        }
        return data;
    }
    public static <T> void set(String name, String key, T data,int cacheSeconds) {
        RedissonClient redis = RedisFactory.GetService(name);
        if (redis != null) {
            RBucket<T> bucket = redis.getBucket(key);
            bucket.set(data,cacheSeconds,TimeUnit.SECONDS);
        }
    }
    public static void delete(String name, String key)
    {
        RedissonClient redis = RedisFactory.GetService(name);
        if (redis != null) {
            RKeys keys=redis.getKeys();
            keys.delete(key);
        }
    }
}
