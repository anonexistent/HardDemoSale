using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSale.Data
{
    public class WarrantyRecord
    {
		private DateOnly _dateShipment;
		private DateOnly _dateUnsubscribe;
        //	№УПД
        /*
		 * 01УТ-000006
		 */
        private string _unTransDocNumber;
		private string _paymentMethod;
		private string _dealer;
        //	Модель  (коплектация)
        private string _positionName;
		private int _count;
		private string _vin;
        //	Модель, номер двигателя
        /*
		 * Д-123S4, 567890
		 */
        private string _engine;
		private string _seller;
		private string _region;
		private string _manager;
        //	Фактический адресс
        /*
		 * 460000 Уральская обл., с. Цветочкино, ул. Улан-Баторская 123
		 */
        private string _regionDeFacto;
        //	Котакты ИТР, лиц ответственных за эксплуатацию
        /*
		 * 7-912-345-67-89 Евгений
		 */
        private string _engTecWorker;
        //	№ догов. на СО
        private string _serviceContract;
		private DateOnly _dateServiceContract;
		private DateOnly _dateRelease;
        /*
         * 30 м/ч	250м/ч	500м/ч	750м/ч	1000м/ч
         */
        private string _technicalMaintenance;
		//	Дата снятия с учета
		private DateOnly _dateEndWarranty;

        #region ctors

        public WarrantyRecord()
        {
            
        }

        public WarrantyRecord(DateOnly dateShipment, DateOnly dateUnsubscribe, string unTransDocNumber, string paymentMethod, 
            string dealer, string positionName, int count, string vin, string engine, string seller, string region, string manager, 
            string regionDeFacto, string engTecWorker, string serviceContract, DateOnly dateServiceContract, DateOnly dateRelease, 
            string technicalMaintenance, DateOnly dateEndWarranty)
        {
            this.dateShipment = dateShipment;
            this.dateUnsubscribe = dateUnsubscribe;
            this.unTransDocNumber = unTransDocNumber;
            this.paymentMethod = paymentMethod;
            this.dealer = dealer;
            this.positionName = positionName;
            this.count = count;
            this.vin = vin;
            this.engine = engine;
            this.seller = seller;
            this.region = region;
            this.manager = manager;
            this.regionDeFacto = regionDeFacto;
            this.engTecWorker = engTecWorker;
            this.serviceContract = serviceContract;
            this.dateServiceContract = dateServiceContract;
            this.dateRelease = dateRelease;
            this.technicalMaintenance = technicalMaintenance;
            this.dateEndWarranty = dateEndWarranty;
        }

        #endregion

        #region auto props

        public DateOnly dateEndWarranty
        {
            get { return _dateEndWarranty; }
            set { _dateEndWarranty = value; }
        }

        public string technicalMaintenance
        {
            get { return _technicalMaintenance; }
            set { _technicalMaintenance = value; }
        }

        public DateOnly dateRelease
        {
            get { return _dateRelease; }
            set { _dateRelease = value; }
        }

        public DateOnly dateServiceContract
        {
            get { return _dateServiceContract; }
            set { _dateServiceContract = value; }
        }

        public string serviceContract
        {
            get { return _serviceContract; }
            set { _serviceContract = value; }
        }

        public string engTecWorker
        {
            get { return _engTecWorker; }
            set { _engTecWorker = value; }
        }

        public string regionDeFacto
        {
            get { return _regionDeFacto; }
            set { _regionDeFacto = value; }
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

        public string seller
        {
            get { return _seller; }
            set { _seller = value; }
        }

        public string engine
        {
            get { return _engine; }
            set { _engine = value; }
        }

        public string vin
        {
            get { return _vin; }
            set { _vin = value; }
        }

        public int count
        {
            get { return _count; }
            set { _count = value; }
        }

        public string positionName
        {
            get { return _positionName; }
            set { _positionName = value; }
        }

        public string dealer
        {
            get { return _dealer; }
            set { _dealer = value; }
        }

        public string paymentMethod
        {
            get { return _paymentMethod; }
            set { _paymentMethod = value; }
        }

        public string unTransDocNumber
        {
            get { return _unTransDocNumber; }
            set { _unTransDocNumber = value; }
        }

        public DateOnly dateUnsubscribe
        {
            get { return _dateUnsubscribe; }
            set { _dateUnsubscribe = value; }
        }

        public DateOnly dateShipment
        {
            get { return _dateShipment; }
            set { _dateShipment = value; }
        }

        #endregion

    }
}
