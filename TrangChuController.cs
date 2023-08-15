using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuDung_DropDownList.Controllers
{
    // muốn có DropDownList
    // thì cái DropDownList được tạo ra từ danh sách
    // cái danh sách đấy lại là thuộc tính của lớp
    public class DanhSach_ThaXuong
    {
        // tạo thuộc tính có kiểu danh sách
        // cái lớp SelectListItem có thuộc tính "string Text" và "string Value"
        public List<SelectListItem> danh_sach { get; set; }


        // hàm khởi tạo không tham số
        public DanhSach_ThaXuong()
        {
            danh_sach = new List<SelectListItem>();
        }
    }

    public class TrangChuController : Controller
    {
        // GET: TrangChu
        public ActionResult Index()
        {
            // tạo ViewBag thông báo
            ViewBag.thong_bao = $"Đây là trang chủ";

            // tạo đối tượng
            // có kiểu danh sách thả xuống
            DanhSach_ThaXuong dt = new DanhSach_ThaXuong();
            
            // thêm dữ liệu
            dt.danh_sach.Add(new SelectListItem { Text = "Chọn màu đỏ", Value = "1" });
            dt.danh_sach.Add(new SelectListItem { Text = "Chọn màu xanh lá", Value = "2" });
            dt.danh_sach.Add(new SelectListItem { Text = "Chọn màu xanh dương", Value = "3" });

            return View(dt);
        }
    }
}