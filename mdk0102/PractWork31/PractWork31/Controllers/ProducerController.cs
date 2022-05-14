using PractWork31.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace PractWork31.Controllers
{
    public class ProducerController : ApiController
    {
        MarketEntities db = new MarketEntities();

        public IHttpActionResult GetProducers()
        {
            try
            {
                return Ok(db.Producers.ToList());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        public IHttpActionResult GetProducer(int id)
        {
            try
            {
                var producer = db.Producers.Find(id);
                if (producer != null)
                {
                    return Ok(producer);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [ResponseType(typeof(Producer))]
        public IHttpActionResult PostProducer(Producer producer)
        {
            try
            {
                if (db.Producers.Any(x=> x.Name == producer.Name))
                {
                    ModelState.AddModelError("Name", "Название производителя не может повторяться");
                }
                if (String.IsNullOrWhiteSpace(producer.Name))
                {
                    ModelState.AddModelError("Name","Название производителя не может быть пустым");
                }
                if (String.IsNullOrWhiteSpace(producer.Country))
                {
                    ModelState.AddModelError("Country", "Страна производителя не может быть пустой строкой");
                }
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = db.Producers.Add(producer);
                db.SaveChanges();
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [ResponseType(typeof(Producer))]
        public IHttpActionResult PutProducer(int id, Producer producer)
        {
            try
            {
                if (id != producer.IdProducer)
                {
                    return BadRequest();
                }

                if (db.Producers.Any(x => x.Name == producer.Name && x.IdProducer != id))
                {
                    ModelState.AddModelError("Name", "Название производителя не может повторяться");
                }
                if (String.IsNullOrWhiteSpace(producer.Name))
                {
                    ModelState.AddModelError("Name", "Название производителя не может быть пустым");
                }
                if (String.IsNullOrWhiteSpace(producer.Country))
                {
                    ModelState.AddModelError("Country", "Страна производителя не может быть пустой строкой");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                db.Entry(producer).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!db.Products.Any(e => e.IdProduct == id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Ok(producer);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
