using System.ComponentModel.DataAnnotations;

namespace Chinese_Auction.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public virtual ICollection<Gifts> Gifts { get; set; } = new List<Gifts>();
    }
}
