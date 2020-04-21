using kata_gof_decorator_bicycle_inventory;

namespace kata_gof_decorator_bicycle_inventory_tests
{
    public class Brake : Bicycle
    {
        private Bicycle _bicycle;

        public Brake(Bicycle bicycle)
        {
            _bicycle = bicycle;
        }

        public override string Description()
        {
            return _bicycle.Description()
                   + $"Brake: {Make}, {Model}, {SerialNumber}, {Cost.AsUsCurrencyString()}\n";
        }

        protected override decimal Value()
        {
            return _bicycle.Cost + Cost;
        }
    }
}