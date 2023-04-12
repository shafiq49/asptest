using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class function
    {
        public class YearsMonths
        {
            public int Years;
            public int TotalMonths;
            public int Months;
        }

        public static YearsMonths YearMonthDiff(DateTime startDate, DateTime endDate)
        {
            // Simply subtracting Month won't work as Jan 2014 will be less than Dec 2013.
            // So first multiply the month with year to get absolute month
            int monthDiff = ((endDate.Year * 12) + endDate.Month) - ((startDate.Year * 12) + startDate.Month) ;
            int years = (int)Math.Floor((decimal)(monthDiff / 12));
            int months = monthDiff % 12;
            return new YearsMonths
            {
                TotalMonths = monthDiff,
                Years = years,
                Months = months
            };
        }


        public DateTime Make_DateSQL(string str)
        {
            DateTime ExpDt;
            int d1, m1, y1; String d11, m11, y11;
            d1 = 0; m1 = 0; y1 = 0;
            d11 = ""; m11 = ""; y11 = "";

            d1 = Convert.ToDateTime(str).Day;
            m1 = Convert.ToDateTime(str).Month;
            y1 = Convert.ToDateTime(str).Year;

            if (d1.ToString().Length == 1)
            {
                d11 = "0" + d1.ToString();
            }
            else
            {
                d11 = d1.ToString();
            }
            if (m1.ToString().Length == 1)
            {
                m11 = "0" + m1.ToString();
            }
            else
            {
                m11 = m1.ToString();
            }

            y11 = y1.ToString();

            DateTime dt3 = new DateTime(Convert.ToInt32(y11), Convert.ToInt32(m11), Convert.ToInt32(d11), 00, 00, 00);
            ExpDt = Convert.ToDateTime(y11 + "-" + m11 + "-" + d11 + " 00:00:00");

            string a = ExpDt.ToString("hh:mm:ss tt");
            return ExpDt;
        }

    }

   

}