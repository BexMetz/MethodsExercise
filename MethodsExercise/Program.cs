namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there! Can I get your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Well hello {userName}! Tell me, what color is your favorite?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is one of my favorites! And what about your favorite animal, {userName}?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Woah! A {color} {animal} sounds wild! One last question {userName}; What band is your favorite band?");
            var band = Console.ReadLine();

        }
    }
}
