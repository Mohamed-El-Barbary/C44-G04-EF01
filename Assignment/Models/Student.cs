using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    // 1. Mapping By Convention

    ///class Student
    ///{
    ///    public int Id { get; set; }
    ///    public string FName { get; set; }
    ///    public string LName { get; set; }
    ///    public string? Address { get; set; }
    ///    public int Age { get; set; }
    ///    public Department Dept_Id { get; set; }
    ///}
    ///

    // 2. Mapping By Data Annotation
    class Student
    {
        public int Id { get; set; }
        [Column(TypeName="varchar(50)")]
        [StringLength(6,MinimumLength =3)]
        [Required]
        public string FName { get; set; }
        [Column(TypeName = "varchar(50)")]
        [StringLength(6, MinimumLength = 3)]
        public string? LName { get; set; }
        [Column(TypeName = "varchar(150)")]
        [StringLength(150, MinimumLength = 50)]
        [Required]
        public string? Address { get; set; }
        [Range(19,26)]
        [Required]
        public int Age { get; set; }
        public int? Dept_Id { get; set; }
    }
}
