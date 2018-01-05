using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Hayaa.Common
{
    public class CheckHelper
    {
        public static bool AssertStringNullorEmpty(String target) 
        {
            if (String.IsNullOrWhiteSpace(target))
            {
                return false;
            }
            return true;
        }
        public static bool AssertListNullorEmpty<T>(List<T> target)
        {
            if (target==null)
            {
                return false;
            }
            if (target.Count==0)
            {
                return false;
            }
            return true;
        }
        public static bool AssertNull<T>(T target) where T:class
        {
            if (target == null)
            {
                return false;
            }
            return true;
        }
        public static bool AssertRangByte(byte target, byte min, byte max)
        {
            if ((target < min) || (target > max))
            {
                return false;
            }
            return true;
        }
        public static bool AssertRangInt(int target,int min,int max) 
        {
            if ((target < min) || (target > max))
            {
                return false;
            }
            return true;
        }
        public static bool AssertRangLong(long target, long min, long max)
        {
            if ((target < min) || (target > max))
            {
                return false;
            }
            return true;
        }
        public static bool AssertRangDecimal(decimal target, decimal min, decimal max)
        {
            if ((target < min) || (target > max))
            {
                return false;
            }
            return true;
        }
        public static bool AssertRangDouble(double target, double min, double max)
        {
            if ((target < min) || (target > max))
            {
                return false;
            }
            return true;
        }
        public static bool AssertRangFloat(float target, float min, float max)
        {
            if ((target < min) || (target > max))
            {
                return false;
            }
            return true;
        }
        public static bool AssertRangDateTime(DateTime target, DateTime min, DateTime max)
        {
            if ((target < min) || (target > max))
            {
                return false;
            }
            return true;
        }
        private static readonly Regex MobileRegex = new Regex(RegexRuleHelper.Mobile, RegexOptions.Compiled);
        public static bool AssertRegexMobile(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                return false;
            }
            target = target.Trim();
            if (!MobileRegex.IsMatch(target))
            {
                return false;
            }
            return true;
        }
        private static readonly Regex EmailRegex = new Regex(RegexRuleHelper.Email,
            RegexOptions.Compiled);
        public static bool AssertRegexEmail(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                return false;
            }
            target = target.Trim();
            if (!EmailRegex.IsMatch(target))
            {
                return false;
            }
            return true;
        }
        private static readonly Regex UrlRegex = new Regex(RegexRuleHelper.HttpUrl,
          RegexOptions.Compiled);
        /// <summary>
        /// 断言含有http的url地址
        /// </summary>
        /// <param name="target"></param>
        public static bool AssertRegexUrl(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                return false;
            }
            target = target.Trim();
            if (!UrlRegex.IsMatch(target))
            {
                return false;
            }
            return true;
        }
        private static readonly Regex IDCardRegex = new Regex(RegexRuleHelper.IDCard, RegexOptions.Compiled);
        /// <summary>
        /// 是否是国内身份证号
        /// </summary>
         /// <returns></returns>
        public static bool AssertIDCard(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                return false;
            }
            target = target.Trim();
            if (!IDCardRegex.IsMatch(target))
            {
                return false;
            }
            return true;
        }
        private static readonly Regex EnglishRegex = new Regex(RegexRuleHelper.English, RegexOptions.Compiled);
        /// <summary>
        /// 是否英文
        /// </summary>
        /// <returns></returns>
        public static bool AssertEnglish(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                return false;
            }
            target = target.Trim();
            if (!EnglishRegex.IsMatch(target))
            {
                return false;
            }
            return true;
        }
        private static readonly Regex ChineseRegex = new Regex(RegexRuleHelper.Chinese, RegexOptions.Compiled);
        /// <summary>
        /// 是否中文
        /// </summary>
        /// <returns></returns>
        public static bool AssertChinese(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                return false;
            }
            target = target.Trim();
            if (!ChineseRegex.IsMatch(target))
            {
                return false;
            }
            return true;
        }
        public static bool AssertRegex(string target, String regexRule)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                return false;
            }
            target = target.Trim();
            Regex regex = new Regex(regexRule, RegexOptions.Compiled);
            if (!regex.IsMatch(target))
            {
                return false;
            }
            return true;
        }
    }
}
