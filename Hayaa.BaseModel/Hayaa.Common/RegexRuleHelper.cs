using System;
using System.Collections.Generic;
using System.Text;

namespace Hayaa.Common
{
   public class RegexRuleHelper
    {
        public static readonly string Mobile = @"^((\(\d{2,3}\))|(\d{3}\-))?1[3|5|4|7|8]\d{9}$";
        public static readonly string Email = @"^[a-zA-Z0-9][_\.\-]*)+\@([A-Za-z0-9])+((\.|-|_)[A-Za-z0-9]+)*((\.[A-Za-z0-9]{2,4}){1,2}$";
        public static readonly string HttpUrl = @"^http://([w-]+.)+[w-]+(/[w-./ %&=]*)$";
        public static readonly string IDCard = @"(^[1-9]\d{5}[1-9]\d{3}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])((\d{4})|\d{3}[A-Z])$)|(^[1-9]\d{7}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}$)";
        public static readonly string English = "^[A-Za-z]+$";
        public static readonly string Chinese = "[\u4e00-\u9fa5]+";
    }
}
