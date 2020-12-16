using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXiecheng.API.Dtos
{
    public class TouristRoutePictureDto
    {
        public int Id { get; set; }  //照片编号
        public string Url { get; set; }  //照片数据
        public Guid TouristRouteId { get; set; }  //旅游路线的外键关系
    }
}
