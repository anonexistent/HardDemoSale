using Microsoft.EntityFrameworkCore;
using System;

namespace DemoSale.Data
{
    [PrimaryKey("warrantyId")]
    public class WarrantyRecord
    {
        private Guid? _warrantyId = Guid.NewGuid();

        private DateOnly? _dateShipment;
        private DateOnly? _dateUnsubscribe;
        //	№УПД
        /*
		 * 01УТ-000006
		 */
        private string? _unTransDocNumber;

        private uint _pktParentId;

        public Pkt pktParent { get; set; }

        private string? _subjectVin;

        private string? _contractId;

        #region from pkt
        //      private string? _paymentMethod { get { return pktParent.paymentMethod; } }
        //private string? _dealer { get { return pktParent.dealer; } }
        //      //	Модель  (коплектация)
        //      private string? _positionName { get { return pktParent.positionName; } }       
        //      private string? _seller { get { return pktParent.seller; } }
        //private string? _region { get { return pktParent.region; } }
        //private string? _manager { get { return pktParent.manager; } }
        #endregion

        #region ctors

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public WarrantyRecord()
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {

        }

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public WarrantyRecord(string contractId, string subjectVin, uint pktId)
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {
            this.contractId = contractId;
            this.subjectVin = subjectVin;
            this.pktParentId = pktId;
        }

        //public WarrantyRecord(WarrantyContract contractId, WarrantySubject subjectVin, Pkt pktParentId, DateOnly dateShipment, 
        //    DateOnly dateUnsubscribe, string unTransDocNumber)
        //{
        //    this.pktParentId = pktParentId.pktId;
        //    this.contractId = contractId.serviceContract;
        //    this.subjectVin = subjectVin.vin;

        //    this.dateShipment = dateShipment;
        //    this.dateUnsubscribe = dateUnsubscribe;
        //    this.unTransDocNumber = unTransDocNumber;
        //    //this.paymentMethod = paymentMethod;
        //    //this.dealer = dealer;
        //    //this.positionName = positionName;
        //    ////this.count = count;
        //    ////this.vin = vin;
        //    ////this.engine = engine;
        //    //this.seller = seller;
        //    //this.region = region;
        //    //this.manager = manager;
        //    //this.regionDeFacto = regionDeFacto;
        //    //this.engTecWorker = engTecWorker;
        //    //this.serviceContract = serviceContract;
        //    //this.dateServiceContract = dateServiceContract;
        //    ////this.dateRelease = dateRelease;
        //    //this.technicalMaintenance = technicalMaintenance;
        //    //this.dateEndWarranty = dateEndWarranty;
        //}

        #endregion

        #region auto props

        public string? subjectVin
        {
            get { return _subjectVin; }
            set { _subjectVin = value; }
        }

        public string? contractId
        {
            get { return _contractId; }
            set { _contractId = value; }
        }
        //public string manager
        //{
        //    get { return _manager; }
        //}

        //public string region
        //{
        //    get { return _region; }
        //}

        //public string seller
        //{
        //    get { return _seller; }
        //}

        //public string positionName
        //{
        //    get { return _positionName; }
        //}

        //public string dealer
        //{
        //    get { return _dealer; }
        //}

        //public string paymentMethod
        //{
        //    get { return _paymentMethod; }
        //}

        public string? unTransDocNumber
        {
            get { return _unTransDocNumber; }
            set { _unTransDocNumber = value; }
        }

        public DateOnly? dateUnsubscribe
        {
            get { return _dateUnsubscribe; }
            set { _dateUnsubscribe = value; }
        }

        public DateOnly? dateShipment
        {
            get { return _dateShipment; }
            set { _dateShipment = value; }
        }
        public Guid? warrantyId
        {
            get { return _warrantyId; }
        }
        public uint pktParentId
        {
            get { return _pktParentId; }
            set { _pktParentId = value; }
        }

        #endregion
    }
}