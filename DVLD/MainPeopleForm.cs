using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleDataBaseLayer;
namespace DVLD
{
    public partial class MainPeopleForm : Form
    {
        public MainPeopleForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridViewPeople.DataSource = clsPeopleDataBaseLayer.GetAllPeople();

        }

        private void pictureBoxAddPeople_Click(object sender, EventArgs e)
        {
            addUpdatePerson addUpdatePeople = new addUpdatePerson();
            addUpdatePeople.Show();
        }
    }
}
