using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Hayaa.Common
{
    public class CheckHelper
    {
        public static bool IsStringNullorEmpty(String target) 
        {
            if (String.IsNullOrWhiteSpace(target))
            {
                return true;
            }
            return false;
        }
        public static bool IsListNullorEmpty<T>(List<T> target)
        {
            if (target==null)
            {
                return true;
            }
            if (target.Count==0)
            {
                return true;
            }
            return false;
        }
        public static bool IsNull<T>(T target) where T:class
        {
            if (target == null)
            {
                return true;
            }
            return false;
        }
        public static bool IsRangByte(byte target, byte min, byte max)
        {
            if ((target < min) || (target > max))
            {
                return false;
            }
            return true;
        }
        public static bool IsRangInt(int target,int min,int max) 
        {
            if ((target < min) || (target > max))
            {
                return false;
            }
            return true;
        }
        public static bool IsRangLong(long target, long min, long max)
        {
            if ((target < min) || (target > max))
            {
                return false;
            }
            return true;
        }
        public static bool IsRangDecimal(decimal target, decimal min, decimal max)
        {
            if ((target < min) || (target > max))
            {
                return false;
            }
            return true;
        }
        public static bool IsRangDouble(double target, double min, double max)
        {
            if ((target < min) || (target > max))
            {
                return false;
            }
            return true;
        }
        public static bool IsRangFloat(float target, float min, float max)
        {
            if ((target < min) || (target > max))
            {
                return false;
            }
            return true;
        }
        public static bool IsRangDateTime(DateTime target, DateTime min, DateTime max)
        {
            if ((target < min) || (target > max))
            {
                return false;
            }
            return true;
        }
        private static readonly Regex MobileRegex = new Regex(RegexRuleHelper.Mobile, RegexOptions.Compiled);
        public static bool IsRegexMobile(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                return false;
            }
            target = target.Trim();
            return MobileRegex.IsMatch(target);
        }
        private static readonly Regex EmailRegex = new Regex(RegexRuleHelper.Email,
            RegexOptions.Compiled);
        public static bool IsRegexEmail(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                return false;
            }
            target = target.Trim();
            return EmailRegex.IsMatch(target);
        }
        private static readonly Regex UrlRegex = new Regex(RegexRuleHelper.HttpUrl,
          RegexOptions.Compiled);
        /// <summary>
        /// 断言含有http的url地址
        /// </summary>
        /// <param name="target"></param>
        public static bool IsRegexUrl(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                return false;
            }
            target = target.Trim();
            
            return UrlRegex.IsMatch(target);
        }
        private static readonly Regex IDCardRegex = new Regex(RegexRuleHelper.IDCard, RegexOptions.Compiled);
        /// <summary>
        /// 是否是国内身份证号
        /// </summary>
         /// <returns></returns>
        public static bool IsIDCard(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                return false;
            }
            target = target.Trim();
            
            return IDCardRegex.IsMatch(target);
        }
        private static readonly Regex EnglishRegex = new Regex(RegexRuleHelper.English, RegexOptions.Compiled);
        /// <summary>
        /// 是否英文
        /// </summary>
        /// <returns></returns>
        public static bool IsEnglish(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                return false;
            }
            target = target.Trim();            
            return EnglishRegex.IsMatch(target);
        }
        private static readonly Regex ChineseRegex = new Regex(RegexRuleHelper.Chinese, RegexOptions.Compiled);
        /// <summary>
        /// 是否中文
        /// </summary>
        /// <returns></returns>
        public static bool IsChinese(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                return false;
            }
            target = target.Trim();            
            return ChineseRegex.IsMatch(target);
        }
        public static bool IsRegex(string target, String regexRule)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                return false;
            }
            target = target.Trim();
            Regex regex = new Regex(regexRule, RegexOptions.Compiled);            
            return regex.IsMatch(target);
        }
    }
}
