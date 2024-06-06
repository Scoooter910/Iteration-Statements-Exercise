namespace IterationStatements
{
    public class Program
    {

        static void Main(string[] args)
        {
            CountDown();
            Console.WriteLine("Second Method \n");
            CountByThree();
            Console.WriteLine(IsEqualOrNot(6, 6));
            Console.WriteLine(EvenOrOdd(6));
            Console.WriteLine(PositiveOrNegative(8));
            Console.WriteLine(CanVote());
            Console.WriteLine(ValueCheck());
            TimesTables();
        }
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void CountDown()
        {

            for (int i = 1000; i >= -1000; i--)
                Console.WriteLine(i);
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void CountByThree()
        {
            for (int i = 3; i <= 999; i += 3)
                Console.WriteLine(i);
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool IsEqualOrNot(int num1, int num2)
        {

            bool result = (num1 == num2) ? true : false;
            return result;
        }
        //Write a method to check whether a given number is even or odd
        public static string EvenOrOdd(int number)
        {
            string result = (number % 2 == 0) ? "Even" : "Odd";
            return result;
        }

        //Write a method to check whether a given number is positive or negative
        public static string PositiveOrNegative(int number)
        {
            string result = (number > 0) ? "Positive" : "Negative";
            return result;
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static string CanVote()
        {

            int userInput = int.Parse(UserInput("Enter Your Age"));
            string result = (userInput >= 18) ? "CanVote" : "CannotVote";
            return result;

        }
        public static string UserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static string ValueCheck()
        {

            int userInput = int.Parse(UserInput("Enter A Number"));
            string result = (userInput >= -10 && userInput <= 10) ? $"{userInput} is in the range" : $"{userInput} is not in the range";
            return result;
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void TimesTables()
        {

            int userInput = int.Parse(UserInput("Enter A Number"));


            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{UserInput} X {i} = {userInput * i}");
            }
            //Call the methods to test them in the Main method below
        }
    }
}
