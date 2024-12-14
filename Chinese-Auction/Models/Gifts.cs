using System.ComponentModel.DataAnnotations;

namespace Chinese_Auction.Models
{
    public class Gifts
    {
        [Key]
        public int GiftId { get; set; }
        public string? Name { get; set; }
        public Donator? Donator { get; set; }
        public int Price { get; set; }
        public string? Image { get; set; }
        public virtual ICollection<Purchases> Purchases { get; set; } = new List<Purchases>();
    }
}
