﻿using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingParkinglotinfoUpdateModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingParkinglotinfoUpdateModel : AlipayObject
    {
        /// <summary>
        /// 服务商ID（2088开头的16位纯数字），由服务商提供给ISV
        /// </summary>
        [JsonPropertyName("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [JsonPropertyName("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [JsonPropertyName("contact_alipay")]
        public string ContactAlipay { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [JsonPropertyName("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [JsonPropertyName("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [JsonPropertyName("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [JsonPropertyName("contact_tel")]
        public string ContactTel { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [JsonPropertyName("contact_weixin")]
        public string ContactWeixin { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [JsonPropertyName("equipment_name")]
        public string EquipmentName { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 收款方ID（2088开头的16位纯数字），由停车场收款的业主方提供给ISV，该字段暂用于机具和物料申领，更新时不影响交易接口中的收款方值。
        /// </summary>
        [JsonPropertyName("mchnt_id")]
        public string MchntId { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [JsonPropertyName("out_parking_id")]
        public string OutParkingId { get; set; }

        /// <summary>
        /// 停车场地址
        /// </summary>
        [JsonPropertyName("parking_address")]
        public string ParkingAddress { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [JsonPropertyName("parking_end_time")]
        public string ParkingEndTime { get; set; }

        /// <summary>
        /// 收费说明
        /// </summary>
        [JsonPropertyName("parking_fee_description")]
        public string ParkingFeeDescription { get; set; }

        /// <summary>
        /// 支付宝返回停车场id，系统唯一
        /// </summary>
        [JsonPropertyName("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 停车场类型，1为居民小区、2为商圈停车场（购物中心商业广场商场等）、3为路侧停车、4为公园景点（景点乐园公园老街古镇等）、5为商务楼宇（酒店写字楼商务楼园区等）、6为其他、7为交通枢纽（机场火车站汽车站码头港口等）、8为市政设施（体育场博物图书馆医院学校等）
        /// </summary>
        [JsonPropertyName("parking_lot_type")]
        public string ParkingLotType { get; set; }

        /// <summary>
        /// 停车场客服电话
        /// </summary>
        [JsonPropertyName("parking_mobile")]
        public string ParkingMobile { get; set; }

        /// <summary>
        /// 停车场名称，由ISV定义，尽量与高德地图上的一致
        /// </summary>
        [JsonPropertyName("parking_name")]
        public string ParkingName { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [JsonPropertyName("parking_number")]
        public string ParkingNumber { get; set; }

        /// <summary>
        /// 高德地图唯一标识
        /// </summary>
        [JsonPropertyName("parking_poiid")]
        public string ParkingPoiid { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [JsonPropertyName("parking_start_time")]
        public string ParkingStartTime { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [JsonPropertyName("parking_type")]
        public string ParkingType { get; set; }

        /// <summary>
        /// 支付方式（1为支付宝在线缴费，2为支付宝代扣缴费，3当面付)，如支持多种方式以','进行间隔
        /// </summary>
        [JsonPropertyName("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [JsonPropertyName("payment_mode")]
        public string PaymentMode { get; set; }

        /// <summary>
        /// 商圈id
        /// </summary>
        [JsonPropertyName("shopingmall_id")]
        public string ShopingmallId { get; set; }

        /// <summary>
        /// 用户支付未离场的超时时间(以分钟为单位)
        /// </summary>
        [JsonPropertyName("time_out")]
        public string TimeOut { get; set; }
    }
}
