using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeAdvanceConsultResponse.
    /// </summary>
    public class AlipayTradeAdvanceConsultResponse : AopResponse
    {
        /// <summary>
        /// true 代表当前时间点，用户允许垫资 false 代表当前时间，用户不允许垫资
        /// </summary>
        [XmlElement("refer_result")]
        public bool ReferResult { get; set; }

        /// <summary>
        /// 用户被注销
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 返回用户不准入原因
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }

        /// <summary>
        /// 订单风险评估等级，在单笔订单风险预评估时返回。当基础风险校验通过时，可通过该值获取业务风险评估等级。取值：2-高风险；1-低风险。
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 用户风险预测结果，包括用户拒付风险等级、用户绑定手机号被二次放号风险等级。
        /// </summary>
        [XmlElement("user_risk_prediction")]
        public UserRiskPrediction UserRiskPrediction { get; set; }

        /// <summary>
        /// 用户剩余的总待还金额，无论当前用户是否允许垫资，都会返回改属性
        /// </summary>
        [XmlElement("wait_repayment_amount")]
        public string WaitRepaymentAmount { get; set; }

        /// <summary>
        /// 用户总的未还的垫资笔数，无论用户是否允许垫资，都会返回该属性
        /// </summary>
        [XmlElement("wait_repayment_order_count")]
        public long WaitRepaymentOrderCount { get; set; }

        /// <summary>
        /// 待还订单列表，无论用户当前状态是否允许垫资，都会返回当前用户在商户下的待还订单信息
        /// </summary>
        [XmlArray("wait_repayment_order_infos")]
        [XmlArrayItem("wait_repayment_order_info")]
        public List<WaitRepaymentOrderInfo> WaitRepaymentOrderInfos { get; set; }
    }
}
