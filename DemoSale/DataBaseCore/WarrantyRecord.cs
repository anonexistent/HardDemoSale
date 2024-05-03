using DemoSale.DataBaseCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSale.Data
{
    [PrimaryKey("warrantyId")]
    public class WarrantyRecord
    {
        private Guid? _warrantyId;

        private DateOnly? _dateShipment;
		private DateOnly? _dateUnsubscribe;
        //	№УПД
        /*
		 * 01УТ-000006
		 */
        private string? _unTransDocNumber;

        private uint _pktParentId;

        public Pkt pktParent { get; private set; }

        private string _subjectVin;

        private string _contractId;

        public WarrantyContract contract { get; set; }
        public WarrantySubject subject { get; set; }

        #region from pkt
        private string? _paymentMethod { get { return pktParent.paymentMethod; } }
		private string? _dealer { get { return pktParent.dealer; } }
        //	Модель  (коплектация)
        private string? _positionName { get { return pktParent.positionName; } }       
        private string? _seller { get { return pktParent.seller; } }
		private string? _region { get { return pktParent.region; } }
		private string? _manager { get { return pktParent.manager; } }
        #endregion

        #region ctors

        public WarrantyRecord(string contractId, string subjectVin, uint pktParentId)
        {
            this.pktParentId = pktParentId;
            this.contractId = contractId;
            this.subjectVin = subjectVin;
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

        public string subjectVin
        {
            get { return _subjectVin; }
            set { _subjectVin = value; }
        }

        public string contractId
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

        public string unTransDocNumber
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
            private set { _pktParentId = value; }
        }

        #endregion
    }
}