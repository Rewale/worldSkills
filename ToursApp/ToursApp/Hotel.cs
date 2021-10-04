using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace ToursApp
{
    public class Hotel
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountOfStars { get; set; }
        public string CountryName { get; set; }
        public string HotelImage { get; set; }

        //public ImageSource Photo
        //{
        //    get
        //    {
        //        return ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(HotelImage)));
        //    }
        //}
        public ImageSource photo
        {
            get
            {
                return ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(HotelImage)));
            }
        }
        
    }
}
