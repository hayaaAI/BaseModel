using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.BaseModel
{
    /// <summary>
    /// 远程配置内容约束
    /// </summary>
    public interface ConfigContent
    {
         AppSettings AppSettings { set; get; }

         ConnectionStrings ConnectionStrings { set; get; }
    }
    [Serializable]
    public class AppSettings
    {

        public List<AppSetInfo> Settings;

        public class AppSetInfo
        {

            public string Key { set; get; }

            public string Value { set; get; }
        }
    }
    [Serializable]
    public class ConnectionStrings
    {
        public List<ConnectionInfo> Settings;

        public class ConnectionInfo
        {

            public string Name { set; get; }

            public string Connection { set; get; }
        }


    }
}
