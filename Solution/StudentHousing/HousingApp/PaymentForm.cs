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
    public partial class PaymentForm : Form
    {
        private readonly Building building;
        private Student student;
        public PaymentForm(Building building, Student student)
        {
            InitializeComponent();
            this.building = building;
            this.student = student;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PaymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.paymentForm = null;
            FormManager.MenuForm.Show();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            RentLabel.Text = Convert.ToString(student.Rent);
        }
    }
}
