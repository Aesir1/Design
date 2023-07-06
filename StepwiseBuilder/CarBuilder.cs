namespace StepwiseBuilder;

public class CarBuilder
{
    private class Impl : ISpecifyCarType, ISpecifyWheelSize, IBuildCar
    {
        private Car car = new Car();
        public ISpecifyWheelSize OfType(CarType type)
        {
            car.Type = type;
            return this;
        }

        public IBuildCar WithWheels(int size)
        {
            switch (car.Type)
            {
                case CarType.Crossover when size < 17 || size > 20:
                case CarType.Sedan when size < 15 || size > 17:
                    throw new ArgumentException($"Wrong size of wheel for {car.Type}");
            }

            car.WheelSize = size;
            return this;
        }

        public Car Build()
        {
            Console.WriteLine($"""{nameof(car)} of type {car.Type} with {car.WheelSize}" wheel size was built.""");
            return car;
        }
    }
    public static ISpecifyCarType Create()
    {
        return new Impl();
    }
}