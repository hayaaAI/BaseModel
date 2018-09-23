package hayaa.basemodel.model;

import java.util.List;

public class AppSettings {
    public List<AppSetInfo> Settings;

    public class AppSetInfo {
        private String Key;
        private String Value;

        public String getKey() {
            return Key;
        }

        public void setKey(String key) {
            Key = key;
        }

        public String getValue() {
            return Value;
        }

        public void setValue(String value) {
            Value = value;
        }


    }
}
