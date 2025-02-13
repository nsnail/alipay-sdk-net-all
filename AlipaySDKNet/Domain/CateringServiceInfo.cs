using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CateringServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CateringServiceInfo : AopObject
    {
        /// <summary>
        /// 服务子类型（ServiceSubType枚举） 自提:PICK_UP 外卖:TAKE_AWAY 排队:QUEUE
        /// </summary>
        [XmlElement("service_sub_type")]
        public string ServiceSubType { get; set; }

        /// <summary>
        /// 门店地址（格式：市/区/详细地址门牌号）
        /// </summary>
        [XmlElement("store_address")]
        public string StoreAddress { get; set; }

        /// <summary>
        /// 商家门店id（ISV内部门店唯一编号）
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 门店名称，比如：蚂蚁金服店
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }
    }
}
