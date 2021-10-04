using System;
using System.Collections.Generic;
using System.Text;

namespace ToursApp
{
    public class HotelComment
    {     

        public int id { get; set; }
        public int HotelId { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public DateTime CreationDate { get; set; }
        

    }
}
