using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.DAO;
using Project_62133508.Common;

namespace Project_62133508.Controllers
{
    public class TimKiem_62133508Controller : Controller
    {
        //
        // GET: /TimKiem_62133508/

        public ActionResult Index(string keyword, int page=1, int pagesize=6)
        {
            ViewBag.vbtk = keyword;
            var model = new TimKiemDAO().timkiem(keyword, page, pagesize);
            return View(model);
        }

    }
}
