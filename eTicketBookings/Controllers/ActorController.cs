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
    public class ActorController : Controller
    {
        private readonly IActorService _service;
        public ActorController(IActorService service)
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
        public async Task<IActionResult> Create([Bind("profilePictureUrl", "fullName","Bio")]Actor newActor)
        {
            if (!ModelState.IsValid)
            {
                return View(newActor);
            }
            await _service.addAsync(newActor);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int id)
        {
           var data= await _service.getByIdAsync(id);
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
        public async Task<IActionResult> Edit(int id,[Bind("id,profilePictureUrl", "fullName", "Bio")] Actor newActor)
        {
            if (!ModelState.IsValid)
            {
                return View(newActor);
            }
            await _service.UpdateAsync(id,newActor);
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
                return View("NotFound");
            }
            await _service.deleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
