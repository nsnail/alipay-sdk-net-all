using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityOrdervoucherCreateModel : AopObject
    {
        /// <summary>
        /// 活动名称。  不对用户进行展示，仅供商家在后台管理活动使用。
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 商家券活动归属的商户信息。  说明： 如果该复杂对象不填。则默认为该商家券活动的归属者是调用者本人。 如果填写，则认为该商家券活动的归属者是该商户。  限制:服务商身份接入时必传
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public BelongMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 商家券业务标签，影响商家券对C端用户的展示形式。  枚举值 兑换券团购场景 GROUP_BUY_EXCHANGE_VOUCHER 兑换券代金场景 FIX_EXCHANGE_VOUCHER
        /// </summary>
        [XmlElement("biz_tag")]
        public string BizTag { get; set; }

        /// <summary>
        /// 码模式。  枚举值： MERCHANT_UPLOAD：商户上传自定义code，发券时系统随机选取上传的券code发放
        /// </summary>
        [XmlElement("code_mode")]
        public string CodeMode { get; set; }

        /// <summary>
        /// 自定义入口
        /// </summary>
        [XmlElement("customer_guide")]
        public CustomerGuide CustomerGuide { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。  幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。  外部接入方需保证业务单号唯一。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券发放结束时间。    格式为：yyyy-MM-dd HH:mm:ss    限制：  券发放结束时间  publish_end_time 与 券发放开始时间  publish_start_time 间隔必须小于等于180天
        /// </summary>
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券发放开始时间。  格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("publish_start_time")]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// 券展示信息
        /// </summary>
        [XmlElement("voucher_display_info")]
        public VoucherDisplayInfo VoucherDisplayInfo { get; set; }

        /// <summary>
        /// 券发放规则
        /// </summary>
        [XmlElement("voucher_send_rule")]
        public VoucherSendRuleDetail VoucherSendRule { get; set; }

        /// <summary>
        /// 券类型。  枚举值： FIX_VOUCHER：满减券； DISCOUNT_VOUCHER：折扣券； SPECIAL_VOUCHER：特价券； EXCHANGE_VOUCHER: 兑换券；
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 券核销规则
        /// </summary>
        [XmlElement("voucher_use_rule")]
        public VoucherUseRule VoucherUseRule { get; set; }
    }
}
