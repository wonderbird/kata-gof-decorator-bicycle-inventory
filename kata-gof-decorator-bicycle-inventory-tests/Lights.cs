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
            return SumValueUsCurrencyString()
                   + _bicycle.TrackableItemDescription()
                   + TrackableItemDescription();
        }

        public override string TrackableItemDescription()
        {
            return $"Light: {Make}, {Model}, {SerialNumber}, {Value.AsUsCurrencyString()}, {BatteryType}, {LightBulb}\n";
        }

        protected override string SumValueUsCurrencyString()
        {
            return $"Sum value: {(_bicycle.Value + Value).AsUsCurrencyString()}\n";
        }
    }
}