using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_62133508.Common;
using System.Web.Routing;

namespace Project_62133508.Areas.Admin.Controllers
{
    public class BaseAdmin_62133508Controller : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var ses = (UserInfoPublic)Session[CommonConstant.USER_SESSION];
            if (ses == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login_62133508", action = "Index" }));
            }
            base.OnActionExecuting(filterContext);
        }

        protected void SetAlert(string thongbao, string loai)
        {
            TempData["thongbao"] = thongbao;
            if (loai == "thanhcong")
            {
                TempData["loaithongbao"] = "alert-success";
            }
            else if (loai == "thatbai")
            { TempData["loaithongbao"] = "alert-warning"; }

            else
                if (loai == "canhbao")
                {
                    TempData["loaithongbao"] = "alert-danger";
                }
        }


    }
}
