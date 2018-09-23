package hayaa.common;


import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.google.gson.Gson;

import java.io.IOException;
import java.lang.reflect.Type;

public class JsonHelper {
    public static String SerializeObject(Object value) {
        String r = null;
        ObjectMapper mapper = new ObjectMapper();
        try {
            r = mapper.writeValueAsString(value);
        } catch (JsonProcessingException e) {
            e.printStackTrace();
        }
        return r;
    }

    public static <T> T DeserializeObject(String value, Class<T> valueType) {
        T r = null;
        ObjectMapper mapper = new ObjectMapper();
        try {
            r = mapper.readValue(value, valueType);
        } catch (IOException e) {
            e.printStackTrace();
        }
        return r;
    }

    public static <T> T DeserializeComplexObject(String value, TypeReference valueTypeRef) {
        T r = null;
        ObjectMapper mapper = new ObjectMapper();
        try {
            r = mapper.readValue(value, valueTypeRef);
        } catch (IOException e) {
            e.printStackTrace();
        }
        return r;
    }
    public static <T> T gsonDeserializeComplex(String value, Type valueType) {
        T r = null;
        Gson gson = new Gson();
        try {
            r = gson.fromJson(value, valueType);
        } catch (Exception e) {
            e.printStackTrace();
        }
        return r;
    }
    public static <T> T gsonDeserialize(String value, Class<T> valueType) {
        T r = null;
        Gson gson = new Gson();
        try {
            r = gson.fromJson(value, valueType);
        } catch (Exception e) {
            e.printStackTrace();
        }
        return r;
    }
}
