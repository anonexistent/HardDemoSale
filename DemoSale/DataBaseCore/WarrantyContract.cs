using System;
using System.ComponentModel.DataAnnotations;

namespace DemoSale.DataBaseCore
{
    public class WarrantyContract
    {
        private string? _serviceContract;
        //	Фактический адресс
        /*
		 * 460000 Уральская обл., с. Цветочкино, ул. Улан-Баторская 123
		 */
        private string? _regionDeFacto;
        //	Котакты ИТР, лиц ответственных за эксплуатацию
        /*
		 * 7-912-345-67-89 Евгений
		 */
        private string? _engTecWorker;
        //	№ догов. на СО

        private DateOnly? _dateServiceContract;
        /*
         * 30 м/ч	250м/ч	500м/ч	750м/ч	1000м/ч
         */
        private int? _technicalMaintenance;
        //	Дата снятия с учета
        private DateOnly? _dateEndWarranty;

        #region ctors

        public WarrantyContract()
        {

        }

        public WarrantyContract(string? regionDeFacto, string? engTecWorker, string? serviceContract,
            DateOnly? dateServiceContract, int? technicalMaintenance, DateOnly? dateEndWarranty)
        {
            _regionDeFacto = regionDeFacto;
            _engTecWorker = engTecWorker;
            _serviceContract = serviceContract;
            _dateServiceContract = dateServiceContract;
            _technicalMaintenance = technicalMaintenance;
            _dateEndWarranty = dateEndWarranty;
        }

        #endregion

        #region auto props

        public DateOnly? dateEndWarranty
        {
            get { return _dateEndWarranty; }
            set { _dateEndWarranty = value; }
        }

        public int? technicalMaintenance
        {
            get { return _technicalMaintenance; }
            set { _technicalMaintenance = value; }
        }

        public DateOnly? dateServiceContract
        {
            get { return _dateServiceContract; }
            set { _dateServiceContract = value; }
        }

        [Key]
        public string? serviceContract
        {
            get { return _serviceContract; }
            set { _serviceContract = value; }
        }

        public string? engTecWorker
        {
            get { return _engTecWorker; }
            set { _engTecWorker = value; }
        }

        public string? regionDeFacto
        {
            get { return _regionDeFacto; }
            set { _regionDeFacto = value; }
        }

        #endregion

    }
}
