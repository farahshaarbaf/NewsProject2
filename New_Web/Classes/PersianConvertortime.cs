using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace New_Web
{
    public static class PersianConvertortime
    {
        public static string Toshort(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetHour(value).ToString("00") + ":" + pc.GetMinute(value).ToString("00") + ":" +
                   pc.GetSecond(value).ToString("00");
        }
    }
}