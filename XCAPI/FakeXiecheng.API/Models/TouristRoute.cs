using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FakeXiecheng.API.Models
{
    /// <summary>
    /// 旅游路线类
    /// </summary>
    public class TouristRoute
    {
        [Key]
        public Guid Id { get; set; }  //编号
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }  //路线名称
        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }  //简介
        [Column(TypeName = "decimal(18, 2)")]
        public decimal OriginalPrice { get; set; }  //价格（原价）
        [Range(0.0, 1.0)]
        //注：在double后面加？是表明变量为空，数据初始输入的时候可有可无。
        public double? DiscountPresent { get; set; }  //折扣   
        public DateTime CreateTime { get; set; }  //发布时间
        public DateTime? UpdateTime { get; set; }  //更新时间
        public DateTime? DepartureTime { get; set; }   //出发时间
        [MaxLength] 
        public string Features { get; set; }  //卖点介绍
        [MaxLength]
        public string Fees { get; set; }  //费用说明
        [MaxLength]
        public string Notes { get; set; }  //票据
        public ICollection<TouristRoutePicture> TouristRoutePictures { get; set; }   //外键关系
            = new List<TouristRoutePicture>();
        public double? Rating { get; set; }  //评分
        public TravelDays? TravelDays { get; set; }  //旅游天数
        public TripType? TripType { get; set; }  //旅游团
        public DepartureCity? DepartureCity { get; set; }  //出发地
    }
}
