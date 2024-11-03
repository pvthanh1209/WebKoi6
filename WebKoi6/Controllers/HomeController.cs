﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebKoi6.BLL;
using WebKoi6.BLL.InterfaceBLL;
using WebKoi6.DAL;
using WebKoi6.DAL.Interface;
using WebKoi6.DAL.Models;
using WebKoi6.Models;
using WebKoi6.Web.Models;

namespace WebKoi6.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBaseBLL _baseBLL;
        public HomeController(IBaseBLL baseBLL)
        {
            _baseBLL = baseBLL;
        }
        [HttpGet]
        public IActionResult Index()
        {
            HomeModel model = new HomeModel();
            ViewDefault();
            model.ObjTrungTam = _baseBLL.trungtamBLL.GetObjTrungTam();
            model.ListBacSi = _baseBLL.bacsiBLLRepo.GetAll();
            model.ListTintuc = _baseBLL.tintucBLL.GetAll().OrderByDescending(x => x.MaTinTuc).Skip(0).Take(3).ToList();
            return View(model);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public void ViewDefault()
        {
            ViewBag.ListDichVu = _baseBLL.dichvuthuyBLL.GetAll();
            ViewBag.ListBacsi = _baseBLL.bacsiBLLRepo.GetAll();
        }
        [HttpPost]
        public IActionResult Index(DatlichModel model)
        {
            ViewDefault();
            try
            {
                if (!ModelState.IsValid)
                {
                    var error = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).FirstOrDefault();
                    if (error != null)
                    {
                        ViewBag.Error = error;
                        return View(model);
                    }
                    else
                    {
                        ViewBag.Error = "Vui lòng nhập đầy đủ thông tin";
                        return View(model);
                    }
                }
                int khachhangId = 0;
                var ckKhachhang = _baseBLL.khachhangBLL.GetAll().Where(x => x.SoDienThoai.Trim().Equals(model.Sodienthoai.Trim()) || x.Email.ToLower().Trim().Equals(model.Email.ToLower().Trim())).FirstOrDefault();
                if (ckKhachhang != null)
                {
                    khachhangId = ckKhachhang.Id;
                }
                else
                {
                    var objKhachHang = new Khachhang
                    {
                        Id = 0,
                        TenKhachHang = model.TenKhachHang,
                        Email = model.Email,
                        SoDienThoai = model.Sodienthoai,
                    };
                    bool flagKh = _baseBLL.khachhangBLL.Insert(objKhachHang);
                    if (!flagKh)
                    {
                        ViewBag.Error = "Đặt lịch hẹn không thành công";
                        return View(model);
                    }
                    khachhangId = objKhachHang.Id;
                }
                var objLichHen = new Lichhen
                {
                    Id = 0,
                    KhachhangId = khachhangId,
                    BacsiId = model.BacsiId,
                    Ngayhen = model.NgayDatLich,
                    Trangthai = 0,
                };
                bool flagLichHen = _baseBLL.lichhenBLL.Insert(objLichHen);
                if (!flagLichHen)
                {
                    ViewBag.Error = "Đặt lịch hẹn không thành công. Vui lòng thử lại hoặc gọi đến số hotline";
                    return View(model);
                }
                ViewBag.Success = "Đặt lich hẹn thành công";
                return View(model);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(model);
            }
        }
    }
}
