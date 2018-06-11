using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class PhoneDetail : Phone
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public string SO { get; set; }
        public decimal Scoring { get; set; }
    }
}
