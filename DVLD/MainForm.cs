using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MainPeopleForm mainPeopleForm = new MainPeopleForm();
            mainPeopleForm.Show(); // بدل ShowDialog()
        }
    }
}
