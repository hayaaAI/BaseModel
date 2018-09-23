//package hayaa.dataaccess;
//
//import hayaa.basemodel.model.BaseData;
//import hayaa.basemodel.model.GridPager.GridPager;
//import hayaa.basemodel.model.GridPager.GridPagerPamater;
//import hayaa.basemodel.model.GridPager.PagerTotal;
//import org.apache.commons.dbcp2.BasicDataSource;
//import org.apache.commons.dbutils.QueryRunner;
//import org.apache.commons.dbutils.ResultSetHandler;
//import org.apache.commons.dbutils.handlers.BeanHandler;
//import org.apache.commons.dbutils.handlers.ScalarHandler;
//import java.sql.SQLException;
//import java.util.List;
//
//public class CommonDal {
//    private static BasicDataSource g_ds;
//
//    public CommonDal(DbUtilsConfig config) throws Exception {
//        try {
//            g_ds = new BasicDataSource();
//            g_ds.setUrl(config.getUrl());
//            g_ds.setDriverClassName(config.getDriverClass());
//            g_ds.setUsername(config.getDbUserName());
//            g_ds.setPassword(config.getDbUserPwd());
//            g_ds.setDefaultAutoCommit(config.getDefaultAutoCommit());
//            g_ds.setMaxIdle(config.getMaxIdle());
//        } catch (Exception ex) {
//            throw new Exception("CommonDal初始化失败:" + ex.getMessage());
//        }
//    }
//
//    public static <T> T insert(String sql, T data, Class<? extends T> type) {
//        QueryRunner runner = new QueryRunner(g_ds);
//        ResultSetHandler<T> rsh = new ScalarHandler<T>();
//        try {
//            data = runner.insert(sql, rsh, data);
//        } catch (SQLException e) {
//            data = null;
//            e.printStackTrace();
//        }
//        return data;
//    }
//
//    public static <T> Boolean update(String sql, T data) {
//        QueryRunner runner = new QueryRunner(g_ds);
//        Boolean result = false;
//        try {
//            result = runner.update(sql, data) > 0;
//        } catch (SQLException e) {
//            e.printStackTrace();
//        }
//        return result;
//    }
//
//    public static int excute(String sql, Object parama) {
//        QueryRunner runner = new QueryRunner(g_ds);
//        int result = 0;
//        try {
//            result = runner.execute(sql, parama);
//        } catch (SQLException e) {
//            e.printStackTrace();
//        }
//        return result;
//    }
//
//    public static <T> List<T> getList(String sql, Object parama, Class<? extends T> type) {
//        QueryRunner runner = new QueryRunner(g_ds);
//        List<T> result = null;
//        ResultSetHandler<T> rsh =new BeanHandler<T>(type);
//        try {
//            result = runner.execute(sql, rsh, parama);
//        } catch (SQLException e) {
//            e.printStackTrace();
//        }
//        return result;
//    }
//
//    public static <T> T get(String sql, Object parama, Class<? extends T> type) {
//        QueryRunner runner = new QueryRunner(g_ds);
//        T result = null;
//        ResultSetHandler<T> rsh = new BeanHandler<T>(type);
//        try {
//            result = runner.query(sql, rsh, parama);
//        } catch (SQLException e) {
//            e.printStackTrace();
//        }
//        return result;
//    }
//
//    /**
//     * 获取分页数据
//     * @param sql 形式:out total int;select SQL_CALC_FOUND_ROWS * from table limit ?,?;select total=FOUND_ROWS();
//     * @param pageSize
//     * @param pageIndex
//     * @param parama 必须和sql语句的占位符号一致
//     * @param type
//     * @param <T>
//     * @param <P>必须有一个名字为total的属性
//     * @return
//     */
//    public static <T extends BaseData,P extends PagerTotal> GridPager<T> getGridPager(String sql, int pageSize,
//                                                                                                                    int pageIndex,
//                                                                                                                    GridPagerPamater<P> parama,
//                                                                                                                    Class<? extends T> type) {
//        GridPager<T> result= new GridPager<>(pageIndex, pageSize);
//        ResultSetHandler<T> rsh =new BeanHandler<>(type);
//        QueryRunner runner = new QueryRunner(g_ds);
//        try {
//            List<T> list= runner.execute(sql, rsh, parama.getSearchPamater());
//            result.setTotal(parama.getSearchPamater().getTotal());
//            result.setCurrentIndex(pageIndex);
//            result.setPageSize(pageSize);
//        } catch (SQLException e) {
//            e.printStackTrace();
//        }
//        return result;
//    }
//}
