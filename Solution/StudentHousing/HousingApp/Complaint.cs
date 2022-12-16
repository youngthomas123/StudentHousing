using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingApp
{
    public class Complaint
    {
        private string complaints;
        public Complaint(string complaints)
        {
            this.complaints = complaints;
        }
        public string GetComplaints() 
        { return complaints; }
    }
}
