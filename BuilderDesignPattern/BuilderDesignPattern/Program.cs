namespace designpatterns.builderdesignpattern
{
    public class Car
    {
        public string Make { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }
    }

    public interface ICarBuilder
    {
        public CarBuilder SetMake(string make);
        public CarBuilder SetColor(string color);
        public CarBuilder SetModel(string model);
        public CarBuilder SetYear(int year);
        public Car Build();
    }


    public class CarBuilder : ICarBuilder 
    {
        private Car _car = new Car();
        public CarBuilder SetMake(string Make) { 
            _car.Make = Make;
            return this;
        }

        public CarBuilder SetColor(string color) {
            _car.Color = color;
            return this;
        }

        public CarBuilder SetModel(string model) {
            _car.Model = model;
            return this;
        }

        public CarBuilder SetYear(int year) {
            _car.Year = year;
            return this;
        }

        public Car Build() {
            return _car;
        }
    }

    public class CarDirector
    {
        private readonly ICarBuilder carBuilder;

        public CarDirector(ICarBuilder carBuilder) { 
            this.carBuilder = carBuilder;
        }

        public Car ConstructSportsCar() {
            Car car = carBuilder.SetMake("Ferrari")
                                .SetModel("MG T20")
                                .SetYear(2012)
                                .SetColor("red")
                                .Build();
            return car;
        }

        public Car ConstructFamilyCar()
        {
            return carBuilder
                  .SetMake("Toyota")
                  .SetYear(2020)
                  .SetColor("white")
                  .SetModel("Model 2020")
                  .Build();
            
        }

    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            CarDirector carDirector = new CarDirector(new CarBuilder());
            Car car = carDirector.ConstructSportsCar();

            Car ar = carDirector.ConstructFamilyCar();
        }
    }
}
