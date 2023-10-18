using eTicketBookings.Data.Base;
using eTicketBookings.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketBookings.Data.Services
{
    public class actorService:EntityBaseRepository<Actor>,IActorService
    {
        public actorService(AppDbContext context):base(context)
        {
           
        }

        
    }
}
