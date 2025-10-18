using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DVLD
{
    public partial class addUpdatePerson : Form
    {
        ClsPersonBusiness Person = new ClsPersonBusiness();
        DataTable Countires = ClsCountryBusiness.GetAllCountry();
        public enum EnMode
        {
            add = 0,
            update =1
        }
        public int PersonID {  get; set; }
        public EnMode Mode { get; set; }

        public addUpdatePerson() {
            InitializeComponent();
            
            
                RBMale.CheckedChanged += RBMale_CheckedChanged;
                RBFemale.CheckedChanged += RBFemale_CheckedChanged;
                
            Mode = EnMode.add;
            ShowRemoveImage();
            }
        public addUpdatePerson(int personID)
        {
            InitializeComponent();
            this.PersonID = personID;
            Mode = EnMode.update;
            /////Get Person
            ///
            _loadPrsonData();
           
        }

        private void _loadPrsonData() {
            Person = ClsPersonBusiness.FindPersonByID(PersonID);
            if (Person == null) {
                MessageBox.Show("There Is No Person");
                this.Close();
                return;
                }

            RBMale.CheckedChanged += RBMale_CheckedChanged;
            RBFemale.CheckedChanged += RBFemale_CheckedChanged;

            LBAddUpdatePersonTitle.Text = "Update Person";
            LBPersonINT.Text = PersonID.ToString();
            txFirst.Text = Person.FirstName;
            txSecond.Text = Person.SecondName;
            txThired.Text = Person.ThiredName;
            txLast.Text = Person.LastName;
            TXNational.Text = Person.NationalNO;
            TXPhone.Text = Person.Phone;
            TXMail.Text = Person.Email;
            RTAdreess.Text = Person.Address;
            ShowRemoveImage();
        // Select the person’s country
        CBCountry.SelectedValue = Person.NationalCountryID;
            DTBirth.Value = Person.dateOfBirth;
            // get Gendor
           SetGenderRadioButton();
            LoadPersonImage();
            }
        private void UpdateGenderImage() {
            if (RBMale.Checked)
                pictureBox2.Image = Image.FromFile("C:\\Users\\Almohandes.Store\\OneDrive\\Desktop\\Project\\images\\male.png");
            else
                pictureBox2.Image = Image.FromFile("C:\\Users\\Almohandes.Store\\OneDrive\\Desktop\\Project\\images\\female.png");
            }

        private void RBMale_CheckedChanged(object sender, EventArgs e) {
            if (!HasCustomImage()) {
                if (RBMale.Checked) {
                    pictureBox2.Image = Image.FromFile("C:\\Users\\Almohandes.Store\\OneDrive\\Desktop\\Project\\images\\male.png");
                    }
                }
            }
        private void RBFemale_CheckedChanged(object sender, EventArgs e) {
           
            if (!HasCustomImage()) {
                if (RBFemale.Checked) {
                    pictureBox2.Image = Image.FromFile("C:\\Users\\Almohandes.Store\\OneDrive\\Desktop\\Project\\images\\female.png");
                    }
                }
            }

        private void SetGenderRadioButton() {
            if (Person.Gendor == 0)
                RBMale.Checked = true;
            else
                RBFemale.Checked = true;
            }
        private void LoadPersonImage() {
            if (!string.IsNullOrEmpty(Person.ImagePath)) {
                pictureBox2.Image = Image.FromFile(Person.ImagePath);
                }
            else {
                if (RBMale.Checked)
                    pictureBox2.Image = Image.FromFile("C:\\Users\\Almohandes.Store\\OneDrive\\Desktop\\Project\\images\\male.png");
                else
                    pictureBox2.Image = Image.FromFile("C:\\Users\\Almohandes.Store\\OneDrive\\Desktop\\Project\\images\\female.png");
                }
            }

        private void addUpdatePerson_Load(object sender, EventArgs e) {
            CBCountry.DataSource = Countires;
            CBCountry.DisplayMember = "CountryName";
            CBCountry.ValueMember = "CountryID";
            }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofg.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(ofg.FileName);
                Person.ImagePath = ofg.FileName;
            }
            ShowRemoveImage();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Person.FirstName = txFirst.Text.Trim();
            Person.SecondName = txSecond.Text.Trim();
            Person.ThiredName = txThired.Text.Trim();
            Person.LastName = txLast.Text.Trim();
            Person.NationalNO = TXNational.Text.Trim();
            Person.Phone = TXPhone.Text.Trim();
            Person.Email = TXMail.Text.Trim();
            Person.Address = RTAdreess.Text.Trim();
            Person.dateOfBirth = DTBirth.Value;
            Person.NationalCountryID = Convert.ToInt32(CBCountry.SelectedValue);
            Person.ImagePath = Person.ImagePath ?? ""; 

            if (RBMale.Checked)
                Person.Gendor = 0;
            else
                Person.Gendor = 1;

            if (Mode == EnMode.add)
            {
                if (Person.Save())
                {
                    MessageBox.Show("Added Susccfully!");
                }
                else
                {
                    MessageBox.Show("Added Failed!");

                }
            }
            if (Mode == EnMode.update)
            {
                if (Person.Save())
                {
                    MessageBox.Show("Update Susccfully!");
                }
                else
                {
                    MessageBox.Show("Update Failed!");

                }
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (RBMale.Checked) {
                pictureBox2.Image = Image.FromFile("C:\\Users\\Almohandes.Store\\OneDrive\\Desktop\\Project\\images\\male.png");
                Person.ImagePath = null;

                }
            else {
                pictureBox2.Image = Image.FromFile("C:\\Users\\Almohandes.Store\\OneDrive\\Desktop\\Project\\images\\female.png");
                Person.ImagePath = null;

                }
            ShowRemoveImage();
            }

        private bool HasCustomImage() {
            return !string.IsNullOrEmpty(Person.ImagePath)
                && !Person.ImagePath.Contains("male.png")
                && !Person.ImagePath.Contains("female.png");
            }

        private void ShowRemoveImage() {


            linkLabel2.Visible = HasCustomImage();
            }

            }
    }
