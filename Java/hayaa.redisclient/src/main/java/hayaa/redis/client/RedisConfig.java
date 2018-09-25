package hayaa.redis.client;

import java.io.Serializable;

class RedisConfig   implements Serializable  {
    private String name;
    private String hostName;
    private int port;
    private String serverPwd;


    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getHostName() {
        return hostName;
    }

    public void setHostName(String hostName) {
        this.hostName = hostName;
    }

    public String getServerPwd() {
        return serverPwd;
    }

    public void setServerPwd(String serverPwd) {
        this.serverPwd = serverPwd;
    }




    public int getPort() {
        return port;
    }

    public void setPort(int port) {
        this.port = port;
    }




}
