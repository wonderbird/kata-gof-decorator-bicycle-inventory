using System.Globalization;

namespace kata_gof_decorator_bicycle_inventory
{
    public static class ValueConverterExtension
    {
        private static readonly CultureInfo Us = new CultureInfo("en-US");

        public static string AsUsCurrencyString(this decimal value)
        {
            var valueString = value.ToString("c", Us);
            return valueString;
        }
    }
}