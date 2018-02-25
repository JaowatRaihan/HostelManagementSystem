using System;
using System.Collections.Generic;

namespace HostelManagementSystem.UI.Models
{
    public abstract class Misc
    {
        public static List<string> GetMonth()
        {
            var x = new List<String>()
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            return x;
        }

        public static List<string> GetYear()
        {
            int count = 0;
            var date = DateTime.UtcNow.Year - 2;
            List<string> newdate = new List<string>();
            while (count != 5)
            {
                newdate.Add(date++.ToString());
                count++;
            }

            return newdate;
        }
    }
}
