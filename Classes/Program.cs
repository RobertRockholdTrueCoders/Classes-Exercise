namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var chevrolet = new Car();
            
            chevrolet.Make = "Chevrolet";
            chevrolet.Model = "Chevelle";
            chevrolet.Year = 1970;
            
            Console.WriteLine($"A great classic muscle car is the {chevrolet.Year} {chevrolet.Make} {chevrolet.Model}.");
        }
    }
}
