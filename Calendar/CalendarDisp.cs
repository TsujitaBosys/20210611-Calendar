using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class CalendarDisp
    {
        public void dispCalenderForm(int year, int month)
        {

            CalendarCalc CC = new CalendarCalc();

            int gTD = CC.getTotalDay(year, month);
            int gMD = CC.getMaxDay(year, month);

            string[] week = { "日", "月", "火", "水", "木", "金", "土" };

            //一週間曜日表示
            for (int w = 0; w < 7; w++)
            {
                Console.Write("{0} ", week[w]);
            }
            Console.WriteLine();

            //１日を正しく表示するためのスペース表示
            for (int s = 0; s < (gTD % 7) + 1; s++)
            {
                Console.Write("   ");
            }

            if (((gTD % 7) + 1) == 7)	/*スペースが７個なら改行*/
            {
                Console.WriteLine();
            }


            //日付の表示
            for (int d = 1; d <= gMD; d++)
            {
                Console.Write("{0,2:d} ", d);

                if (((gTD + d) % 7) == 6)	/*土曜日で改行*/
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        public void DispCalendar(int year, int month)
        {
            Console.WriteLine("{0}年{1}月", year, month);
            dispCalenderForm(year, month);
        }

        public void DispYearCalender(int year, int month)
        {
            for (int i  = 1; i <= 12; i++ )
            {
                //n年n月のカレンダーか
                Console.WriteLine("{0}年{1}月", year, i);

                //カレンダー表示
                dispCalenderForm(year, i);

                Console.WriteLine();
            }
        }
    }
}
