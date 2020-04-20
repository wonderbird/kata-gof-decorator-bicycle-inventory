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
            var valueString = Value.AsUsCurrencyString();
            return $"Sum value: {valueString}\n"
                   + $"Bike: {Make}, {Model}, {SerialNumber}, {valueString}";
        }
    }
}