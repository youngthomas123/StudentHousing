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
    public partial class Form5 : Form
    {
        private readonly Building building;
        public Form5(Building building)
        {
            InitializeComponent();
            this.building = building;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
