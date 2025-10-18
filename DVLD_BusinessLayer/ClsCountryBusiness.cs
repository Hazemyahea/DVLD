using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccessLayer;
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
        private ClsCountryBusiness(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            Mode = enMode.update;
        }
        public static DataTable GetAllCountry()
        {
            return clsCountryDataLayer.GetAllCountry();
        }
        public static ClsCountryBusiness getCountrybyID(int CountryID)
        {
            string countryName = null;
            
            if (clsCountryDataLayer.GetCountrybyID(CountryID, ref countryName))
            {
                return new ClsCountryBusiness(CountryID, countryName);
            }
            else
            {
                return null;
            }

        }
    }
}
