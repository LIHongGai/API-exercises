using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakeXiecheng.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FakeXiecheng.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristRoutesController : ControllerBase
    {
        //数据仓库接口（私有的）
        private ITouristRouteRepository _touristRouteRepository;
        //建立构造函数
        public TouristRoutesController(ITouristRouteRepository touristRouteRepository)
        {
            _touristRouteRepository = touristRouteRepository;
        }
        //在HTTP Git函数中使用数据仓库并提取全部旅游路线的信息
        [HttpGet]
        public IActionResult GerTouristRoutes()
        {
            var touristRoutesFromRepo = _touristRouteRepository.GetTouristRoutes();
            if(touristRoutesFromRepo == null || touristRoutesFromRepo.Count() <=0)
            {
                return NotFound("没有此路线");
            }
            return Ok(touristRoutesFromRepo );
        }
        //  api/touristroutes/{touristRouteId}
        [HttpGet("{touristRouteId}")]
        public IActionResult GetTouristRouteById(Guid touristRouteId)
        {
            var touristRouteFromRepo = _touristRouteRepository.GetTouristRoute(touristRouteId);
            if(touristRouteFromRepo == null)
            {
                return NotFound($"旅游路线{touristRouteId}找不到");
            }
            return Ok(touristRouteFromRepo);
        }
    }
}