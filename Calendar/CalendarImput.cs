using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class CalendarInput
    {
        public int year;
        public int month;
        public int day;
        
        public int InputY()
        {
            Console.Write("西暦を入力してください : ");
            year = int.Parse(Console.ReadLine());
            return (year);
        }

        public int InputM()
        {
            Console.Write("月を入力してください : ");
            month = int.Parse(Console.ReadLine());
            return (month);
        }

        public int InputD()
        {
            CalendarCalc CC = new CalendarCalc();
            int gMD = CC.getMaxDay(year, month);

            if( true )
            {
                do{
                    Console.Write("日を入力してください : ");
                    day = int.Parse(Console.ReadLine());                    
                    }
                while ( day < -1 || day > gMD);
             }
            return (day);
        }

    }
}
