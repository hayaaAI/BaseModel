package hayaa.common;

import jdk.nashorn.internal.runtime.regexp.joni.Regex;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class RegexRuleHelper {
    public static final String Mobile ="^((17[0-9])|(14[0-9])|(13[0-9])|(15[^4,\\D])|(18[0,5-9]))\\d{8}$";
    public static final String Email =  "^([a-z0-9A-Z]+[-|\\.]?)+[a-z0-9A-Z]@([a-z0-9A-Z]+(-[a-z0-9A-Z]+)?\\.)+[a-zA-Z]{2,}$";
    public static final String HttpUrl = "http(s)?://([\\w-]+\\.)+[\\w-]+(/[\\w- ./?%&=]*)?";
    public static final String IDCard = "(^\\d{18}$)|(^\\d{15}$)";
    public static final String English = "^[A-Za-z]+$";
    public static final String Chinese =  "^[\u4e00-\u9fa5],{0,}$";
    public static final String IPV4 = "(25[0-5]|2[0-4]\\d|[0-1]\\d{2}|[1-9]?\\d)";
    public static final Pattern  mobileRegex=Pattern.compile(Mobile);
    public static final Pattern  emailRegex=Pattern.compile(Email);
    public static final Pattern  urlRegex=Pattern.compile(HttpUrl);
    public static final Pattern  idcardRegex=Pattern.compile(IDCard);
    public static final Pattern  englishRegex=Pattern.compile(English);
    public static final Pattern  chineseRegex=Pattern.compile(Chinese);
    public static final Pattern ipv4Regex=Pattern.compile(IPV4);
}
