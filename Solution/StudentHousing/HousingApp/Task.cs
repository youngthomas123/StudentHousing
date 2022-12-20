using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    public class Task
    {
        private string TaskName;
        private string TaskDescription;
        private string StartDate;
        private string EndDate;
        private bool Status;
        private List<Grocery> groceries;
        

        public Task(string TaskName, string TaskDescription, string StartDate, string EndDate) 
        { 
            this.TaskName = TaskName;
            this.TaskDescription = TaskDescription;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
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
        public bool TaskDone()
        {
            this.Status = true;
            return this.Status;
        }
        public override string ToString()
        {
            return $"{this.TaskName}: ({this.TaskDescription})  Starts at: ({this.StartDate})  Ends at: ({this.EndDate})";
        }
    }
}
