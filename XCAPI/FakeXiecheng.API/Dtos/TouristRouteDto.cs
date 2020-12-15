using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXiecheng.API.Dtos
{
    /// <summary>
    /// 数据映射类
    /// </summary>
    public class TouristRouteDto
    {
        public Guid Id { get; set; }  //编号
        public string Title { get; set; }  //路线名称
        public string Description { get; set; }  //简介
        //计算方式： 原价*折扣
        public decimal Price { get; set; }

       // public decimal OriginalPrice { get; set; }   //价格（原价）

        //注：在double后面加？是表明变量为空，数据初始输入的时候可有可无。
        //public double? DiscountPresent { get; set; } //折扣   
        public DateTime CreateTime { get; set; } //发布时间
        public DateTime? UpdateTime { get; set; } //更新时间
        public DateTime? DepartureTime { get; set; } //出发时间
        public string Features { get; set; }//卖点介绍
        public string Fees { get; set; }//费用说明
        public string Notes { get; set; }  //票据

        public double? Rating { get; set; }//评分

        public string  TraveIDays { get; set; }//旅游天数

        public string  TripType { get; set; } //旅游团

        public string DepartureCity { get; set; }//出发地
    }
}
