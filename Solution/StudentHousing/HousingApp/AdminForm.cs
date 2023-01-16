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
    public partial class AdminForm : Form
    {
        private readonly Building building;
        private Admin admin;
        public AdminForm(Building building,Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.building = building;

            foreach(Student student in building.GetStudents())
            {
                if(student.house == admin.house)
                {
                    HouseMembersLB.Items.Add(student);  
                    RentLB.Items.Add(student); 
                    PersonCB.Items.Add(student);
                }
            }

            foreach(Complaint complaint in admin.house.GetComplaints())
            {
                ComplaintsLB.Items.Add(complaint);  
            }

            foreach(Message message in admin.GetMessage())
            {
                MessagesLB.Items.Add(message);  
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.adminForm = null;
            FormManager.loginForm.Show();
        }

        private void CreateTaskBT_Click(object sender, EventArgs e)
        {
            if(TaskTitleRTB.Text != "" &&  TaskDescriptionRTB.Text != "" && TaskForTB.Text != "" && TaskDateTB.Text != "")
            {
                Task task = new Task(TaskTitleRTB.Text, TaskDescriptionRTB.Text, TaskDateTB.Text, TaskForTB.Text);
                admin.house.AddTask(task);  
            }
        }

        private void ViewComplaintBT_Click(object sender, EventArgs e)
        {
            Complaint selectedComplaint = (Complaint)ComplaintsLB.SelectedItem;
            if(selectedComplaint != null)
            {
                MessageBox.Show($"Title : {selectedComplaint.Title}\n\n Description : {selectedComplaint.Description}\n\n Date : {selectedComplaint.Date}");
            }
        }

        private void RentLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student student = (Student)RentLB.SelectedItem;
            RentLabel.Text = Convert.ToString(student.Rent);


        }

        private void SetRentBT_Click(object sender, EventArgs e)
        {
            Student student = (Student)RentLB.SelectedItem;

            if (student != null)
            {
                try
                {
                    student.Rent = Convert.ToInt32(SetRentTB.Text);
                    RentLabel.Text = Convert.ToString(student.Rent);
                }
                catch 
                {
                    MessageBox.Show("invalid input");
                }
            }
            else
            {
                MessageBox.Show("No student selected");
            }
            
        }

        private void ViewMessageBT_Click(object sender, EventArgs e)
        {
            Message selectedMessage = (Message)MessagesLB.SelectedItem;
            if (selectedMessage != null)
            {
                MessageBox.Show($"From : {selectedMessage.From}\n\nSubject : {selectedMessage.Title}\n\n Message : {selectedMessage.Body}");
            }
        }

        private void SendMessageBT_Click(object sender, EventArgs e)
        {
            Student student = (Student)PersonCB.SelectedItem;
            if(MessageTitleRTB.Text !="" && MessageBodyRTB.Text != "" && PersonCB != null)
            {
                Message message = new Message(MessageTitleRTB.Text, MessageBodyRTB.Text, admin.Username);
                student.AddMessage(message);    
            }
        }

        private void UpdateDateBT_Click(object sender, EventArgs e)
        {
            Task selectedTask = (Task)UpdateTaskLB.SelectedItem;
            if (selectedTask != null)
            {
                selectedTask.Date = UpdateDateTB.Text;
            }
            RefreshDataInUpdateTaskLB();
        }

        private void UpdateForBT_Click(object sender, EventArgs e)
        {
            Task selectedTask = (Task)UpdateTaskLB.SelectedItem;
            if (selectedTask != null)
            {
                selectedTask.Assignment = UpdateForTB.Text;
            }
            RefreshDataInUpdateTaskLB();
        }

        private void DeleteTaskBT_Click(object sender, EventArgs e)
        {
            Task selectedTask = (Task)UpdateTaskLB.SelectedItem;
            if (selectedTask != null)
            {
                admin.house.RemoveTask(selectedTask);
                RefreshDataInUpdateTaskLB();

            }
        }

        private void SearchTaskBT_Click(object sender, EventArgs e)
        {
            if(SearchTaskTB.Text != "")
            {
                string search = SearchTaskTB.Text;

                UpdateTaskLB.Items.Clear();
                foreach(Task task in admin.house.GetTasks())
                {
                    if(task.Title.Contains(search))
                    {
                        UpdateTaskLB.Items.Add(task);
                    }
                }
            }
        }

        private void ViewUpdateTaskBT_Click(object sender, EventArgs e)
        {
            Task selectedTask = (Task)UpdateTaskLB.SelectedItem;
            if(selectedTask != null)
            {
                MessageBox.Show($"For :{selectedTask.Assignment}\n\n Title : {selectedTask.Title}\n\n Description : {selectedTask.Description}\n\n Date {selectedTask.Date}");
            }

        }

        private void ShowAllTaskBT_Click(object sender, EventArgs e)
        {
            RefreshDataInUpdateTaskLB();
        }

        private void RefreshDataInUpdateTaskLB()
        {
            UpdateTaskLB.Items.Clear();
            foreach (Task task in admin.house.GetTasks())
            {
                UpdateTaskLB.Items.Add(task);
            }
        }

        private void MessagesLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
