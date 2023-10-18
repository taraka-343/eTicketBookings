using eTicketBookings.Data.Base;
using eTicketBookings.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketBookings.Data.Services
{
    public class movieService:EntityBaseRepository<Movie>,IMovieService
    {
        public readonly AppDbContext _context;
        public movieService(AppDbContext context):base(context)
        {
            _context = context;
        }

        public async Task<Movie> getMovieDetailsByIdAsync(int id)
        {
            var data = await _context.movie.Include(c => c.cinema).Include(p => p.producer).Include(am => am.actor_movie).ThenInclude(a => a.Actor).FirstOrDefaultAsync(n => n.id == id);
            return data;
        }
    }
}
