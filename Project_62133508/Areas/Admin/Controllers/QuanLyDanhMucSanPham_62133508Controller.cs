﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DAO;
using Model.EF;
using Project_62133508.Common;
using PagedList;


namespace Project_62133508.Areas.Admin.Controllers
{
    public class QuanLyDanhMucSanPham_62133508Controller : Controller
    {
        //
        // GET: /Admin/QuanLyDanhMucSanPham_62133508/

        public ActionResult Index(string searchString, int page = 1, int pageSize = 5)
        {
            var dao = new DanhMucSanPhamDAO();
            var model = dao.ListAll(searchString, page, pageSize);
            ViewBag.searchstring = searchString;
            return View(model);
        }
        public ActionResult ChoDuyet(string searchString, int page = 1, int pageSize = 5)
        {
            var dao = new DanhMucSanPhamDAO();
            var model = dao.ChoDuyet(searchString, page, pageSize);
            ViewBag.searchstring = searchString;
            return View(model);
        }




        [HttpGet]
        public ActionResult ThemDanhMuc()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThemDanhMuc(DANHMUCSANPHAM cs)
        {
            DANHMUCSANPHAM ds = new DANHMUCSANPHAM();
            ds.IDCha = cs.IDCha;
            ds.TenDanhMuc = cs.TenDanhMuc;
            ds.Metatitle = RewriteURL.RewriteUrl(cs.TenDanhMuc);
            ds.NgayTao = DateTime.Now;
            ds.NguoiTao = UserInfo.Username;
            ds.TrangThai = 0;
            var dao = new DanhMucSanPhamDAO();
            dao.ThemDanhMuc(ds);
            return RedirectToAction("ChoDuyet");
        }
    }
}
