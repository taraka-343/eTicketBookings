using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using eTicketBookings.Data.Base;
using eTicketBookings.Data.Enumurators;

namespace eTicketBookings.Models
{
    public class Movie:IEntityBase
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double price { get; set; }
        public string imageUrl { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public movieCategory movieCategory { get; set; }
        //relationship
        public List<Actor_Movie> actor_movie { get; set; }
        //cinema
        public int cinemaId { get; set; }
        [ForeignKey("cinemaId")]
        public Cinema cinema { get; set; }
        //producer
        public int producerId { get; set; }
        [ForeignKey("producerId")]
        public Producer producer { get; set; }
    }
}
