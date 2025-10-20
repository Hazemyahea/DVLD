using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Person {
    public partial class ShowPersonDetailes : Form {
        private int _PersonID;
        public ShowPersonDetailes(int personID) {
            InitializeComponent();
            _PersonID = personID;
            }

        private void ShowPersonDetailes_Load(object sender, EventArgs e) {
            ctrPersonCard.PersonID = this._PersonID;
            ctrPersonCard.LoadPersonInfo();
            }
        }
    }
