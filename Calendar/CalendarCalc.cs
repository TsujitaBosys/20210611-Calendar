using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class CalendarCalc
    {
        public int Check_uruu(int year)
        {
            if ((year % 400 == 0) || ((year % 4 == 0) && (year / 100 > 0)))
            {
                return (1);
            }
            else
            {
                return (0);

            }
        }

        public int getMaxDay(int year, int month)
        {
            int[] day_m = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (Check_uruu(year) == 1)
            {
                day_m[1]++;
            }

            return (day_m[month - 1]);
        }

        public int total_y = 0;
        public int total_m = 0;
        
        public int getTotalDay(int year, int month)
        {

            for (int i = 0; i <= (year - 1); i++)
            {
                total_y += 365 + Check_uruu(i);
            }

            for (int i = 1; i < month; i++)
            {
                total_m += getMaxDay(year, i);
            }

            int total = total_y + total_m;
            return (total);
        }
    }
}
