using PractWork28.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace PractWork28.Controllers
{
    public class ProductsController : ApiController
    {
        private MarketEntities db = new MarketEntities();

        // GET: api/Products
        public IQueryable<Product> GetProducts()
        {
            return db.Products;
        }

        // GET: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProduct(int id)
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [Route("api/ProductsByPrice")]
        public IHttpActionResult GetProductsByPrice()
        {
            try
            {
                var data = db.Products.Select(x => new { x.IdProduct, x.Model, x.Producer.Name, x.Price, x.Type, x.Weight, x.Year }).OrderBy(x => x.Price).ToList();
                return Ok(data);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Route("api/ProductsByProperties")]
        public IHttpActionResult GetProductsByProperties(string type = null, string producer = null)
        {
            try
            {
                var data = db.Products.Select(x => new { x.IdProduct, x.Model, x.Producer.Name, x.Price, x.Type, x.Weight, x.Year }).ToList();
                if (!String.IsNullOrWhiteSpace(type))
                {
                    data = data.Where(x => x.Type.ToLower() == type.ToLower()).ToList();
                }
                if (!String.IsNullOrWhiteSpace(producer))
                {
                    data = data.Where(x => x.Name.ToLower() == producer.ToLower()).ToList();
                }
                return Ok(data);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // PUT: api/Products/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProduct(int id, Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product.IdProduct)
            {
                return BadRequest();
            }

            db.Entry(product).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(product);
        }

        // POST: api/Products
        [ResponseType(typeof(Product))]
        public IHttpActionResult PostProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Products.Add(product);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = product.IdProduct }, product);
        }

        // DELETE: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult DeleteProduct(int id)
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            db.Products.Remove(product);
            db.SaveChanges();

            return Ok(product);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductExists(int id)
        {
            return db.Products.Count(e => e.IdProduct == id) > 0;
        }
    }
}