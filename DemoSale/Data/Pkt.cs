using Syncfusion.Windows.Shared;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DemoSale.Data
{
    public class Pkt
    {
        [Key]
        private uint _pktId;

        private int _monthDeal;
        //  дата отгрузки
        private DateOnly _dateShipment = new DateOnly(2020,1,1);
        //  дата поступления
        private DateOnly _dateEntry = new DateOnly(2020, 1, 1);
		private string _seller = "н/д";
        private string _sellerAgent;

        private string _region = "н/д";
		private string _manager = "н/д";
		private string _positionType = "н/д";
		private string _positionName = "н/д";
		private int _count;
        //  поставщик
		private string _dealer = "н/д";
		//	закуп
		private double _purchaseMoney;
		//	оплачено
		private double _paidMoney;
		//	долг
		private double _deptMoney;
		private DateOnly _paymentTerm = new DateOnly(2020, 1, 1);
		private string _specification = "н/д";
		private double _salesDepartmentMoney;
		private double _realization;
		private double _arrivedMoney;
		private double _realizationDept;
		private DateOnly _paymentTermRealization = new DateOnly(2020, 1, 1);
		private string _paymentMethod = "н/д";
		private double _marginalProfit;
		private double _transportOther;
		private double _transportOtherNds;
		private double _loadingUnloading;
		//	кв.
		private double _kvMoney;
		//	прочие
		private double _otherMoney;
		private string _dopPositionDescription = "н/д";
		private DateOnly _deliveryDate = new DateOnly(2020, 1, 1);
		private double _forCalculation;

        #region ctors

        public Pkt()
        {
            
        }

        public Pkt(int monthDeal, DateOnly dateShipment, DateOnly dateEntry, string seller, string sellerAgent,
            string region, string manager, string positionType, string positionName, int count,
            string dealer, double purchaseMoney, double paidMoney, double deptMoney, DateOnly paymentTerm,
            string specification, double salesDepartmentMoney, double realization, double arrivedMoney,
            double realizationDept, DateOnly paymentTermRealization, string paymentMethod,
            double marginalProfit, double transportOther, double transportOtherNds, double loadingUnloading,
            double kvMoney, double otherMoney, string dopPositionDescription, DateOnly deliveryDate, double forCalculation)
        {
            this.monthDeal = monthDeal;
            this.dateShipment = dateShipment;
            this.dateEntry = dateEntry;
            this.seller = seller;
            this.sellerAgent = sellerAgent;
            this.region = region;
            this.manager = manager;
            this.positionType = positionType;
            this.positionName = positionName;
            this.count = count;
            this.dealer = dealer;
            this.purchaseMoney = purchaseMoney;
            this.paidMoney = paidMoney;
            //this.deptMoney = deptMoney;
            this.paymentTerm = paymentTerm;
            this.specification = specification;
            this.salesDepartmentMoney = salesDepartmentMoney;
            this.realization = realization;
            this.arrivedMoney = arrivedMoney;
            //this.realizationDept = realizationDept;
            this.paymentTermRealization = paymentTermRealization;
            this.paymentMethod = paymentMethod;
            //this.marginalProfit = marginalProfit;
            this.transportOther = transportOther;
            this.transportOtherNds = transportOtherNds;
            this.loadingUnloading = loadingUnloading;
            this.kvMoney = kvMoney;
            this.otherMoney = otherMoney;
            this.dopPositionDescription = dopPositionDescription;
            this.deliveryDate = deliveryDate;
            this.forCalculation = forCalculation;
        }

        #endregion

        #region auto props

        public double forCalculation
        {
            get { return _forCalculation; }
            set { _forCalculation = value; }
        }

        public DateOnly deliveryDate
        {
            get { return _deliveryDate; }
            set { _deliveryDate = value; }
        }

        public string dopPositionDescription
        {
            get { return _dopPositionDescription; }
            set { _dopPositionDescription = value; }
        }

        public double otherMoney
        {
            get { return _otherMoney; }
            set { _otherMoney = value; }
        }

        public double kvMoney
        {
            get { return _kvMoney; }
            set { _kvMoney = value; }
        }

        public double loadingUnloading
        {
            get { return _loadingUnloading; }
            set { _loadingUnloading = value; }
        }

        public double transportOtherNds
        {
            get { return _transportOtherNds; }
            set { _transportOtherNds = value; }
        }

        public double transportOther
        {
            get { return _transportOther; }
            set { _transportOther = value; }
        }


        public double marginalProfit
        {
            set 
            {

            }
            get { return _realization - _purchaseMoney - transportOther - _transportOtherNds - _loadingUnloading - _kvMoney - _otherMoney; }
        }

        public string paymentMethod
        {
            get { return _paymentMethod; }
            set { _paymentMethod = value; }
        }

        public DateOnly paymentTermRealization
        {
            get { return _paymentTermRealization; }
            set { _paymentTermRealization = value; }
        }

        public double realizationDept
        {
            get { return _realization - _arrivedMoney; }
        }

        public double arrivedMoney
        {
            get { return _arrivedMoney; }
            set { _arrivedMoney = value; }
        }

        public double realization
        {
            get { return _realization; }
            set { _realization = value; }
        }

        public double salesDepartmentMoney
        {
            get { return _salesDepartmentMoney; }
            set { _salesDepartmentMoney = value; }
        }

        public string specification
        {
            get { return _specification; }
            set { _specification = value; }
        }

        public DateOnly paymentTerm
        {
            get { return _paymentTerm; }
            set { _paymentTerm = value; }
        }

        public double deptMoney
        {
            set 
            { 
                //if (value == _purchaseMoney - _paidMoney) _deptMoney = _purchaseMoney - _paidMoney;
                //else _deptMoney=-1;
            }
            get { return _purchaseMoney - _paidMoney; }
        }

        public double paidMoney
        {
            get { return _paidMoney; }
            set { _paidMoney = value; }
        }

        public double purchaseMoney
        {
            get { return _purchaseMoney; }
            set { _purchaseMoney = value; }
        }

        public string dealer
        {
            get { return _dealer; }
            set { _dealer = value; }
        }


        public int count
        {
            get { return _count; }
            set
            {
                if (value > 0) _count = value;
                else _count = 0;
            }
        }

        public string positionName
        {
            get { return _positionName; }
            set { _positionName = value; }
        }

        public string positionType
        {
            get { return _positionType; }
            set { _positionType = value; }
        }


        public string manager
        {
            get { return _manager; }
            set { _manager = value; }
        }

        public string region
        {
            get { return _region; }
            set { _region = value; }
        }
        public string sellerAgent
        {
            get { return _sellerAgent; }
            set { _sellerAgent = value; }
        }

        public string seller
        {
            get { return _seller; }
            set { _seller = value; }
        }

        public DateOnly dateEntry
        {
            get { return _dateEntry; }
            set { _dateEntry = value; }
        }

        public DateOnly dateShipment
        {
            get { return _dateShipment; }
            set { _dateShipment = value; }
        }

        public int monthDeal
        {
            get { return _monthDeal; }
            set
            {
                if (value > 0 & value <= 12) _monthDeal = value;
                else _monthDeal = 1;
            }
        }

        public uint pktId
        {
            get { return _pktId; }
            set { _pktId = value; }
        }

        #endregion

    }
}
