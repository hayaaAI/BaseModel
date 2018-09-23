package hayaa.redis.client;

import hayaa.basemodel.model.ConfigContent;

import java.util.Date;
import java.util.List;

class RedisClientConfig extends ConfigContent {
    public List<RedisConfig> getRedisConfigs() {
        return RedisConfigs;
    }

    public void setRedisConfigs(List<RedisConfig> redisConfigs) {
        RedisConfigs = redisConfigs;
    }

    private List<RedisConfig> RedisConfigs;
    private Integer code;
    private String message;
    private Date createTime;
    private Date updateTime;

    public Integer getCode() {
        return code;
    }

    public void setCode(Integer code) {
        this.code = code;
    }

    public String getMessage() {
        return message;
    }

    public void setMessage(String message) {
        this.message = message;
    }

    public Date getCreateTime() {
        return createTime;
    }

    public void setCreateTime(Date createTime) {
        this.createTime = createTime;
    }

    public Date getUpdateTime() {
        return updateTime;
    }

    public void setUpdateTime(Date updateTime) {
        this.updateTime = updateTime;
    }
}
