using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebApi.Models
{
    public class History
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public double Value1 { get; set; }
        [Required]
        public short Operator { get; set; }
        [Required]
        public double Value2 { get; set; }
        [Required]
        public double Result { get; set; }
    }
}
