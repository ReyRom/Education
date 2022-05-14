using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PractWork25.Models;

namespace PractWork25.Controllers
{
    public class OrderContentsController : Controller
    {
        private MarketEntities db = new MarketEntities();

        // GET: OrderContents
        public ActionResult Index()
        {
            var orderContents = db.OrderContents.Include(o => o.Order).Include(o => o.Product);
            return View(orderContents.ToList());
        }

        // GET: OrderContents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderContent orderContent = db.OrderContents.Find(id);
            if (orderContent == null)
            {
                return HttpNotFound();
            }
            return View(orderContent);
        }

        // GET: OrderContents/Create
        public ActionResult Create()
        {
            ViewBag.IdOrder = new SelectList(db.Orders, "IdOrder", "IdOrder");
            ViewBag.IdProduct = new SelectList(db.Products, "IdProduct", "Model");
            return View();
        }

        // POST: OrderContents/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdOrder,IdProduct,Quantity")] OrderContent orderContent)
        {
            if (ModelState.IsValid)
            {
                db.OrderContents.Add(orderContent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdOrder = new SelectList(db.Orders, "IdOrder", "IdOrder", orderContent.IdOrder);
            ViewBag.IdProduct = new SelectList(db.Products, "IdProduct", "Model", orderContent.IdProduct);
            return View(orderContent);
        }

        // GET: OrderContents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderContent orderContent = db.OrderContents.Find(id);
            if (orderContent == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdOrder = new SelectList(db.Orders, "IdOrder", "IdOrder", orderContent.IdOrder);
            ViewBag.IdProduct = new SelectList(db.Products, "IdProduct", "Model", orderContent.IdProduct);
            return View(orderContent);
        }

        // POST: OrderContents/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdOrder,IdProduct,Quantity")] OrderContent orderContent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderContent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdOrder = new SelectList(db.Orders, "IdOrder", "IdOrder", orderContent.IdOrder);
            ViewBag.IdProduct = new SelectList(db.Products, "IdProduct", "Model", orderContent.IdProduct);
            return View(orderContent);
        }

        // GET: OrderContents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderContent orderContent = db.OrderContents.Find(id);
            if (orderContent == null)
            {
                return HttpNotFound();
            }
            return View(orderContent);
        }

        // POST: OrderContents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrderContent orderContent = db.OrderContents.Find(id);
            db.OrderContents.Remove(orderContent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
