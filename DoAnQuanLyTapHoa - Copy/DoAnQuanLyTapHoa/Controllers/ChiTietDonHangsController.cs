//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using DoAnQuanLyTapHoa.Models;

//namespace DoAnQuanLyTapHoa.Controllers
//{
//    public class ChiTietDonHangsController : Controller
//    {
//        private QLBANDTEntities db = new QLBANDTEntities();

//        // GET: ChiTietDonHangs
//        public ActionResult Index()
//        {
//            var chiTietDonHang = db.ChiTietDHs.Include(c => c.DonHang).Include(c => c.SanPham);
//            return View(chiTietDonHang.ToList());
//        }

//        // GET: ChiTietDonHangs/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ChiTietDH chiTietDonHang = db.ChiTietDHs.Find(id);
//            if (chiTietDonHang == null)
//            {
//                return HttpNotFound();
//            }
//            return View(chiTietDonHang);
//        }

//        // GET: ChiTietDonHangs/Create
//        public ActionResult Create()
//        {
//            ViewBag.MaDH = new SelectList(db.DonHangs, "MaDH", "MaDH");
//            ViewBag.MaSP = new SelectList(db.SanPhams, "MaSP", "TenSP");
//            return View();
//        }

//        // POST: ChiTietDonHangs/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "MaCTDH,MaSP,MaDH,DonGia,SoLuong,TongTienSP")] ChiTietDH chiTietDonHang)
//        {
//            if (ModelState.IsValid)
//            {
//                db.ChiTietDonHang.Add(chiTietDonHang);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.MaDH = new SelectList(db.DonHangs, "MaDH", "MaDH", chiTietDonHang.MaDH);
//            ViewBag.MaSP = new SelectList(db.SanPhams, "MaSP", "TenSP", chiTietDonHang.MaSP);
//            return View(chiTietDonHang);
//        }

//        // GET: ChiTietDonHangs/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ChiTietDH chiTietDonHang = db.ChiTietDHs.Find(id);
//            if (chiTietDonHang == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.MaDH = new SelectList(db.DonHangs, "MaDH", "MaDH", chiTietDonHang.MaDH);
//            ViewBag.MaSP = new SelectList(db.SanPhams, "MaSP", "TenSP", chiTietDonHang.MaSP);
//            return View(chiTietDonHang);
//        }

//        // POST: ChiTietDonHangs/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "MaCTDH,MaSP,MaDH,DonGia,SoLuong,TongTienSP")] ChiTietDH chiTietDonHang)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(chiTietDonHang).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.MaDH = new SelectList(db.DonHangs, "MaDH", "MaDH", chiTietDonHang.MaDH);
//            ViewBag.MaSP = new SelectList(db.SanPhams, "MaSP", "TenSP", chiTietDonHang.MaSP);
//            return View(chiTietDonHang);
//        }

//        // GET: ChiTietDonHangs/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ChiTietDH chiTietDonHang = db.ChiTietDHs.Find(id);
//            if (chiTietDonHang == null)
//            {
//                return HttpNotFound();
//            }
//            return View(chiTietDonHang);
//        }

//        // POST: ChiTietDonHangs/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            ChiTietDH chiTietDonHang = db.ChiTietDHs.Find(id);
//            db.ChiTietDHs.Remove(chiTietDonHang);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
