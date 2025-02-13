using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DiscountVoucher Data Structure.
    /// </summary>
    [Serializable]
    public class DiscountVoucher : AopObject
    {
        /// <summary>
        /// 封顶金额。 限制： 币种为人民币，单位为元; 小数点以后最多保留两位;  取值范围:0.1<=x<=15000;
        /// </summary>
        [XmlElement("ceiling_amount")]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 折扣率。 限制: 取值范围：0.1<=x<=9.9，比如：6.5折填入6.5;
        /// </summary>
        [XmlElement("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// 门槛金额。 限制：  币种为人民币，单位为元； 小数点以后最多保留两位； 取值范围:0.1<=x<= 50000; 说明： 该字段可不填，认为无门槛;
        /// </summary>
        [XmlElement("floor_amount")]
        public string FloorAmount { get; set; }

        /// <summary>
        /// 商品名称。 说明： 该字段可不填，填入则origin_amount必填。
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 原价。 限制： 币种为人民币，单位为元。小数点以后最多保留两位; 取值范围:0.1<=x<=9999; 说明： 该字段可不填，填入则商品名称goods_name必填;
        /// </summary>
        [XmlElement("origin_amount")]
        public string OriginAmount { get; set; }
    }
}
