using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Models
{
    public class Location : Entity
    {
        [Required]
        public string Type { get; set; }
        [Required]
        public double Rating { get; set; }
        [MaxLength(7)]
        public List<OperatingHour> OparatingHours { get; set; }
        public string OpenOrClosedInfo { get; set; }
        public List<string> OperatingHoursStr { get; set; }
        public bool Open { get; set; }
        public bool ClosingSoon { get; set; }
        public bool OpeningSoon { get; set; }
    }
}