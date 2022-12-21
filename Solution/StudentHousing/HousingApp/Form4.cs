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
    public partial class Form4 : Form
    {
        private readonly Building building;
        public Form4(Building building)
        {
            InitializeComponent();
            this.building = building;
        }
         

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            Task newTask = new Task(TaskNameBox.Text, TaskDescriptionBox.Text, StartDateBox.Text, EndDateBox.Text);
            listBox2.Items.Add(newTask);
        }

        private void FinishTaskButton_Click(object sender, EventArgs e)
        {
            Task newTask = new Task(TaskNameBox.Text, TaskDescriptionBox.Text, StartDateBox.Text, EndDateBox.Text);
            newTask.TaskDone();
            listBox2.Items.Remove(listBox2.SelectedItem);
            listBox2.Items.Add("Task completed!");


        }
    }
}
