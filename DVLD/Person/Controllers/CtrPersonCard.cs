using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Person.Controllers {
    public partial class CtrPersonCard : UserControl {
        private ClsPersonBusiness person;
        private int _PersonID;
        public int PersonID {
            get { return _PersonID; }
            set { _PersonID = value; }
            }
        public CtrPersonCard() {
            InitializeComponent();
            }

        private void CtrPersonCard_Load(object sender, EventArgs e) {
            }
        public void LoadPersonInfo() {
            labelPersonIDINT.Text = Convert.ToString(PersonID);
            person = ClsPersonBusiness.FindPersonByID(PersonID);
            if (person == null) {
                MessageBox.Show("Person not found!");
                return;
                }
            labelNameR.Text = person.FirstName;
            labelAddressR.Text = person.Address;
            labelCountryR.Text = person.CountryInfo.CountryName;
            labelDateR.Text = Convert.ToString(person.dateOfBirth.ToString("dd/MM/yyyy"));
            labelEmailR.Text = person.Email;
            labelGendorR.Text = _gendorHandel();
            labelntR.Text = person.NationalNO;
            labelPhoneR.Text = person.Phone;
            pictureBoxProfile.ImageLocation = person.ImagePath;
           
            }
        private string _gendorHandel() {
            if (person.Gendor == 0) {
                return "Male";
                }
            else {
                return "Female";
                }
            }

        private void linkLabelEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            addUpdatePerson edite = new addUpdatePerson(_PersonID);
            edite.ShowDialog();
            LoadPersonInfo();
            }
        }
    }
