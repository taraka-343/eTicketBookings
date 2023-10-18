using eTicketBookings.Data.Base;
using eTicketBookings.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketBookings.Data.Services
{
    public class producerService:EntityBaseRepository<Producer>,IProducerService
    {
        public producerService(AppDbContext context):base(context)
        {

        }
    }
}
