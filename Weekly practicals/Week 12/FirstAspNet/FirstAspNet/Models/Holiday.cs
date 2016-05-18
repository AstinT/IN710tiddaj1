using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace FirstAspNet.Models
{
    public class Holiday
    {
        //Properties
        public String holidayName { get; set; }
        public DateTime holidayDate { get; set; }
        public String imageUrl { get; set; }
        public double daysToHoliday { get; set; }

        //Constructor
        public Holiday(String holidayName, DateTime holidayDate, String imageUrl)
        {
            this.holidayName = holidayName;
            this.holidayDate = holidayDate;
            this.imageUrl = imageUrl;

            daysToHoliday = 0;
        }
    }
}