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
        private void Form1_Load(object sender, EventArgs e)
        {
            _RefreshDate();

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
                
        }
}
