using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            CalendarDisp Ca = new CalendarDisp();
            CalendarInput CI = new CalendarInput();

            while (true)
            {
                int CIY = CI.InputY();
                int CIM = CI.InputM();
                int CID = CI.InputD();

                if (CIM == -1)
                {
                    break;
                }
                else if (CIM == 0)
                {
                    Ca.DispYearCalender(CIY, CIM);
                    break;
                }
                else
                {
                    Ca.DispCalendar(CIY, CIM);
                    break;
                }
            }
        }
    }
}
