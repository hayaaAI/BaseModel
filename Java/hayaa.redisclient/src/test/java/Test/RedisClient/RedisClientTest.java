package Test.RedisClient;

import Hayaa.ConfigSeed.AppSeed;
import hayaa.redis.client.RedisService;
import org.junit.Test;

public class RedisClientTest {
    @Test
    public void testRedisClient() {

        AppSeed.Instance().InitConfig();
        Data d1=new Data();
        d1.setId("1");
        RedisService.set("default","d1",d1);
        Data d2=RedisService.get("default","d1");
    }
}
