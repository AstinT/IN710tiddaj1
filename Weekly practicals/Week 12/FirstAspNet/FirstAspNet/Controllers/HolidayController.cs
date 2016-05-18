using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Using models
using FirstAspNet.Models;
using System.Drawing;

namespace FirstAspNet.Controllers
{
    public class HolidayController : Controller
    {
        //Constants
        //Image urls
        private const String QUEEN_URL = "http://www.stuff.co.nz/content/dam/images/1/4/o/3/l/w/image.related.StuffPortrait.238x286.1531fq.png/1441742130233.jpg";
        private const String HALLOWEEN_URL = "http://dentalpatientnews.com/wp-content/uploads/2011/10/halloween_braces.jpg";
        private const String BOXING_DAY_URL = "http://public.tailbase.com/521/Boxing%20Day%20Domo%20Prestige%20FACEBOOK2.jpg";

        //Fields
        private List<Holiday> holidayList;

        //
        // GET: /Holiday/
        public ActionResult Index()
        {
            //New Holiday list
            holidayList = new List<Holiday>();
            
            AddAllHolidays();

            //New random instance
            Random rand = new Random();
            //Generate random number
            int randNum = rand.Next(holidayList.Count);

            //Use random number as index for holidayList
            Holiday randHoliday = holidayList[randNum];

            //Calculates Days to holiday
            randHoliday.daysToHoliday = getDaysToHoliday(randHoliday.holidayDate);

            //Return the view with an instance of Holiday
            return View(randHoliday);
        }

        //Adds all holidays to holidays list
        public void AddAllHolidays()
        {
            holidayList.Add(new Holiday("Queen's Birthday", new DateTime(2016, 06, 06), QUEEN_URL));
            holidayList.Add(new Holiday("Halloween", new DateTime(2016, 10, 31), HALLOWEEN_URL));
            holidayList.Add(new Holiday("Boxing Day", new DateTime(2016, 12, 26), BOXING_DAY_URL));
        }

        //Returns the amount of days till the passed in holidayDate
        public double getDaysToHoliday(DateTime holidayDate)
        {
            DateTime startDate = DateTime.Now;

            TimeSpan t = holidayDate - startDate;

            return (int)t.TotalDays;
        }
	}
}