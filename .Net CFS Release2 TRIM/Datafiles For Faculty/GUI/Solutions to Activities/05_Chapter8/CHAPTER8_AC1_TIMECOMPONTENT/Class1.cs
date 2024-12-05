using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter8_Ac1_TimeCompontent
{
    public class TimeProvide
    {
        public TimeProvide()
        {
        }
        public string Time
        {
            get
            {
                return DateTime.Now.ToString();
            }
        }
    }

}
