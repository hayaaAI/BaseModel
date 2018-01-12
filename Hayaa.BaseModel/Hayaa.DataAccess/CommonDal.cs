using MySql.Data.MySqlClient;
using System;
using System.Data;
using Dapper;
using System.Collections.Generic;
using Hayaa.BaseModel;

namespace Hayaa.DataAccess
{
    public class CommonDal
    {
        internal static int Update<T>(String conectionString,string sql, T data)
        {
            IDbConnection conn = new MySqlConnection(conectionString);
            return conn.Execute(sql, data);
        }
        internal static int Excute(String conectionString,string sql, object parama = null)
        {
            IDbConnection conn = new MySqlConnection(conectionString);
            return conn.Execute(sql, parama);
        }
        internal static List<T> GetList<T>(String conectionString,string sql, object parama)
        {
            IDbConnection conn = new MySqlConnection(conectionString);
            return conn.Query<T>(sql, parama).AsList<T>();
        }
        internal static T Get<T>(String conectionString,string sql, object parama)
        {
            IDbConnection conn = new MySqlConnection(conectionString);
            return conn.QuerySingle<T>(sql, parama);
        }
        internal static GridPager<T> GetGridPager<T>(String conectionString,string sql, int pageSize, int pageIndex, object parama) where T: BaseData
        {
            GridPager<T> r = new GridPager<T>() { CurrentIndex = pageIndex, PageSize = pageSize, ActionResult = false };
            IDbConnection conn = new MySqlConnection(conectionString);
            var multi = conn.QueryMultiple(sql, parama);
            if (!multi.IsConsumed)
            {
                r.Data = multi.Read<T>().AsList<T>();
                r.Total = multi.ReadSingle();              
            }
            return r;
        }
    }
}
