
//Student ID: 00016246

using System.ComponentModel.DataAnnotations;

namespace API_16246.Models
{
    public class Guest
    {
        [Key]
        public int GuestId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
