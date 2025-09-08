using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    // 1. mapping by Convention
    /// internal class Course_Inst
    /// {
    ///     public int Ins_Id { get; set; }
    ///     public int Course_Id { get; set; }
    ///     public int Evaluate { get; set; }
    /// }
    /// 

    // 1. Mapping by Data Annotation
    internal class Course_Inst
    {
        [Key, Column(Order = 0)]
        public int Ins_Id { get; set; }

        [Key, Column(Order = 1)]
        public int Course_Id { get; set; }
        [Range(1, 100)]
        public int Evaluate { get; set; }
    }
}
