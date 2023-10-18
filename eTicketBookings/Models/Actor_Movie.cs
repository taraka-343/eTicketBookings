using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketBookings.Models
{
    public class Actor_Movie
    {
        public int movieId { get; set; }
        public Movie Movie { get; set; }


        public int actorId { get; set; }
        public Actor Actor { get; set; }
    }
}
