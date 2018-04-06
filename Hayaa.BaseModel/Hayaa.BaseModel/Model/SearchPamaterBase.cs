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

        /// <summary>
        /// 请求页
        /// </summary>
        public int Start { set; get; }
        /// <summary>
        /// 数据页尺寸
        /// </summary>
        public int PageSize { set; get; }
        public String CreateWhereSql()
        {           
            Type type = this.GetType(); 
            List<PropertyInfo> listPinfo = type.GetProperties().ToList();
            List<MethodInfo> methods=type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance).ToList();
            List<String> list = new List<string>();
            listPinfo.ForEach(pi => {
                object piVal=  pi.GetValue(this);
                if (piVal != null)
                {
                    String methodName = String.Format("Get{0}SqlForSharp", pi.Name);
                    MethodInfo method = methods.Find(a => a.Name == methodName);
                    if (method != null)
                        list.Add(method.Invoke(this, null).ToString());
                }
            });
            if (list.Count > 0)
                return String.Format("where {0}", String.Join(" and ", list));
            else
                return "";
        }
       
    }
}
