using System.Web.Mvc;

namespace Project_62133508.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );

            //Map cho trang xem trước thông tin sản phẩm
            context.MapRoute(
               name: "xem truoc",
               url: "Admin/{controller}/{action}/{id}",
               defaults: new { controller = "QuanLySanPham_62133508", action = "XemTruoc", id = UrlParameter.Optional }
           );


            context.MapRoute(
                "View detail Order",
                "Admin/chi-tiet-don-hang/{id}",
                new { controller = "QuanLyDonHang_62133508", action = "ViewDetail", id = UrlParameter.Optional }
            );
            context.MapRoute(
               "cập nhật sản phẩm",
               "Admin/QuanLySanPham_62133508/CapNhat/{id}",
               new { controller = "QuanLySanPham_62133508", action = "CapNhat", id = UrlParameter.Optional }
           );
            context.MapRoute(
               "Hoan thanh sản phẩm",
               "Admin/QuanLySanPham_62133508/HoanThanhDonHang/{id}",
               new { controller = "QuanLySanPham_62133508", action = "HoanThanhDonHang", id = UrlParameter.Optional }
           );

            

        }

    }
}
