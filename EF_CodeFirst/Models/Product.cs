using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using EF_CodeFirst.CustomValidation;

namespace EF_CodeFirst.Models
{
    public class Product
    {
        [Key]
        public long ProductID { get; set; }
        [Display(Name = "Product Name")]
        [Required(ErrorMessage ="Product Name not blank")]
        [RegularExpression(@"^[A-Za-z 0-9]*$", ErrorMessage ="You can't input the scpecial character")]
        [MinLength(2, ErrorMessage = "Min more then 2")]
        public string ProductName { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Required(ErrorMessage = "Price Name not blank")]
        [DivisibleBy100(ErrorMessage ="Price should in multiples 100.")]
        public Nullable<decimal> Price { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public Nullable<System.DateTime> DateOfPurchase { get; set; }
        public string AvailabilityStatus { get; set; }
        [Required(ErrorMessage = "CategoryID Name not blank")]
        public Nullable<long> CategoryID { get; set; }
        [Required(ErrorMessage = "BrandID Name not blank")]
        public Nullable<long> BrandID { get; set; }
        public Nullable<bool> Active { get; set; }
        public long Quantity { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
    }
}