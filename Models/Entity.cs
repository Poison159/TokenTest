using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Models
{
    public class Entity
    {

        public int Id { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public double Distance { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Address { get; set; }
        public string Url { get; set; }
        public string ImgPath { get; set; }
        public double Price { get; set; }
        public List<Image> Images { get; set; }

    }
}