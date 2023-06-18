using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Models
{
    public class Image
    {
        public int Id { get; set; }
        public int entityId { get; set; }
        public string ImgPath { get; set; }
        public string EventName { get; set; }
    }
}