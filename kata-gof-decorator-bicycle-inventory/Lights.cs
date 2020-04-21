namespace kata_gof_decorator_bicycle_inventory
{
    public class Lights : TrackableItemDecorator
    {
        public string BatteryType { get; set; }
        public string LightBulb { get; set; }

        public Lights(TrackableItem bicycle) : base(bicycle)
        {
        }

        protected override string ItemDescription()
        {
            return $"Light: {Make}, {Model}, {SerialNumber}, {Cost.AsUsCurrencyString()}, {BatteryType}, {LightBulb}\n";
        }
    }
}