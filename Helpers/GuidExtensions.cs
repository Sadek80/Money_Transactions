using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Money_Transaction.Helpers
{
    public static class GuidExtensions
    {
        public static string GetGuidFormatted(this Guid guid)
        {
            return "#"+guid.ToString("D").Substring(0, 6);
        }
    }
}
