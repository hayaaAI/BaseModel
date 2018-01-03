using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Hayaa.Common
{
    public class AssertHelper
    {
        public static void AssertStringNullorEmpty(String target) 
        {
            if (String.IsNullOrWhiteSpace(target))
            {
                throw new Exception("字符串变量为空");
            }
        }
        public static void AssertListNullorEmpty<T>(List<T> target)
        {
            if (target==null)
            {
                throw new Exception("变量为null");
            }
            if (target.Count==0)
            {
                throw new Exception("变量无元素");
            }
        }
        public static void AssertNull<T>(T target) where T:class
        {
            if (target == null)
            {
                throw new Exception("变量为null");
            }           
        }
        public static void AssertRangInt(int target,int min,int max) 
        {
            if ((target < min) || (target > max))
            {
                throw new Exception("变量数值超出约束范围");
            }
        }
        public static void AssertRangLong(long target, long min, long max)
        {
            if ((target < min) || (target > max))
            {
                throw new Exception("变量数值超出约束范围");
            }
        }
        public static void AssertRangDecimal(decimal target, decimal min, decimal max)
        {
            if ((target < min) || (target > max))
            {
                throw new Exception("变量数值超出约束范围");
            }
        }
        public static void AssertRangDouble(double target, double min, double max)
        {
            if ((target < min) || (target > max))
            {
                throw new Exception("变量数值超出约束范围");
            }
        }
        private static readonly Regex MobileRegex = new Regex(RegexRuleHelper.Mobile, RegexOptions.Compiled);
        public static void AssertRegexMobile(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                throw new Exception("变量为空");
            }
            target = target.Trim();
            if (!MobileRegex.IsMatch(target))
            {
                throw new Exception("不符合规则的手机号码");
            }
        }
        private static readonly Regex EmailRegex = new Regex(RegexRuleHelper.Email,
           RegexOptions.Compiled);
        public static void AssertRegexEmail(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                throw new Exception("变量为空");
            }
            target = target.Trim();
            if (!EmailRegex.IsMatch(target))
            {
                throw new Exception("不符合规则的EMAIL地址");
            }
        }
        private static readonly Regex UrlRegex = new Regex(RegexRuleHelper.HttpUrl,
          RegexOptions.Compiled);
        /// <summary>
        /// 断言含有http的url地址
        /// </summary>
        /// <param name="target"></param>
        public static void AssertRegexUrl(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                throw new Exception("变量为空");
            }
            target = target.Trim();
            if (!UrlRegex.IsMatch(target))
            {
                throw new Exception("不符合规则的Url地址");
            }
        }
        private static readonly Regex IDCardRegex = new Regex(RegexRuleHelper.IDCard, RegexOptions.Compiled);
        /// <summary>
        /// 是否是国内身份证号
        /// </summary>
         /// <returns></returns>
        public static void AssertIDCard(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                throw new Exception("变量为空");
            }
            target = target.Trim();
            if (!IDCardRegex.IsMatch(target))
            {
                throw new Exception("不符合规则的国内身份证号码");
            }
        }
        private static readonly Regex EnglishRegex = new Regex(RegexRuleHelper.English, RegexOptions.Compiled);
        /// <summary>
        /// 是否英文
        /// </summary>
        /// <returns></returns>
        public static void AssertEnglish(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                throw new Exception("变量为空");
            }
            target = target.Trim();
            if (!EnglishRegex.IsMatch(target))
            {
                throw new Exception("非完全英文");
            }
        }
        private static readonly Regex ChineseRegex = new Regex(RegexRuleHelper.Chinese, RegexOptions.Compiled);
        /// <summary>
        /// 是否中文
        /// </summary>
        /// <returns></returns>
        public static void AssertChinese(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                throw new Exception("变量为空");
            }
            target = target.Trim();
            if (!ChineseRegex.IsMatch(target))
            {
                throw new Exception("不包含中文");
            }
        }
    }
}
