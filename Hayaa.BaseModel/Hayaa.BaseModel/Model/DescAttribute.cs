using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.BaseModel.Model
{
    [AttributeUsage(AttributeTargets.Class| AttributeTargets.Method)]
    public sealed class DescAttribute: Attribute
    {
        public DescAttribute(String name,String title,String remark)
        {
            this.Name = name;
            this.Title = title;
            this.Remark = remark;
        }
        public String Name { private set; get; }
        public String Title { private set; get; }
        public String Remark { private set; get; }
    }
}
