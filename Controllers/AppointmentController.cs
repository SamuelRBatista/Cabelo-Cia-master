using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyApp.Context;
using MyApp.Models;
using System;

namespace MyApp.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly DataContext _context;
        public AppointmentController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var appointment = _context.Appointments.Include(a => a.CategoryService).ToList();           
            return View(appointment);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CategoryServices = new SelectList(_context.CategoryServices, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            _context.SaveChanges();
            return RedirectToAction("Index");

            ViewBag.CategoryServices = new SelectList(_context.CategoryServices, "Id", "Name", appointment.CategoryServiceId);
            return View(appointment);
        }

        //[HttpGet]
        //public IActionResult Edit(int AppointmentId)
        //{
        //    var appointment = _context.Appointments.Find(AppointmentId);

        //    if (appointment == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(appointment);
        //}

        //[HttpPost]
        //public IActionResult Edit(int AppointmentId, Appointment appointment)
        //{
        //    if (AppointmentId != appointment.AppointmentId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Appointments.Update(appointment);
        //            _context.SaveChanges();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!SchedulingExists(appointment.AppointmentId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }

        //        return RedirectToAction("Index");
        //    }

        //    return View(appointment);
        //}

        //[HttpPost, ActionName("Delete")]
        //public IActionResult DeleteConfirmed(int AppointmentId)
        //{
        //    var appointment = _context.Appointments.Find(AppointmentId);

        //    if (appointment == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Appointments.Remove(appointment);
        //    _context.SaveChanges();

        //    return RedirectToAction("Index");
        //}

        private bool SchedulingExists(int AppointmentId)
        {
            return _context.Appointments.Any(e => e.AppointmentId == AppointmentId);
        }

    }
}
