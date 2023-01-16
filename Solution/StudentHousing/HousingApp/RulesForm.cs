using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousingApp
{
    public partial class RulesForm : Form
    {
        private readonly Building building;
        public RulesForm(Building building)
        {
            InitializeComponent();
            this.building = building;   
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void RulesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.rulesForm = null;
            FormManager.MenuForm.Show();
        }
    }
}
