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
    public partial class TaskForm : Form
    {
        private readonly Building building;
        private Student student;
        public TaskForm(Building building, Student student)
        {
            InitializeComponent();
            this.building = building;
            this.student = student;

            RefreshData();
            
        }
        public void RefreshData()
        {
            TaskLB.Items.Clear();   
            foreach (Task task in student.house.GetTasks())
            {
                TaskLB.Items.Add(task);
            }
        }
       
         

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.TaskForm = null;
            FormManager.MenuForm.Show();
        }

        private void button1_Click(object sender, EventArgs e) // view button
        {
            Task selectedTask = (Task)TaskLB.SelectedItem;
            if (selectedTask != null)
            {
                MessageBox.Show($"Assigned to : {selectedTask.Assignment}\n\nTitle : {selectedTask.Title}\n\nDescription : {selectedTask.Description}\n\nDate : {selectedTask.Date}");
            }
            
        }
    }
}
