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
    public partial class MenuForm : Form
    {
        private readonly Building building;
        private Student student;
        public MenuForm(Building building, Student student)
        {
            InitializeComponent();
            this.building = building;
            this.student = student;
            label3.Text = $"{student.Firstname} {student.Lastname}";
        }

        

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.MenuForm = null;
            FormManager.loginForm.Show();
        }

        private void TaskLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormManager.TaskForm.Show();
            this.Hide();
        }

        private void omplaintLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormManager.complaintsForm.Show();
            this.Hide();
        }

        private void RulesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormManager.rulesForm.Show();   
            this.Hide();
        }

        private void AnnouncementLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormManager.announcementForm.Show();
            this.Hide();
        }

        private void PaymentLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormManager.paymentForm.Show(); 
            this.Hide();    
        }

        private void ProfileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormManager.profileForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
