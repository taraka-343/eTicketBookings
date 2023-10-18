using eTicketBookings.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketBookings.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile Picture URL is required")]

        public string profilePictureUrl { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage ="FullName is required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Length should be in between 3 to 50")]

        public string fullName { get; set; }
        [Display(Name = "BIO")]
        [Required(ErrorMessage ="Bio is required")]

        public string Bio { get; set; }
        //relationship
        public List<Movie> movies { get; set; }
    }
}
