using eTicketBookings.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketBookings.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int id { get; set; }
        [Display(Name ="Cinema Logo")]
        public string logo { get; set; }
        [Display(Name ="Name")]
        public string Name { get; set; }
        [Display(Name ="Description")]
        public string Description { get; set; }
        //relationship
        public List<Movie> movies { get; set; }

    }
}
