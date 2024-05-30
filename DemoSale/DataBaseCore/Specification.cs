using System.ComponentModel.DataAnnotations;

namespace DemoSale.DataBaseCore
{
    public class Specification
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
