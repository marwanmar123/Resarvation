using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Resarvation.Data;
using Resarvation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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

        [Authorize(Roles = "admin")]
        // GET: ReservationController
        public ActionResult Index()
        {
            //var srx = _db.Reservations.OrderBy(r => r.Date);

            var Result = (from r in _db.Reservations
                          join a in _db.Apprenants
                          on r.Apprenant.Id equals a.Id
                          join tr in _db.TypeReservations
                          on r.TypeReservation.Id equals tr.Id

                          select new ReservApprenantViewModel
                          {
                              Id = a.Id,
                              UserName = a.UserName,
                              Email = a.Email,
                              Date = r.Date,
                              Cause = r.Cause,
                              Status = r.Status,
                              TypeReservationId = tr.Id,
                              Name = tr.Name,
                          }).ToList();

            return View("Index", Result);
        }


        public ActionResult History()
        {

            //var user = User.Identity.Name;
            var us = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var Result = (from r in _db.Reservations
                          join a in _db.Apprenants
                          on r.Apprenant.Id equals a.Id
                          join tr in _db.TypeReservations
                          on r.TypeReservation.Id equals tr.Id
                          where a.Id == us
                          select new ReservApprenantViewModel
                          {
                              Id = a.Id,
                              UserName = a.UserName,
                              Email = a.Email,
                              Date = r.Date,
                              Cause = r.Cause,
                              Status = r.Status,
                              TypeReservationId = tr.Id,
                              Name = tr.Name
                          }).ToList();

            return View(Result);
        }


        // GET: ReservationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReservationController/Create
        public IActionResult Create()
        {

            ViewData["type"] = new SelectList(_db.TypeReservations, "Id", "Name");
            return View();
        }

        // POST: ReservationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ReservApprenantViewModel viewModel)
        {


            Reservation resarvation = new Reservation()
            {
                Date = viewModel.Date,
                Status = viewModel.Status,
                Cause = viewModel.Cause

            };



            var usId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var type = _db.TypeReservations.Single(t => t.Id == viewModel.TypeReservationId);

            resarvation.ApprenantId = usId;
            resarvation.TypeReservation = type;

            _db.Reservations.Add(resarvation);

            await _db.SaveChangesAsync();

            ViewData["type"] = new SelectList(_db.TypeReservations, "Id", "Name", viewModel.TypeReservationId);



            return RedirectToAction(nameof(Index));


        }

        // GET: ReservationController/Edit/5
        public ActionResult Edit(string id, ReservApprenantViewModel viewModel)
        {
            var res = _db.TypeReservations.Where(t => t.Id == viewModel.Id).FirstOrDefault();
            if (res != null)
            {
                var vm = new ReservApprenantViewModel { Id = res.Id };

                if (vm.Reservation != null)
                {
                    res.Id = vm.TypeReservationId;
                }
            }
            ViewData["type"] = new SelectList(_db.TypeReservations, "Id", "Name");
            return View(res);
        }

        // POST: ReservationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ReservApprenantViewModel viewModel)
        {
            var res = _db.TypeReservations.Where(t => t.Id == viewModel.Id).FirstOrDefault();

            res.Id = viewModel.TypeReservationId;
            res.Name = viewModel.Name;

            //_db.Entry(res).State = EntityState.Modified;
            _db.SaveChanges();
            ViewData["type"] = new SelectList(_db.TypeReservations, "Id", "Name", viewModel.TypeReservationId);
            return RedirectToAction(nameof(Index));

        }

        // GET: ReservationController/Delete/5
        public ActionResult Delete(string id)
        {
            return View();
        }

        // POST: ReservationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
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
