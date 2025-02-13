using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankPaymentTradeSubaccountCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeSubaccountCreateModel : AopObject
    {
        /// <summary>
        /// 账户名称，不传默认使用母户名称
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 币种，默认(CNY)
        /// </summary>
        [XmlElement("currency_value")]
        public string CurrencyValue { get; set; }

        /// <summary>
        /// 外部渠道ID，业务幂等字段 支付宝场景传入支付宝2088 天猫和集团场景传入memberId
        /// </summary>
        [XmlElement("out_channel_id")]
        public string OutChannelId { get; set; }

        /// <summary>
        /// 外部渠道类型 支付宝：ALIPW3CN  天猫：TMALL 淘宝：TAOBAO
        /// </summary>
        [XmlElement("out_channel_type")]
        public string OutChannelType { get; set; }

        /// <summary>
        /// 母户账户类型，例如SETTLE_ACCOUNT(结算账户)
        /// </summary>
        [XmlElement("parent_account_type")]
        public string ParentAccountType { get; set; }

        /// <summary>
        /// 母户卡号，一般为结算户/二类户卡号
        /// </summary>
        [XmlElement("parent_card_no")]
        public string ParentCardNo { get; set; }

        /// <summary>
        /// 请求流水号，表示外部一次请求，幂等字段
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 场景码，网商银行提供
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
