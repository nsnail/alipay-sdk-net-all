using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityVoucherModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityVoucherModifyModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。 幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。 外部接入方需保证业务单号唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券发放结束时间。  格式为：yyyy-MM-dd HH:mm:ss  限制： 1、券发放结束时间publish_end_time 与 券发放开始时间publish_start_time 间隔必须小于等于180天 2、修改发放结束时间，只能延长，不允许缩短。
        /// </summary>
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券核销规则
        /// </summary>
        [XmlElement("voucher_use_rule")]
        public PaymentVoucherUseRuleModify VoucherUseRule { get; set; }
    }
}
