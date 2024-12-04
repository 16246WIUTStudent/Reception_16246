using System.ComponentModel.DataAnnotations;

namespace API_16246.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }

        [Required]
        [MaxLength(10)]
        public string RoomNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string RoomType { get; set; }

        [Required]
        public decimal PricePerNight { get; set; }

        [Required]
        public bool Availability { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
