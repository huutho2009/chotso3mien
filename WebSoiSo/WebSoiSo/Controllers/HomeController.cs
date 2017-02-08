﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSoiSo.Models;
namespace WebSoiSo.Controllers
{
    public class HomeController : Controller
    {
        CS3MDataContext db = new CS3MDataContext();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var list=db.CS_GetKQXS("MB", DateTime.Parse("2017-02-07 00:00")).ToList();
            ViewBag.SoLan = list.Count / 26;
            ViewBag.ListSo = db.CS_GetSoXuatHien("MB", DateTime.Parse("2017-02-07 00:00")).ToList();
            return View(list);
        }
        public ActionResult Test()
        {
            return View();
        }
        public ActionResult Kqxs()
        {
            ViewBag.DauDuoi=db.CS_GetDauDuoi("MB",DateTime.Parse("2017-02-07 00:00")).FirstOrDefault();
            return View(db.CS_GetKQXS("MB",DateTime.Parse("2017-02-07 00:00")).ToList());
        }
        public ActionResult SoiSo()
        {
            return View();
        }
        public ActionResult SoMo()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangKy(string Nickname, string Number, string Password, string Confirm_password, string Email)
        {
            ViewBag.Nickname = Nickname;
            ViewBag.Number = Number;
            ViewBag.Password = @Password;
            ViewBag.Confirm_Password = @Confirm_password;
            ViewBag.Email = @Email;
            return View();
        }
		[HttpPost]
        public ActionResult DangKy(FormCollection frm)
        {
            var Number = frm["number"].ToString();
            var Nickname = frm["nickname"].ToString();
            var Password = frm["password"].ToString();
            var Confirm_password = frm["confirm_password"].ToString();
            var Email = frm["email"].ToString();
            var rs=db.CS_DangKyTaiKhoan(Nickname,Number, Password, Email).FirstOrDefault().Result;
            if (rs==1)
            {
                return RedirectToAction("DangKySusscess", new { NickName = @Nickname });
            }

            else
            {
                return RedirectToAction("DangKy", new { NickName = @Nickname, Number, Password, Confirm_password, Email });
            }
            
        }
        public ActionResult DangNhap(string Nickname)
        {
            ViewBag.Nickname = Nickname;
            if (Nickname!=null)
                ViewBag.Error = "Tên đăng nhập hoặc mật khẩu không chính xác";
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection frm)
        {
            var Nickname = frm["nickname"].ToString();
            var Password = frm["password"].ToString();
            var rs = db.CS_DangNhap(Nickname,Password).FirstOrDefault().Result;
            if (rs == 1)
            {
                Session["NickName"]=Nickname;
                return RedirectToAction("Index");
            }

            else
            {
                return RedirectToAction("DangNhap", new { Nickname = @Nickname});
            }
            return View();
        }
        public ActionResult DangKySusscess(string NickName)
        {
            ViewBag.Nickname = NickName;
            return View();
        }
        public ActionResult DangXuat()
        {
            Session["NickName"] = null;
            return View("Index");
        }
        public ActionResult DoiMatKhau()
        {
            if (Session["NickName"] != null)
            {
                return View();
            }
            else
            {
                return View("DangNhap");
            }
        }
        [HttpPost]
        public ActionResult DoiMatKhau(FormCollection frm)
        {
            return RedirectToAction("DoiMatKhau");
        }
        public ActionResult CaNhan()
        {
            if (Session["NickName"] != null)
            {
                return View();
            }
            else
            {
                return View("DangNhap");
            }
        }
        public ActionResult TinNhiem()
        {
            return View();
        }
        public ActionResult TheoDoi()
        {
            if (Session["NickName"] != null)
            {
                return View();
            }
            else
            {
                return View("DangNhap");
            }
        }
        public ActionResult TimThanVien()
        {
            return View();
        }

        public ActionResult LichSuChotSo()
        {
            if (Session["NickName"] != null)
            {
                return View();
            }
            else
            {
                return View("DangNhap");
            }
        }
        public ActionResult Comment()
        {
            if (Session["NickName"] != null)
            {
                return View();
            }
            else
            {
                return View("DangNhap");
            }
        }
    }
}
