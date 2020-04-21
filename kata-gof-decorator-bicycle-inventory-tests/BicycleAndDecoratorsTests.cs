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

        private const string BrakeDecoratedBikeAsString =
            "Sum value: $950.00\n"
            + "Bike: Montague, Navigator, A12345, $900.00\n"
            + "Brake: Shimano, Center pull, 123A456B, $50.00\n";

        [Fact]
        public void SimpleBike__DisplaysBikeValueAndProperties()
        {
            var bicycle = CreateBike();

            Assert.Equal(SimpleBikeAsString, bicycle.AsString());
        }

        [Fact]
        public void LightDecoratedBike__DisplaysSumValueAndBikeAndLightProperties()
        {
            var bicycle = CreateBike();

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
        
        [Fact]
        public void BrakeDecoratedBike__DisplaysSumValueAndBikeAndBrakeProperties()
        {
            var bicycle = CreateBike();

            bicycle = new Brake(bicycle)
            {
                Make = "Shimano",
                Model = "Center pull",
                SerialNumber = "123A456B",
                Cost = 50.00m
            };

            Assert.Equal(BrakeDecoratedBikeAsString, bicycle.AsString());
        }

        private static TrackableItem CreateBike()
        {
            return new Bicycle
            {
                Make = "Montague",
                Model = "Navigator",
                SerialNumber = "A12345",
                Cost = 900.0m
            };
        }
    }
}
