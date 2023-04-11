namespace MethodsExercise
{
    class Program
    {
        public static int Sum(int num1, int num2)
        { 
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Add(int num1, int num2, int num3, int num4, int num5)
        {
            return num1 + num2 + num3 + num4 + num5;
        }

        static void Main(string[] args)
        {

            var amountOfCars = Sum(2, 6);
            var something = Multiply(60, 2, 4);
            var blah = Divide(720, 12);
            var result = Subtract(70, 33);
            var whatever = Add(7, 4, 21, 87, 90);

            Console.WriteLine("Hey there! Can I get your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Well hello {userName}! Tell me, what color is your favorite?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is one of my favorites! And what about your favorite animal, {userName}?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Woah! A {color} {animal} sounds wild! One last question {userName}; What band is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks for all the info {userName}! It was nice to get to know you!");
            Console.WriteLine($"I hope your {color} {animal} joins you for the {band} show!");
        }
    }
}
