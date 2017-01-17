using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindExercise.Models
{
    public partial class Territory
    {
        public Territory()
        {
            this.Employees = new HashSet<Employee>();
        }

        public string TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }

        public virtual Region Region { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}