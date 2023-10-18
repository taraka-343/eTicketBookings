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
    public class ProducerController : Controller
    {
        private readonly IProducerService _service;
        public ProducerController(IProducerService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.getAllAsync();
            return View(data);
        }
        public async Task<IActionResult> Details(int id)
        {
            var data = await _service.getByIdAsync(id);
            if (data==null)
            {
                return View("NotFound");
            }
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("profilePictureUrl", "fullName", "Bio")] Producer newProducer)
        {
            if (!ModelState.IsValid)
            {
                return View(newProducer);
            }
            await _service.addAsync(newProducer);
            return RedirectToAction(nameof(Index));
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
        public async Task<IActionResult> Edit(int id, [Bind("id,profilePictureUrl", "fullName", "Bio")] Producer newProducer)
        {
            if (!ModelState.IsValid)
            {
                return View(newProducer);
            }
            await _service.UpdateAsync(id, newProducer);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _service.getByIdAsync(id);
            if (data == null)
            {
                return View("NotFound");
            }
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var data = await _service.getByIdAsync(id);
            if (data == null)
            {
                return View("Not Found");
            }
            await _service.deleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
