using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpanseManager.Extensions
{
    public static class DateExtension
    {
        public static DateTime CreateDate(this DateTime source, int year, int month, int day)
        {
            return new DateTime(year, month, day);
        }
    }
}
