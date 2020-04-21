namespace kata_gof_decorator_bicycle_inventory
{
    public class Brake : TrackableItemDecorator
    {
        public Brake(TrackableItem bicycle) : base(bicycle)
        {
        }

        protected override string ItemDescription()
        {
            return $"Brake: {Make}, {Model}, {SerialNumber}, {Cost.AsUsCurrencyString()}\n";
        }
    }
}