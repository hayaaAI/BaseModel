namespace Hayaa.BaseModel
{
    /// <summary>
    /// 参数操作类型
    /// </summary>
    public enum PamaterOperationType
    {
        Equal,//等于
        GreaterThan,//大于
        LessThan,//小于
        GreaterEqual,//大于等于
        LessEqual,//小于等于
        In,
        Between,//数值范围内
        StringContains,//字符串匹配
        StringIn,//字符串in操作
    }
}