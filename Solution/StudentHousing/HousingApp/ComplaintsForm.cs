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
    public partial class ComplaintsForm : Form
    {
        private readonly Building building;
        private Student student;
        public ComplaintsForm(Building building, Student student)
        {
            InitializeComponent();
            this.building = building;
            this.student = student;

            RefreshData();
        }
        public void RefreshData()
        {
            ComplaintsLB.Items.Clear();
            foreach (Complaint complaint in student.house.GetComplaints())
            {
                ComplaintsLB.Items.Add(complaint);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ComplaintsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.complaintsForm = null;
            FormManager.MenuForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ViewBT_Click(object sender, EventArgs e)
        {
            Complaint selectedComplaint = (Complaint)ComplaintsLB.SelectedItem;
            if (selectedComplaint != null)
            {
                MessageBox.Show($"Title : {selectedComplaint.Title}\n\n Description : {selectedComplaint.Description}\n\n Date : {selectedComplaint.Date}");
            }
        }

        private void AddComplaintBT_Click(object sender, EventArgs e)
        {
            if(TitleRTB.Text != "" && DescriptionRTB.Text != "" && DateTB.Text != "")
            {
                Complaint complaint = new Complaint(TitleRTB.Text, DescriptionRTB.Text, DateTB.Text);
                student.house.AddComplaint(complaint);
                RefreshData();
            }
        }
    }
}
