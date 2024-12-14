using System.ComponentModel.DataAnnotations;

namespace Chinese_Auction.Models
{
    public class Donator
    {
        [Key]
        public int DonatorId { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public virtual ICollection<Gifts> Gifts { get; set; } = new List<Gifts>();
    }
}
