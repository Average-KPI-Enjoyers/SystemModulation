using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace RandomNumberGenerator.Implementation
{
    public static class DoubleToStringListConverter
    {
        public static IEnumerable<string> Convert(IEnumerable<double> list)
        {
            return list.Select(d => d.ToString(CultureInfo.CurrentCulture)).ToList();
        }
    }
}