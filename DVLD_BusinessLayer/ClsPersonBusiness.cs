using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccessLayer;
namespace DVLD_BusinessLayer
{
    public class ClsPersonBusiness
    {
        public enum enMode
        {
            update = 0,
            Add = 1
        }
        public int PersonID { get; set; }
        public string NationalNO { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThiredName { get; set; }
        public string LastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public int Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalCountryID { get; set; }
        public string ImagePath { get; set; }
        public enMode Mode { get; set; }
        public ClsCountryBusiness CountryInfo;
        public ClsPersonBusiness()
        {
            this.PersonID = 0;
            this.NationalNO = string.Empty;
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.ThiredName = string.Empty;
            this.SecondName = string.Empty;
            this.dateOfBirth = DateTime.MinValue;
            this.Gendor = 0;
            this.Address = string.Empty;
            this.Phone = string.Empty;
            this.Email = string.Empty;
            this.NationalCountryID = 0;
            this.ImagePath = string.Empty;
            this.Mode = enMode.Add;
        }
        private ClsPersonBusiness(
    int personID,
    string nationalNO,
    string firstName,
    string secondName,
    string thiredName,
    string lastName,
    DateTime dateOfBirth,
    int gendor,
    string address,
    string phone,
    string email,
    int nationalCountryID,
    string imagePath)
        {
            this.PersonID = personID;
            this.NationalNO = nationalNO;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThiredName = thiredName;
            this.LastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.Gendor = gendor;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.NationalCountryID = nationalCountryID;
            this.ImagePath = imagePath;
            this.Mode = enMode.update;
            this.CountryInfo = ClsCountryBusiness.getCountrybyID(NationalCountryID);
        }
        private bool _addNewPerson()
        {
            int personID = clsPeopleDataBaseLayer.AddNewPerson(this.NationalNO, this.FirstName, this.SecondName, this.ThiredName, this.LastName
                , this.dateOfBirth, this.Gendor, this.Address, this.Phone, this.Email, this.NationalCountryID, this.ImagePath);
            if (personID > 0)
            {
                this.PersonID = personID;
                return true;
            }
            return false;
        }

        static public bool delete(int PersonID) {
            if (clsPeopleDataBaseLayer.Delete(PersonID)) {
                    return true;
                }
            return false;
            }
        private bool _updatePerson()
        {
            return clsPeopleDataBaseLayer.UpdatePerson(
        this.PersonID,
        this.NationalNO,
        this.FirstName,
        this.SecondName,
        this.ThiredName,
        this.LastName,
        this.dateOfBirth,
        this.Gendor,
        this.Address,
        this.Phone,
        this.Email,
        this.NationalCountryID,
        this.ImagePath
          );
        }
        static public ClsPersonBusiness FindPersonByID(int PersonID)
        {
            string NationalNO = "", FirstName = "", SecondName = "", ThiredName = "", LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            int Gendor = 0, NationalCountryID = 0;
            string Address = "", Phone = "", Email = "", ImagePath = "";

            bool isFound = clsPeopleDataBaseLayer.FindPersonByID(
        PersonID,
        ref NationalNO,
        ref FirstName,
        ref SecondName,
        ref ThiredName,
        ref LastName,
        ref DateOfBirth,
        ref Gendor,
        ref Address,
        ref Phone,
        ref Email,
        ref NationalCountryID,
        ref ImagePath
    ); if (isFound)
            {
                return new ClsPersonBusiness(
                    PersonID,
                    NationalNO,
                    FirstName,
                    SecondName,
                    ThiredName,
                    LastName,
                    DateOfBirth,
                    Gendor,
                    Address,
                    Phone,
                    Email,
                    NationalCountryID,
                    ImagePath
                );

                }
            else
            {
                return null;
            }
        }
        static public ClsPersonBusiness FindPersonByNationalNumber(string NationalNO)
        {
            string FirstName = "", SecondName = "", ThiredName = "", LastName = "";
            DateTime DateOfBirth = DateTime.MinValue;
            int Gendor = 0, NationalCountryID = 0;
            string Address = "", Phone = "", Email = "", ImagePath = "";
            int PersonID = -1;
            bool isFound = clsPeopleDataBaseLayer.FindPersonByNationalID(
        NationalNO,
        ref PersonID,
        ref FirstName,
        ref SecondName,
        ref ThiredName,
        ref LastName,
        ref DateOfBirth,
        ref Gendor,
        ref Address,
        ref Phone,
        ref Email,
        ref NationalCountryID,
        ref ImagePath
    ); if (isFound)
            {
                // لو لقينا الشخص، نرجع Object فيه البيانات
                return new ClsPersonBusiness
                {
                    PersonID = PersonID,
                    NationalNO = NationalNO,
                    FirstName = FirstName,
                    SecondName = SecondName,
                    ThiredName = ThiredName,
                    LastName = LastName,
                    dateOfBirth = DateOfBirth,
                    Gendor = Gendor,
                    Address = Address,
                    Phone = Phone,
                    Email = Email,
                    NationalCountryID = NationalCountryID,
                    ImagePath = ImagePath
                };
            }
            else
            {
                return null;
            }
        }
        static public DataTable GetAllPeople()
        {
            return clsPeopleDataBaseLayer.GetAllPeople();
        }
        static public bool isPersonFound(int PersonID)
        {
            return clsPeopleDataBaseLayer.IsPersonExist(PersonID);
        }
        
        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.Add:
                    if (_addNewPerson())
                    {
                        this.Mode = enMode.update;
                        return true;
                    }
                    return false;

                case enMode.update:
                    return _updatePerson();

                default:
                    return false;
            }
        }

    }
}
