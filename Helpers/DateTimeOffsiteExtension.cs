using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Money_Transaction.Helpers
{
    public static class DateTimeOffsiteExtension
    {
        public static string GetDateFormatted(this DateTimeOffset dateTimeOffset)
        {
            return dateTimeOffset.ToString("MMM dd, yyyy");
        }

        public static string GetDateFormattedWithTime(this DateTimeOffset dateTimeOffset)
        {
            return dateTimeOffset.ToString("MMM dd, yyyy 'at' h:mm tt");
        }
    }
}
