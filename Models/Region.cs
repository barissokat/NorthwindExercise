using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindExercise.Models
{
    public partial class Region
    {
        public Region()
        {
            this.Territories = new HashSet<Territory>();
        }

        public int RegionID { get; set; }
        public string RegionDescription { get; set; }

        public virtual ICollection<Territory> Territories { get; set; }
    }
}