using System;
using System.ComponentModel.DataAnnotations;

namespace DemoSale.DataBaseCore
{
    public class FinanceReport
    {
        [Key]
        public uint id { get; set; }
        public uint pktId { get; set; }
        public DateTime dateCreate { get; private set; } = DateTime.Now;
        public double headPart { get; set; }
        public string? agent { get; set; }
        public double agentPart { get; set; }
        public string manager { get; set; }
        public string region { get; set; }
        public string document { get; set; }
        public DateOnly? dateShipment { get; set; }
        //  контрагент
        public string seller { get; set; }
        //public double salesDepartmentMoney { get; set; }
        //public double realization { get; set; }
        //  +/-, = реализация - цена отдела продаж
        public double difference { get; set; }
        public double managerPart { get; set; }
        ////  type+name
        //public string positionName { get; set; }
        //public double marginalProfit { get; set; }
        //  закупщик
        public string? buyer { get; set; }
        //  1% marginalProfit
        public double buyerPart { get; set; }
    }
}
