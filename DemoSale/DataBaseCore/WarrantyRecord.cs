using DemoSale.DataBaseCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoSale.Data
{
    [PrimaryKey("warrantyId")]
    public class WarrantyRecord
    {
        private Guid? _warrantyId = Guid.NewGuid();

        //private DateOnly? _dateShipment;
        //private DateOnly? _dateUnsubscribe;
        //	№УПД
        /*
		 * 01УТ-000006
		 */
        private string? _unTransDocNumber;

        private uint _pktId;

        public virtual Pkt pktParent { get; set; }
        [ForeignKey("contractId")]
        public virtual WarrantyContract warContract { get; set; }
        [ForeignKey("subjectVin")]
        public virtual WarrantySubject warSub { get; set; }

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

        public WarrantyRecord()
        {

        }

        public WarrantyRecord(string contractId, string subjectVin, uint pktId)
        {
            this.contractId = contractId;
            this.subjectVin = subjectVin;
            this.pktId = pktId;
        }

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

        //public DateOnly? dateUnsubscribe
        //{
        //    get { return _dateUnsubscribe; }
        //    set { _dateUnsubscribe = value; }
        //}

        //public DateOnly? dateShipment
        //{
        //    get { return _dateShipment; }
        //    set { _dateShipment = value; }
        //}
        public Guid? warrantyId
        {
            get { return _warrantyId; }
        }
        public uint pktId
        {
            get { return _pktId; }
            set { _pktId = value; }
        }

        #endregion
    }
}