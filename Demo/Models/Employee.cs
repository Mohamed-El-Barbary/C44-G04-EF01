using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    // Mapping Ways
    // 1. Mapping By Conventions
    // 2. Mapping By Annotations

    // 1. Mapping By Conventions

    ///public class Employee
    ///{
    ///    public int ID { get; set; } // Id , EmployeeId => Primary Key , Identity(1,1)
    ///    public string Name { get; set; } // nvarchar(max)
    ///}
    ///

    public enum Grade
    {
        A = 1, B, C, D, F
    }

    // 2. Mapping By Annotations
    [Table("EmployeeTable")]
    public class Employee
    {
        public int ID { get; set; } // Id , EmployeeId => Primary Key , Identity(1,1)
        [Column(TypeName ="varchar")]
        [MaxLength(10)]
        [MinLength(5)]
        [StringLength(50, MinimumLength = 15, ErrorMessage ="Error")]
        [Length(10,20)]
        public string? Name { get; set; }
        [Required]
        [DefaultValue(5000)]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Range(21,35)]
        [AllowedValues(25,26,27)]
        [DeniedValues(36,37,38)]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [NotMapped] // Don't be a column in DB
        public int Test { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public Grade Grade { get; set; }
        [Required]
        [Length(50,150)]
        public string? Address { get; set; }

    }
}
