using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;
namespace DVLD
{
    public partial class MainPeopleForm : Form
    {
        public MainPeopleForm()
        {
            InitializeComponent();
        }

        private void _RefreshDate()
        {
            dataGridViewPeople.DataSource = ClsPersonBusiness.GetAllPeople();

        }
        private void _getPersonByID(int UserID) {
            dataGridViewPeople.DataSource = ClsPersonBusiness.FindPersonByID_DataTable(UserID);
            }

        private void _getPersonNationalID(string NID) {
            dataGridViewPeople.DataSource = ClsPersonBusiness.FindPersonByNationalNumberAsDataTable(NID);

            }
        private void Form1_Load(object sender, EventArgs e)
        {
            _RefreshDate();
            comboBoxFilteBy.Items.Add("Choose Filter");
            comboBoxFilteBy.Items.Add("ID");
            comboBoxFilteBy.Items.Add("National ID");
            comboBoxFilteBy.SelectedIndex = 0;

            }

        private void pictureBoxAddPeople_Click(object sender, EventArgs e)
        {
            addUpdatePerson addUpdatePeople = new addUpdatePerson();
            addUpdatePeople.ShowDialog();
            
            _RefreshDate();
        }

        private void editeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUpdatePerson edite = new addUpdatePerson(Convert.ToInt32(dataGridViewPeople.CurrentRow.Cells[0].Value));
            edite.ShowDialog();
            _RefreshDate();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ClsPersonBusiness.delete(Convert.ToInt32(dataGridViewPeople.CurrentRow.Cells[0].Value))) {
                MessageBox.Show("Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            else {
                MessageBox.Show("Delete Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            _RefreshDate();
            }

        private void comboBoxFilteBy_SelectedValueChanged(object sender, EventArgs e) {

            if (comboBoxFilteBy.SelectedIndex == 0)
                return; 

            textBoxFilter.Visible = true;
            
            }

        private void textBoxFilter_TextChanged(object sender, EventArgs e) {
            if (comboBoxFilteBy.SelectedIndex == 1 && !string.IsNullOrEmpty(textBoxFilter.Text)) {
                if (int.TryParse(textBoxFilter.Text, out int personID)) {
                    _getPersonByID(personID); 
                    }
                else {
                    _RefreshDate();

                    }
                }
            else {
                _RefreshDate();
                }
            ///
            if (comboBoxFilteBy.SelectedIndex == 2 && !string.IsNullOrEmpty(textBoxFilter.Text)) {
                _getPersonNationalID(textBoxFilter.Text);
                }
            else {
                _RefreshDate();
                }

            }
        }
}
