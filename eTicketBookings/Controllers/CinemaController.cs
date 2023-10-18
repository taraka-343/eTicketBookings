using eTicketBookings.Data;
using eTicketBookings.Data.Services;
using eTicketBookings.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketBookings.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ICinemaService _service;
        public CinemaController(ICinemaService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.getAllAsync();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("logo", "Name", "Description")] Cinema newCinema)
        {
            if (!ModelState.IsValid)
            {
                return View(newCinema);
            }
            await _service.addAsync(newCinema);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int id)
        {
            var data=await _service.getByIdAsync(id);
            if (data==null)
            {
                return View("NotFound");
            }
            return View(data);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var data = await _service.getByIdAsync(id);
            if (data == null)
            {
                return View("NotFound");
            }
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("id","logo", "Name", "Description")] Cinema newCinema)
        {
            if (!ModelState.IsValid)
            {
                return View(newCinema);
            }
            await _service.UpdateAsync(id, newCinema);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _service.getByIdAsync(id);
            if (data==null)
            {
                return View("NotFound");
            }
            return View(data);
        }
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var data = await _service.getByIdAsync(id);
            if (data == null)
            {
                return View("NotFound");
            }
            await _service.deleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
