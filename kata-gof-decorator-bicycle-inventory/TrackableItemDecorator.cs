namespace kata_gof_decorator_bicycle_inventory
{
    public abstract class TrackableItemDecorator : TrackableItem
    {
        private readonly TrackableItem _bicycle;

        public TrackableItemDecorator(TrackableItem bicycle)
        {
            _bicycle = bicycle;
        }

        public override string Description()
        {
            return _bicycle.Description()
                   + ItemDescription();
        }

        protected abstract string ItemDescription();

        public override decimal Value()
        {
            return _bicycle.Value() + Cost;
        }
    }
}