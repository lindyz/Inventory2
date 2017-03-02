using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Inventory2.Models
{
    public class Category
    {
        [ScaffoldColumn(false)] //data annotation. describes how to validate user input for this member, to specify formatting for it, and to specify how it is modeled when the database is created//
        public int CategoryID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Product Description")]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}