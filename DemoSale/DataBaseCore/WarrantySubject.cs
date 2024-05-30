using System;
using System.ComponentModel.DataAnnotations;

namespace DemoSale.DataBaseCore
{
    public class WarrantySubject
    {
        private string? _vin = Guid.NewGuid().ToString();
        //	Модель, номер двигателя
        /*
		 * Д-123S4, 567890
		 */
        private string? _engine;
        private int? _dateRelease;
        //electonic vehicle passport
        private string? _evp;
        private string? _positionName;

        #region ctors

        public WarrantySubject()
        {

        }

        public WarrantySubject(string? vin, string? engine, int? dateRelease, string evp, string positionName)
        {
            this.vin = vin;
            this.engine = engine;
            this.dateRelease = dateRelease;
            this.evp = evp;
            this.positionName = positionName;
        }

        #endregion

        #region auto props

        public string? positionName
        {
            get { return _positionName; }
            set { _positionName = value; }
        }
        public string? evp
        {
            get { return _evp; }
            set { _evp = value; }
        }
        public int? dateRelease
        {
            get { return _dateRelease; }
            set { _dateRelease = value; }
        }
        public string? engine
        {
            get { return _engine; }
            set { _engine = value; }
        }

        [Key]
        public string? vin
        {
            get { return _vin; }
            set { _vin = value; }
        }

        #endregion

    }
}
