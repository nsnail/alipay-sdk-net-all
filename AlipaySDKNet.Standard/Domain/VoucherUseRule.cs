using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherUseRule Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherUseRule : AopObject
    {
        /// <summary>
        /// 折扣券详情 限制: 券类型voucher_type为折扣券DISCOUNT_VOUCHER时必传
        /// </summary>
        [XmlElement("discount_voucher")]
        public DiscountVoucher DiscountVoucher { get; set; }

        /// <summary>
        /// 兑换券详情  限制: 券类型为兑换券时必传
        /// </summary>
        [XmlElement("exchange_voucher")]
        public ExchangeVoucher ExchangeVoucher { get; set; }

        /// <summary>
        /// 满减券详情  限制: 券类型为满减券时必传
        /// </summary>
        [XmlElement("fix_voucher")]
        public FixVoucher FixVoucher { get; set; }

        /// <summary>
        /// 特价券详情 限制: 券类型voucher_type为特价券SPECIAL_VOUCHER时必传
        /// </summary>
        [XmlElement("special_voucher")]
        public SpecialVoucher SpecialVoucher { get; set; }

        /// <summary>
        /// 日期区间内可以使用优惠
        /// </summary>
        [XmlElement("voucher_valid_period")]
        public VoucherValidPeriod VoucherValidPeriod { get; set; }
    }
}
