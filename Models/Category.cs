using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindExercise.Models
{
    public partial class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}