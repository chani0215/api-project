using System.ComponentModel.DataAnnotations;

namespace Chinese_Auction.Models
{
    public class Purchases
    {
        [Key]
        public int PurchaseId { get; set; }
        public Gifts? Gift { get; set; }
        public User? User { get; set; }

    }
}
