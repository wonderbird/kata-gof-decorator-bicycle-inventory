namespace kata_gof_decorator_bicycle_inventory
{
    public class Bicycle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public decimal Value { get; set; }

        public virtual string AsString()
        {
            return SumValueUsCurrencyString()
                   + TrackableItemDescription();
        }

        public virtual string TrackableItemDescription()
        {
            return $"Bike: {Make}, {Model}, {SerialNumber}, {Value.AsUsCurrencyString()}\n";
        }

        protected virtual string SumValueUsCurrencyString()
        {
            return $"Sum value: {Value.AsUsCurrencyString()}\n";
        }
    }
}