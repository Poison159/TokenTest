using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Models
{
    public class OperatingHour
    {
        public int Id { get; set; }
        public int entityId { get; set; }
        [Required]
        public string Day { get; set; }
        public string Occation { get; set; }
        [Required]
        [Display(Name = "Opening hour")]
        [DataType(DataType.Time)]
        public DateTime OpeningHour { get; set; }
        [Required]
        [Display(Name = "Closing hour")]
        [DataType(DataType.Time)]
        public DateTime ClosingHour { get; set; }
    }
}