using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSoiSo.Models;

namespace WebSoiSo.Controllers
{
    public class AdminController : Controller
    {
        CS3MDataContext dbml = new CS3MDataContext();

        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Kqxs()
        {
            ViewBag.ListKQXS = dbml.CS_AdminGetKQXS().ToList();
            return View();
        }
        public ActionResult TaoKQXS()
        {
            IEnumerable<SelectListItem> q = dbml.CS_Areas.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Area }).ToList();
            ViewBag.ListArea = q;
            return View();
        }

        [HttpPost]
        public ActionResult TaoKQXS(FormCollection _model, string submit)
        {
            switch (submit)
            {
                case "save":
                    string idArea = _model.Get("khuvuc");
                    ViewBag.Value = idArea;
                    string NgayXo = _model.Get("NgayXo");
                    ViewBag.NgayXo = NgayXo;
                    string DateCreated = _model.Get("DateCreated");
                    ViewBag.DateCreated = DateCreated;
                    string UserCreated = _model.Get("UserCreated");
                    ViewBag.UserCreated = UserCreated;
                    CS_KQX kqxs = new CS_KQX();
                    kqxs.IdArea = Int32.Parse(idArea);
                    if (NgayXo != "")
                        kqxs.NgayXo = DateTime.Parse(NgayXo);
                    else
                        break;
                    if (DateCreated != "")
                        kqxs.DateCreated = DateTime.Parse(DateCreated);
                    else
                        break;
                    if (UserCreated != "")
                        kqxs.UserCreated = UserCreated;
                    else
                        break;
                    dbml.CS_KQXes.InsertOnSubmit(kqxs);
                    dbml.SubmitChanges();
                    break;
                case "cancel":
                    //return RedirectToAction("Kqxs");
                    break;
            }

            return RedirectToAction("Kqxs");
        }

        public ActionResult CapNhatKQXS(int id, string name )
        {
            int _id = id;

            if (name == "capnhat")
            {
                List<CS_AdminGetChiTietKQXSResult> cs = dbml.CS_AdminGetChiTietKQXS(_id).ToList();
                ViewBag.list = cs;
            }
            return View();
        }

        [HttpPost]
        public ActionResult CapNhatKQXS(FormCollection _model, string submit, int id)
        {
            int _id = id;
            switch (submit)
            {
                case "save":
                    var d = _model.Get("GiaiNhi");
                    Dictionary<string, string[]> dict = new Dictionary<string, string[]>();
                    dict.Add("DB",  _model.Get("GiaiDB").ToString().Split(','));
                    dict.Add("G1", _model.Get("GiaiNhat").ToString().Split(','));
                    dict.Add("G2", _model.Get("GiaiNhi").ToString().Split(','));
                    dict.Add("G3", _model.Get("GiaiBa").ToString().Split(','));
                    dict.Add("G4",_model.Get("GiaiTu").ToString().Split(','));
                    dict.Add("G5", _model.Get("GiaiNam").ToString().Split(','));
                    dict.Add("G6", _model.Get("GiaiSau").ToString().Split(','));
                    dict.Add("G7", _model.Get("GiaiBay").ToString().Split(','));
                    CS_KQXS_ChiTiet cs = null;
                    foreach (var item in dict)
                    {
                        foreach (var item1 in item.Value)
                        {
                            cs = new CS_KQXS_ChiTiet();
                            cs.IdKQXS = _id;
                            cs.TenGiai = item.Key.ToString();
                            cs.So = item1;
                            dbml.CS_KQXS_ChiTiets.InsertOnSubmit(cs);
                            dbml.SubmitChanges();
                        }
                    }
                    
                    break;
                case "cancel":
                    
                    break;
            }
            return RedirectToAction("Kqxs");
        }


    }
}
