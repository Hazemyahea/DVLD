using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class ClsCountryBusiness
    {
        public enum enMode
        {
            update = 0,
            Add =1 
        }
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public enMode Mode { get; set; }

        ClsCountryBusiness() { 
            this.CountryID = 0;
            this.CountryName = null;
            this.Mode = enMode.Add;
        }
        private ClsCountryBusiness(int CountryID, string CountryName, enMode mode)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            Mode = enMode.update;
        }
    }
}
