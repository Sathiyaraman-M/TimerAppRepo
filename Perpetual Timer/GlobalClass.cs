using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perpetual_Timer
{
    public static class GlobalClass
    {
        public static int Hours { get; set; }
        public static int Minutes { get; set; }
        public static int Seconds { get; set; }
        public static void RunTimer()
        {
            if (Seconds == 0)
            {
                if (Minutes == 0)
                {
                    Hours -= 1;
                    Minutes = 59;
                    Seconds = 59;
                }
                else
                {
                    Minutes -= 1;
                    Seconds = 59;
                }
            }
            else
            {
                Seconds -= 1;
            }

        }

        public static int GetTotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }
    }
}
