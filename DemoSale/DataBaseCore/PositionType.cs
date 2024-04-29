using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSale.DataBaseCore
{
    public class PositionType
    {
        [Key]
        public string positionName { get; set; }

        public PositionType(string positionName)
        {
            this.positionName = positionName;
        }
    }
}
