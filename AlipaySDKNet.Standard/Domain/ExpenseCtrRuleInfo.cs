using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExpenseCtrRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExpenseCtrRuleInfo : AopObject
    {
        /// <summary>
        /// 规则类型（QUOTA_TOTAL("QUOTA_TOTAL","有效期总额度"), QUOTA_DAY("QUOTA_DAY","日额度"), QUOTA_MONTH("QUOTA_MONTH","月额度"), QUOTA_ONCE("QUOTA_ONCE","单笔额度");）
        /// </summary>
        [XmlElement("rule_factor")]
        public string RuleFactor { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [XmlElement("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// 费控规则操作符  LT("<","小于") LE("<=","小于等于") EQ("=","等于") NE("!=","不等于") GE(">=","大于等于") GT(">","大于")
        /// </summary>
        [XmlElement("rule_operator")]
        public string RuleOperator { get; set; }

        /// <summary>
        /// 规则值
        /// </summary>
        [XmlElement("rule_value")]
        public string RuleValue { get; set; }
    }
}
