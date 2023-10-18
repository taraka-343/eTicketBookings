using eTicketBookings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketBookings.Data.Services
{
    public interface IMovieService:IEntityRepository<Movie>
    {
        Task<Movie> getMovieDetailsByIdAsync(int id);
    }
}
