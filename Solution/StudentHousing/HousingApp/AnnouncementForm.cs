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
    public partial class AnnouncementForm : Form
    {
        private readonly Building building;
        private Student student;
        public AnnouncementForm(Building building, Student student)
        {
            InitializeComponent();
            this.building = building;
            this.student = student;

            RefreshData();  
        }
        public void RefreshData()
        {
            AnnouncementLB.Items.Clear();
            foreach (Announcement announcement in student.house.GetAnnouncements())
            {
                AnnouncementLB.Items.Add(announcement);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void AnnouncementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.announcementForm = null;
            FormManager.MenuForm.Show();
        }

        private void ViewBT_Click(object sender, EventArgs e)
        {
            Announcement SelectedAnnouncement = (Announcement)AnnouncementLB.SelectedItem;
            if (SelectedAnnouncement != null)
            {
                MessageBox.Show($"Created by : {SelectedAnnouncement.Firstname} \n\nTitle : {SelectedAnnouncement.Title}\n\n Description : {SelectedAnnouncement.Description}\n\n Date : {SelectedAnnouncement.Date}");
            }
        }

        private void AddAnnouncement_Click(object sender, EventArgs e)
        {
            if(TitleRTB.Text != "" && DescriptionRTB.Text != "" && DateTB.Text != "")
            {
                Announcement announcement = new Announcement(TitleRTB.Text, DescriptionRTB.Text, DateTB.Text);
                announcement.Firstname = student.Firstname;
                   
                student.house.AddAnnouncement(announcement);
                RefreshData();  
            }
        }
    }
}
