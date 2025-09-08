using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public enum Garde
    {
        A = 1, B, C, D, F
    }

    // 1. Mapping By Convension
    /// internal class Stud_Course
    /// {
    ///     public int Stud_Id { get; set; }
    ///     public int Course_Id { get; set; }
    ///     public Garde Garde { get; set; }
    /// }

    // 2. Mapping By Annotation
    internal class Stud_Course
    {
        [Key, Column(Order = 0)]
        public int Stud_Id { get; set; }
        [Key, Column(Order = 1)]
        public int Course_Id { get; set; }
        [Column(TypeName = "varchar(10)")]
        public Garde Garde { get; set; }
    }

}
