using System.Globalization;

namespace kata_gof_decorator_bicycle_inventory_tests
{
    public class Bicycle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public decimal Value { get; set; }

        public string AsString()
        {
            var us = new CultureInfo("en-US");
            return "Sum value: " + Value.ToString("c", us) + "\n"
                   + $"{Make}, {Model}, {SerialNumber}, " + Value.ToString("c", us);
        }
    }
}