using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    // 1- Mapping By Convention

    /// internal class Topic
    /// {
    ///     public int Id { get; set; }
    ///     public string Name { get; set; }
    /// }
    /// 

    // 2- Mapping By Convention
    internal class Topic
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50, MinimumLength = 6)]
        public string Name { get; set; }
    }
}
