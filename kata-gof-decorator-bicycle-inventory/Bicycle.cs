namespace kata_gof_decorator_bicycle_inventory
{
    public class Bicycle : TrackableItem
    {
        public override string Description()
        {
            return $"Bike: {Make}, {Model}, {SerialNumber}, {Cost.AsUsCurrencyString()}\n";
        }

        public override decimal Value()
        {
            return Cost;
        }
    }
}