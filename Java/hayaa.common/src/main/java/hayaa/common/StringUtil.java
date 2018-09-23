package hayaa.common;

public class StringUtil {
    public static Boolean IsNullOrEmpty(String source) {
        if (source == null) return true;
        source = source.trim();
        if (source.length() == 0) return true;
        return false;
    }
}
