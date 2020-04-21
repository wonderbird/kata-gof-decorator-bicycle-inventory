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

        public override string Description()
        {
            return _bicycle.Description()
                    + $"Light: {Make}, {Model}, {SerialNumber}, {Cost.AsUsCurrencyString()}, {BatteryType}, {LightBulb}\n";
        }

        protected override decimal Value()
        {
            return _bicycle.Cost + Cost;
        }
    }
}