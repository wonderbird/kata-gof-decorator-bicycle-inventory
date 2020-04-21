namespace kata_gof_decorator_bicycle_inventory
{
    public class Bicycle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public decimal Cost { get; set; }

        public string AsString()
        {
            return $"Sum value: {Value().AsUsCurrencyString()}\n"
                   + Description();
        }

        public virtual string Description()
        {
            return $"Bike: {Make}, {Model}, {SerialNumber}, {Cost.AsUsCurrencyString()}\n";
        }

        protected virtual decimal Value()
        {
            return Cost;
        }
    }
}