using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    public class Task
    {
        private string TaskName="";
        private string TaskDescription="";
        private string StartDate = "";
        private string EndDate = "";
        private bool Status;
        private List<Grocery> groceries;
        

        public Task(string TaskName, string TaskDescription, string StartDate, string EndDate, bool Status) 
        { 
            this.TaskName = TaskName;
            this.TaskDescription = TaskDescription;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Status = Status;
            this.groceries = new List<Grocery>();
        }

        public void AddGrocery(string name, double price)
        {
            Grocery NewGrocery = new Grocery(name, price);
            this.groceries.Add(NewGrocery);   
        }
        public List<Grocery> GetGrocery()
        {
            return this.groceries;
        }
        public string GetTaskName() 
        { return this.TaskName; }

        public string GetTaskDescription() 
        { return this.TaskDescription; }

        public string GetStartDate() 
        { return this.StartDate; }

        public string GetEndDate() 
        { return this.EndDate; }

        public bool GetStatus() 
        { return this.Status;}

        
    }
}
