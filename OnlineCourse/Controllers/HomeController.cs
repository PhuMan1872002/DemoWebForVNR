using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineCourse.Models;
namespace OnlineCourse.Controllers
{
    public class HomeController : Controller
    {
        VNR_InternShipEntities db = new VNR_InternShipEntities();
        public ActionResult Index()
        {
            List<MonHoc> monHoc = db.MonHocs.Where(s => s.KhoaHocID == 1).ToList();
            return View(monHoc);
        }
        public JsonResult GetMonHocByKhoaHocId(int khoaHocId)
        {
            List<string> monHoc = db.MonHocs
                                    .Where(m => m.KhoaHocID == khoaHocId)
                                    .Select(m => m.TenMonHoc)  // Chỉ lấy tên môn học
                                    .ToList();
            return Json(monHoc, JsonRequestBehavior.AllowGet);
        }

      
    }
}