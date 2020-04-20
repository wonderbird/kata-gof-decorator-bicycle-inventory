using Xunit;

namespace kata_gof_decorator_bicycle_inventory_tests
{
    public class BicycleAndDecoratorsTests
    {
        private const string SimpleBikeAsString = "Sum value: $900.00\n"
                                                  + "Montague, Navigator, A12345, $900.00";

        [Fact]
        public void SimpleBike__DisplaysBikeValueAndProperties()
        {
            var bicycle = new Bicycle
            {
                Make = "Montague",
                Model = "Navigator",
                SerialNumber = "A12345",
                Value = 900.0m
            };

            Assert.Equal(SimpleBikeAsString, bicycle.AsString());
        }
    }
}
