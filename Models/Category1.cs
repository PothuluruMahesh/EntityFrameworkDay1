using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFWExamples1.Models
{
    [Table("tblCategories1")]
    public class Category1
    {
        [Key]
        public int CategoryId { set; get; }
        public string CategoryName { set; get; }
    }
}