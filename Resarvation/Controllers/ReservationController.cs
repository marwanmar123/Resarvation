using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Resarvation.Data;
using Resarvation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resarvation.Controllers
{
    public class ReservationController : Controller
    {
        ApplicationDbContext _db;

        public ReservationController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: ReservationController
        public ActionResult Index()
        {
            var srx = _db.Reservations.OrderBy(r => r.Date);

            var Result = (from r in _db.Reservations
                          join s in _db.Apprenants
                          on r.Apprenant.Id equals s.Id
                          join rt in _db.TypeReservations
                          on r.TypeReservation.Id equals rt.Id

                          select new ReservApprenantViewModel
                          {
                              Id = s.Id,
                              UserName = s.UserName,
                              Email = s.Email,
                              Date = r.Date,
                              Cause = r.Cause,
                              Status = r.Status,
                              TypeReservation = rt.Name,
                          }).ToList();

            return View("Index", Result);
        }


        public ActionResult Reserv()
        {

            var user = User.Identity.Name;
            var Result = (from r in _db.Reservations
                          join s in _db.Apprenants
                          on r.Apprenant.Id equals s.Id
                          join rt in _db.TypeReservations
                          on r.TypeReservation.Id equals rt.Id
                          where s.UserName == user
                          select new ReservApprenantViewModel
                          {
                              Id = s.Id,
                              UserName = s.UserName,
                              Email = s.Email,
                              Date = r.Date,
                              Cause = r.Cause,
                              Status = r.Status,
                              TypeReservation = rt.Name,
                          }).ToList();

            return View("Index", Result);
        }


        //public IActionResult Search(string term)
        //{
        //    var result = _db.Reservations.Where(b => b.Date == ).ToList();
        //    return View("Index", result);
        //}

        // GET: ReservationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReservationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReservationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReservationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
