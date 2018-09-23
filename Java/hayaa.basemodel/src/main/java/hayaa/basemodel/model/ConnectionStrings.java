package hayaa.basemodel.model;

import java.util.List;

public class ConnectionStrings {
    public List<ConnectionInfo> Settings;

    public class ConnectionInfo {
        private String Name;
        private String Connection;

        public String getName() {
            return Name;
        }

        public void setName(String name) {
            Name = name;
        }

        public String getConnection() {
            return Connection;
        }

        public void setConnection(String connection) {
            Connection = connection;
        }


    }
}
