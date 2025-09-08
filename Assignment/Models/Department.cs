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

    /// internal class Department
    /// {
    ///     public int Id { get; set; }
    ///     public string Name { get; set; }
    ///     public DateOnly HirinDate { get; set; }
    ///     public int Ins_Id { get; set; }
    /// }
    /// }

    // 2. Mapping By Data Annotation

    internal class Department
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="varchar(20)")]
        [StringLength(20,MinimumLength = 2)]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateOnly HirinDate { get; set; }
        public int? Ins_Id { get; set; }
    }
}
