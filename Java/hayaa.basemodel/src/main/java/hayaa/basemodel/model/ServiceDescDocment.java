package hayaa.basemodel.model;

import java.lang.annotation.Documented;
import java.lang.annotation.Retention;
import java.lang.annotation.RetentionPolicy;

@Documented
@Retention(RetentionPolicy.RUNTIME)
public @interface ServiceDescDocment {
    String title();
    String name();
    String remark();
}
