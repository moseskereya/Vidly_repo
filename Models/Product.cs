using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Maker { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
