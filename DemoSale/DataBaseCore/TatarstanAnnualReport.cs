using DemoSale.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace DemoSale.DataBaseCore
{
    public class TatarstanAnnualReport
    {
        [Key]
        private int _id;
        private DateOnly? _dateShipment;
        private string _positionName;
        private int _count;
        private double _realization;
        private string? _paymentMethod;
        private string? _region;
        //	контрагент
        private string? _seller;
        //	представитель
        private string? _sellerAgent;
        private string? _phone = "н/д";

        private uint _pktId;

        #region ctors

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public TatarstanAnnualReport()
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {

        }

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public TatarstanAnnualReport(Pkt parent)
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {
            this.dateShipment = parent.dateShipment;
            this.positionName = parent.positionName;
            this.count = parent.count;
            this.realization = parent.realization;
            this.paymentMethod = parent.paymentMethod;
            this.region = parent.region;
            this.seller = parent.seller;
            this.sellerAgent = parent.sellerAgent;
            //this.phone = parent.phone;
        }

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public TatarstanAnnualReport(DateOnly dateShipment,
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
            string positionName, int count, double realization, string paymentMethod,
            string region, string seller, string sellerAgent, string phone)
        {
            this.dateShipment = dateShipment;
            this.positionName = positionName;
            this.count = count;
            this.realization = realization;
            this.paymentMethod = paymentMethod;
            this.region = region;
            this.seller = seller;
            this.sellerAgent = sellerAgent;
            this.phone = phone;
        }

        #endregion

        #region auto props

        public uint pktId
        {
            get { return _pktId; }
            set { _pktId = value; }
        }

        public string? phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string? sellerAgent
        {
            get { return _sellerAgent; }
            set { _sellerAgent = value; }
        }

        public string? seller
        {
            get { return _seller; }
            set { _seller = value; }
        }


        public string? region
        {
            get { return _region; }
            set { _region = value; }
        }

        public string? paymentMethod
        {
            get { return _paymentMethod; }
            set { _paymentMethod = value; }
        }


        public double realization
        {
            get { return _realization; }
            set { _realization = value; }
        }


        public int count
        {
            get { return _count; }
            set { _count = value; }
        }


        public string? positionName
        {
            get { return _positionName; }
#pragma warning disable CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
            set { _positionName = value; }
#pragma warning restore CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
        }

        public DateOnly? dateShipment
        {
            get { return _dateShipment; }
            set { _dateShipment = value; }
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        #endregion

    }
}
