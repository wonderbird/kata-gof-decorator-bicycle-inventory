using kata_gof_decorator_bicycle_inventory;
using Xunit;

namespace kata_gof_decorator_bicycle_inventory_tests
{
    public class BicycleAndDecoratorsTests
    {
        private const string SimpleBikeAsString =
            "Sum value: $900.00\n"
            + "Bike: Montague, Navigator, A12345, $900.00\n";

        private const string LightDecoratedBikeAsString =
            "Sum value: $931.99\n"
            + "Bike: Montague, Navigator, A12345, $900.00\n"
            + "Light: Cree, Multifunction, 123, $31.99, Lithium Ion, LED\n";

        [Fact]
        public void SimpleBike__DisplaysBikeValueAndProperties()
        {
            var bicycle = new Bicycle
            {
                Make = "Montague",
                Model = "Navigator",
                SerialNumber = "A12345",
                Cost = 900.0m
            };

            Assert.Equal(SimpleBikeAsString, bicycle.AsString());
        }

        [Fact]
        public void LightDecoratedBike__DisplaysSumValueAndBikeAndLightProperties()
        {
            var bicycle = new Bicycle
            {
                Make = "Montague",
                Model = "Navigator",
                SerialNumber = "A12345",
                Cost = 900.0m
            };

            bicycle = new Lights(bicycle)
            {
                Make = "Cree",
                Model = "Multifunction",
                SerialNumber = "123",
                Cost = 31.99m,
                BatteryType = "Lithium Ion",
                LightBulb = "LED",
            };

            Assert.Equal(LightDecoratedBikeAsString, bicycle.AsString());
        }
    }
}
