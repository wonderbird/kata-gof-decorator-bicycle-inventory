using kata_gof_decorator_bicycle_inventory;

namespace kata_gof_decorator_bicycle_inventory_tests
{
    public class Lights : Bicycle
    {
        private readonly Bicycle _bicycle;

        public string BatteryType { get; set; }
        public string LightBulb { get; set; }

        public Lights(Bicycle bicycle)
        {
            _bicycle = bicycle;
        }

        public override string AsString()
        {
            var valueString = AsCurrencyString();

            var accessory = $"Light: {Make}, {Model}, {SerialNumber}, {valueString}, {BatteryType}, {LightBulb}";

            return _bicycle.AsString()
                   + "\n" + accessory;
        }

        private string AsCurrencyString()
        {
            var valueString = Value.AsUsCurrencyString();
            return valueString;
        }
    }
}