namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is your favorite Animal?");
            string favoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is the name of your favorite band?");
            string favoriteBand = Console.ReadLine();

            Console.WriteLine($"Hello {name} I hope all is well with you! I heard" +
                $" your favorite color was a {color}. I heard your favorite animal " +
                $" was {favoriteAnimal}. I also heard you listened to {favoriteBand}");



            Methods.Add(23, 66);
            Console.WriteLine(Methods.Add(23, 66));

            Console.WriteLine(Methods.Sub(23, 66));
            Console.WriteLine(Methods.Multiply(23, 66));
            Console.WriteLine(Methods.Divide(23, 66));
            Console.WriteLine(Methods.Mod(23, 66));


        }
    }
}
