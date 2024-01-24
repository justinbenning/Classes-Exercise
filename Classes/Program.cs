namespace Classes
{
    public class Program

    {
        static void Main(string[] args)
        {
            Car car1 = new Car("McLaren", "Senna", 2018);
            Console.Write($"{car1.Make}, {car1.Model}, {car1.Year}.");

        }
    }

    public class Car
    {
        
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public string Make { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }
    }
    
}


