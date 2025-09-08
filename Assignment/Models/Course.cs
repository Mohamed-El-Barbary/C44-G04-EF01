using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

    /// internal class Course
    /// {
    ///     public int Id { get; set; }
    ///     public int Duration { get; set; }
    ///     public string Name { get; set; }
    ///     public int Top_Id { get; set; }
    /// }
    /// 

    // 2. Mapping By Data Annotation
    [Table("Course")]
    internal class Course
    {
        public int Id { get; set; }

        [DataType(DataType.Duration)]
        public TimeSpan Duration { get; set; }

        [Column(TypeName = "varchar(20)")]
        [StringLength(20, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }

        public int? Top_Id { get; set; }
    }
}
