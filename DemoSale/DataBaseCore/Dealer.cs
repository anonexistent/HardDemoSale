using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
