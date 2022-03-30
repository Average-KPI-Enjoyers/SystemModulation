using System.Globalization;

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