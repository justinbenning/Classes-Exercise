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
}


