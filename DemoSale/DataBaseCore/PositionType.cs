﻿using System.ComponentModel.DataAnnotations;

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
