package hayaa.dataaccess;

import hayaa.basemodel.model.MariadbConfig;
import org.apache.commons.dbcp2.BasicDataSource;
import org.apache.ibatis.mapping.Environment;
import org.apache.ibatis.session.Configuration;
import org.apache.ibatis.transaction.TransactionFactory;
import org.apache.ibatis.transaction.jdbc.JdbcTransactionFactory;



public class DbConfigInit {
    public static void initConfig(Configuration configuration, MariadbConfig mariadbConfig){
        BasicDataSource dataSource=new BasicDataSource();
        dataSource.setUrl(mariadbConfig.getUrl());
        dataSource.setDriverClassName(mariadbConfig.getDriverClass());
        dataSource.setUsername(mariadbConfig.getDbUserName());
        dataSource.setPassword(mariadbConfig.getDbUserPwd());
        dataSource.setDefaultAutoCommit(mariadbConfig.getDefaultAutoCommit());
        dataSource.setMaxIdle(mariadbConfig.getMaxIdle());
        TransactionFactory transactionFactory = new JdbcTransactionFactory();
        Environment environment = new Environment(mariadbConfig.getEnvironment(), transactionFactory, dataSource);
        configuration.setEnvironment(environment );
    }
}
