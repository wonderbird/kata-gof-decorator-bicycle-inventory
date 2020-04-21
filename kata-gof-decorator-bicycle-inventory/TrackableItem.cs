namespace kata_gof_decorator_bicycle_inventory
{
    public abstract class TrackableItem
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public decimal Cost { get; set; }

        public string AsString()
        {
            return $"Sum value: {ValueConverterExtension.AsUsCurrencyString(Value())}\n"
                   + Description();
        }

        public abstract string Description();
        protected abstract decimal Value();
    }
}