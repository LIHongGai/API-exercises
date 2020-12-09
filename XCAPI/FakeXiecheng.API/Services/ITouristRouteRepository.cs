using FakeXiecheng.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXiecheng.API.Services
{
    /// <summary>
    /// API接口方法
    /// </summary>
    public interface ITouristRouteRepository
    {
        IEnumerable<TouristRoute> GetTouristRoutes();
        //第二个接口方法，第一个返回的是一组旅游路线，第二个返回单独的路线。
        TouristRoute GetTouristRoute(Guid touristRouteId);
    }
}
