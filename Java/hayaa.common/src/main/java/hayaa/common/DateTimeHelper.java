package hayaa.common;

import java.text.SimpleDateFormat;
import java.util.Date;

public class DateTimeHelper {
   static SimpleDateFormat timeToken = new SimpleDateFormat("yyyyMMddHHmmss");
    static SimpleDateFormat dateToken = new SimpleDateFormat("yyyyMMddHHmmss");
    public static String getTimeToken(){
      return timeToken.format(new Date());
    }
    public static String getDateToken(){
        return dateToken.format(new Date());
    }
}
