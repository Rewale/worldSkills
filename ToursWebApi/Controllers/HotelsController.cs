﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ToursWebApi.Entities;
using ToursWebApi.Models;

namespace ToursWebApi.Controllers
{
    public class HotelsController : ApiController
    {
        private TourBaseEntities db = new TourBaseEntities();

        // GET: api/Hotels
        [ResponseType(typeof(List<ResponseHotel>))]
        public IHttpActionResult GetHotel()
        {
            return Ok(db.Hotel.ToList().ConvertAll(p =>new ResponseHotel(p)));
        }

        private object HotelResponse(Hotel input)
        {
            throw new NotImplementedException();
        }

        // GET: api/Hotels/5
        [ResponseType(typeof(Hotel))]
        public IHttpActionResult GetHotel(int id)
        {
            Hotel hotel = db.Hotel.Find(id);
            if (hotel == null)
            {
                return NotFound();
            }

            return Ok(hotel);
        }

        // PUT: api/Hotels/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHotel(int id, Hotel hotel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hotel.id)
            {
                return BadRequest();
            }

            db.Entry(hotel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Hotels
        [ResponseType(typeof(Hotel))]
        public IHttpActionResult PostHotel(Hotel hotel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Hotel.Add(hotel);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (HotelExists(hotel.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = hotel.id }, hotel);
        }

        // DELETE: api/Hotels/5
        [ResponseType(typeof(Hotel))]
        public IHttpActionResult DeleteHotel(int id)
        {
            Hotel hotel = db.Hotel.Find(id);
            if (hotel == null)
            {
                return NotFound();
            }

            db.Hotel.Remove(hotel);
            db.SaveChanges();

            return Ok(hotel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HotelExists(int id)
        {
            return db.Hotel.Count(e => e.id == id) > 0;
        }
    }
}