package hayaa.basemodel.model;

import java.lang.reflect.Field;
import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/**
 *
 */
public abstract class SearchPamaterMariadbBase {
    public int getStart() {
        return start;
    }

    public void setStart(int start) {
        this.start = start;
    }

    public int getPageSize() {
        return pageSize;
    }

    public void setPageSize(int pageSize) {
        this.pageSize = pageSize;
    }

    private int start;
    private int pageSize;

    public String CreateWhereSql() {
        String sql = "";
        List<String> list = new ArrayList<>();
        //得到类对象
        Class cla = this.getClass();
        //得到类中的所有属性集合
        Field[] fs = cla.getDeclaredFields();
        //得到类中的方法
        Method[] methods = cla.getDeclaredMethods();
        List<Method> methodList =new ArrayList<>(Arrays.asList(methods));
        for (int i = 0; i < methodList.size(); i++) {
            if (methodList.get(i).getModifiers() != 4) {
                methodList.remove(i);
                i--;
            }
        }
        for (int i = 0; i < fs.length; i++) {
            Field f = fs[i];
            f.setAccessible(true); //设置些属性是可以访问的
            Object val = null;//得到此属性的值
            try {
                val = f.get(this);
            } catch (IllegalAccessException e) {
                e.printStackTrace();
            }
            if (val != null) {
                String methodName = "get" + f.getName() + "Sql";
                for (int j = 0; j < methodList.size(); j++) {
                    Method method = methodList.get(j);
                    if (method.getName().contains(methodName)) {
                        method.setAccessible(true);
                        try {
                            Object or = method.invoke(this);
                            list.add(or.toString());
                        } catch (IllegalAccessException e) {
                            e.printStackTrace();
                        } catch (InvocationTargetException e) {
                            e.printStackTrace();
                        }
                    }
                }
            }
        }
        if (list.size() > 0) {
            sql = "where " + String.join(",", list);
        }
        return sql;
    }
}
