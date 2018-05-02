using MySql.Data.MySqlClient;
using System;
using System.Data;
using Dapper;
using System.Collections.Generic;
using Hayaa.BaseModel;
using System.Text;
using System.Reflection;

namespace Hayaa.DataAccess
{
    public class CommonDal
    {
        protected static int Insert<T>(String conectionString, string sql, T data)
        {
            IDbConnection conn = new MySqlConnection(conectionString);
            return conn.Execute(sql, data);
        }
        protected static TReturnID InsertWithReturnID<T, TReturnID>(String conectionString, string sql, T data) 
        {
            IDbConnection conn = new MySqlConnection(conectionString);
            return conn.QuerySingle<TReturnID>(sql, data);
        }
        protected static int Update<T>(String conectionString, string sql, T data)
        {
            IDbConnection conn = new MySqlConnection(conectionString);
            return conn.Execute(sql, data);
        }
        protected static int Excute(String conectionString, string sql, object parama = null)
        {
            IDbConnection conn = new MySqlConnection(conectionString);
            return conn.Execute(sql, parama);
        }
        protected static List<T> GetList<T>(String conectionString, string sql, object parama)
        {
            IDbConnection conn = new MySqlConnection(conectionString);
            var list = conn.Query<T>(sql, parama);
            if (list!=null)
            {
                var result= list.AsList<T>();
                return result;
            }
            return null;
        }
        protected static T Get<T>(String conectionString, string sql, object parama)
        {
            IDbConnection conn = new MySqlConnection(conectionString);
            return conn.QuerySingleOrDefault<T>(sql, parama);
        }
        protected static GridPager<T> GetGridPager<T>(String conectionString, string sql, int pageSize, int pageIndex, object parama) where T : BaseData
        {
            GridPager<T> r = new GridPager<T>() { CurrentIndex = pageIndex, PageSize = pageSize, ActionResult = false };
            IDbConnection conn = new MySqlConnection(conectionString);
            var multi = conn.QueryMultiple(sql, parama);
            if (!multi.IsConsumed)
            {
                r.Data = multi.Read<T>().AsList<T>();
                r.Total = multi.ReadSingle<int>();
                r.ActionResult = true;
            }
            return r;
        }
      
    }
}
