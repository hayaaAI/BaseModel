package hayaa.common;

import java.util.Date;
import java.util.List;

public class AssertHelper {
    public static void AssertStringNullorEmpty(String target) throws Exception {
        if (StringUtil.IsNullOrEmpty(target)) {
            throw new Exception("字符串变量为空");
        }
    }

    public static <T> void AssertListNullorEmpty(List<T> target) throws Exception {
        if (target == null) {
            throw new Exception("变量为null");
        }
        if (target.size() == 0) {
            throw new Exception("变量无元素");
        }
    }

    public static <T> void AssertNull(T target) throws Exception {
        if (target == null) {
            throw new Exception("变量为null");
        }
    }

    public static void AssertRangInt(Integer target, Integer min, Integer max) throws Exception {
        if (target == null) {
            throw new Exception("变量为null");
        }
        if ((target < min) || (target > max)) {
            throw new Exception("int变量数值超出约束范围");
        }
    }

    public static void AssertRangLong(Long target, Long min, Long max) throws Exception {
        if (target == null) {
            throw new Exception("变量为null");
        }
        if ((target < min) || (target > max)) {
            throw new Exception("int变量数值超出约束范围");
        }
    }

    public static void AssertRangDouble(Double target, Double min, Double max) throws Exception {
        if (target == null) {
            throw new Exception("变量为null");
        }
        if ((target < min) || (target > max)) {
            throw new Exception("double变量数值超出约束范围");
        }
    }

    public static void AssertRangFloat(Float target, Float min, Float max) throws Exception {
        if (target == null) {
            throw new Exception("变量为null");
        }
        if ((target < min) || (target > max)) {
            throw new Exception("float变量数值超出约束范围");
        }
    }

    public static void AssertRangDateTime(Date target, Date min, Date max) throws Exception {
        if (target == null) {
            throw new Exception("变量为null");
        }
        if (target.before(min) || target.after(max)) {
            throw new Exception("DateTime变量数值超出约束范围");
        }
    }

    public static void AssertRegexMobile(String target) throws Exception {
        if (StringUtil.IsNullOrEmpty(target)) {
            throw new Exception("变量为空");
        }
        target = target.trim();
        if (!RegexRuleHelper.mobileRegex.matcher(target).find()) {
            throw new Exception("不符合规则的手机号码");
        }
    }

    public static void AssertRegexEmail(String target) throws Exception {
        if (StringUtil.IsNullOrEmpty(target)) {
            throw new Exception("变量为空");
        }
        target = target.trim();
        if (!RegexRuleHelper.emailRegex.matcher(target).find()) {
            throw new Exception("不符合规则的EMAIL地址");
        }
    }

    public static void AssertRegexUrl(String target) throws Exception {
        if (StringUtil.IsNullOrEmpty(target)) {
            throw new Exception("变量为空");
        }
        target = target.trim();
        if (!RegexRuleHelper.urlRegex.matcher(target).find()) {
            throw new Exception("不符合规则的Url地址");
        }
    }

    public static void AssertIDCard(String target) throws Exception {
        if (StringUtil.IsNullOrEmpty(target)) {
            throw new Exception("变量为空");
        }
        target = target.trim();
        if (!RegexRuleHelper.idcardRegex.matcher(target).find()) {
            throw new Exception("不符合规则的国内身份证号码");
        }
    }

    public static void AssertEnglish(String target) throws Exception {
        if (StringUtil.IsNullOrEmpty(target)) {
            throw new Exception("变量为空");
        }
        target = target.trim();
        if (!RegexRuleHelper.englishRegex.matcher(target).find()) {
            throw new Exception("非完全英文");
        }
    }
    public static void AssertChinese(String target) throws Exception {
        if (StringUtil.IsNullOrEmpty(target)) {
            throw new Exception("变量为空");
        }
        target = target.trim();
        if (!RegexRuleHelper.chineseRegex.matcher(target).find()) {
            {
                throw new Exception("不包含中文");
            }
        }
    }
}
