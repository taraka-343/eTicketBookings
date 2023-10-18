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
    public class MovieController : Controller
    {
        private readonly IMovieService _service;
        public MovieController(IMovieService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.getAllAsync(n=>n.cinema);
            return View(data);
        }
        public async Task<IActionResult> Details(int id)
        {
            var data=await _service.getMovieDetailsByIdAsync(id);
            return View(data);
        }
    }
}
