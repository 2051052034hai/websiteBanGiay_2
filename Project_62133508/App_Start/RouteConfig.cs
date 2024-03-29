﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Project_62133508
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home_62133508", action = "Index", id = UrlParameter.Optional }
            );

            //Map cho trang thông tin sản phẩm
            routes.MapRoute(
               name: "thong tin san pham",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "SanPham_62133508", action = "ChiTiet", id = UrlParameter.Optional }
           );

            //Map cho trang danh mục sản phẩm
            routes.MapRoute(
               name: "Danh muc",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "DanhMuc_62133508", action = "Index", id = UrlParameter.Optional }
           );


        }
    }
}