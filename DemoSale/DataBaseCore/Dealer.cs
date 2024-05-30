using System.ComponentModel.DataAnnotations;

namespace DemoSale.DataBaseCore
{
    public class Dealer
    {
        [Key]
        public string dealerName { get; set; }
        public Dealer(string dealerName)
        {
            this.dealerName = dealerName;
        }
    }
}
