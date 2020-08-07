using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_Core.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        [Required(ErrorMessage ="This field is required.")]
        [DisplayName("Name")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(10)")]
        [DisplayName("EmpCode")]
        public string EmpCode { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Designation { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Address")]
        public string Address { get; set; }
    }
}
