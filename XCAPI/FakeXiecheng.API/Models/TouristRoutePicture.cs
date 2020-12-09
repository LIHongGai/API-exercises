using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXiecheng.API.Models
{
    /// <summary>
    /// 旅游照片类
    /// </summary>
    public class TouristRoutePicture
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }    //照片编号
        [MaxLength(100)]
        public string Url { get; set; }  //照片数据
        [ForeignKey("TouristRouteId")]
        public Guid TouristRouteId { get; set; }  //旅游路线的外键关系
        public TouristRoute TouristRoute { get; set; }  //连接属性
    }
}
