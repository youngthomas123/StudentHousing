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
    public partial class ProfileForm : Form
    {
        private readonly Building building;
        private Student student;
        public ProfileForm(Building building, Student student)
        {
            InitializeComponent();
            this.building = building;
            this.student = student;

            NameLabel.Text = $"{student.Firstname} {student.Lastname}";
            UsernameLabel.Text = student.Username;
            PasswordLabel.Text = student.Password;
            HouseLabel.Text = $"House {student.house.Housenumber}";

            foreach (Admin admin in building.GetAdmins())
            {
                if(admin.house.Housenumber == student.house.Housenumber)
                {
                    AdminLabel.Text = admin.Username;
                    break;
                }
            }
            foreach(Student Allstudents in building.GetStudents())
            {
                if(Allstudents.house.Housenumber == student.house.Housenumber)
                {
                    RoomatesLB.Items.Add(Allstudents);
                }
            }

            foreach(Message message in student.GetMessages())
            {
                listBox1.Items.Add(message);
            }
        }

        private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.profileForm = null;
            FormManager.MenuForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void SendMessageBT_Click(object sender, EventArgs e)  // for now it is ok
        {
            if(textBox1.Text != "" && richTextBox1.Text !="" )
            {
                Message message = new Message(textBox1.Text, richTextBox1.Text, student.Firstname);
                foreach(Admin admin in building.GetAdmins())
                {
                    if(admin.house == student.house)
                    {
                        admin.AddMessage(message);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Message selectedMessage = (Message)listBox1.SelectedItem;
            if(selectedMessage != null)
            {
                MessageBox.Show($"From : {selectedMessage.From}\n\n Subject : {selectedMessage.Title}\n\n Message : {selectedMessage.Body}");
            }
        }
    }
}
