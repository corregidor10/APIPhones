using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Phone : Base
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Descripton { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
