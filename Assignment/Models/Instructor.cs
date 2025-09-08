using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{

    // 1.Mapping By Convention

    /// internal class Instructor
    /// {
    ///     public int Id { get; set; }
    ///     public string Name { get; set; }
    ///     public int Bonus { get; set; }
    ///     public decimal Salary { get; set; }
    ///     public string Address { get; set; }
    ///     public decimal HourRate { get; set; }
    ///     public int Dept_Id { get; set; }
    /// }
    
    // 2.Mapping By Data Annotation
    internal class Instructor
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50, MinimumLength = 6)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public decimal Bonus { get; set; }
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(150, MinimumLength = 20)]
        public string? Address { get; set; }
        public decimal HourRate { get; set; }
        public int? Dept_Id { get; set; }
    }

}
