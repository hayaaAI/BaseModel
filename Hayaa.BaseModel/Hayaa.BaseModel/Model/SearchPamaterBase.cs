using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Hayaa.BaseModel
{
    /// <summary>
    /// 查询参数基础类
    /// </summary>
  public abstract  class SearchPamaterMariadbBase
    {
      
      
        public String CreateWhereSql()
        {           
            Type type = this.GetType(); 
            List<PropertyInfo> listPinfo = type.GetProperties().ToList();
            List<MethodInfo> methods=type.GetMethods().ToList();
            List<String> list = new List<string>();
            listPinfo.ForEach(pi => {
                if (pi != null) { 
                String methodName = String.Format("Get{0}Sql",pi.Name);
                MethodInfo method = methods.Find(a => a.Name == methodName);
                list.Add(method.Invoke(type, null).ToString());
                }
            });
            if (list.Count > 0)
                return String.Format("where {0}", String.Join(" and ", list));
            else
                return "";
        }
       
    }
}
