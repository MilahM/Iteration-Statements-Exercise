using System.Globalization;
using System.Transactions;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000 - DONE

        //Write a method that will print to the console numbers 3 through 999 by 3 each time -DONE

        //Write a method to accept two integers as parameterss and check whether they are equal or not - DONE

        //Write a method to check whether a given number is even or odd - DONE

        //Write a method to check whether a given number is positive or negative - DONE

        //Write a method to read the age of a candidate and determine whether they can vote. - DONE
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10 - DONE

        //Write a method to display the multiplication table(from 1 to 12) of a given integer - DONE


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Numbers();
            NewNumbers();
            Integers(4, 7);
            MyBool();
            NumberSign();
            VoterAge();
            UserInteger();
            Multiply();
        }

        //Lukewarm Answers

        public static void Numbers()
        {
            int i = 1000;
            while (i >= -1000)
            {
                Console.WriteLine(i);
                i--;//only starts at -708 when you run it and goes to -1000
            }
        }

        public static void NewNumbers()
        {
            int i = 3;
            while (i <= 999)
            {
                Console.WriteLine(i += 3); //only starts at 126 and ends at 1002
            }
        }

        public static void Integers(int x, int y)
        {
            var result = (x < y) ? $"{x} is equal to {y}." : $"{x} is not equal to {y}.";
            Console.WriteLine(result);
        }

        public static void MyBool()
        {
            Console.WriteLine("Enter a number.");
            var userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput % 2 == 0)
            {
                Console.WriteLine($"{userInput} is even");
            }
            else
            {
                Console.WriteLine($"{userInput} is odd");
            }
        }
        public static void NumberSign()
        {
            Console.WriteLine("Enter a number.");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine($"{n} is a negative number.");
            }
            else
            {
                Console.WriteLine($"{n} is a positive number.");
            }
        }

        public static void VoterAge()
        {
            Console.WriteLine("Enter your age.");
            
            var isOfAge = int.TryParse(Console.ReadLine(), out int age);

            if (age >= 18)
            {
                Console.WriteLine($"You are {age} years old and you are old enough to vote.");
            }
            else
            {
                Console.WriteLine($"Sorry,you are {age} years old and you are not old enough to vote.");
            }
        }

        //Heatin Up Answers

        public static void UserInteger()
        {
            Console.WriteLine("Enter a number.");
            int x = int.Parse(Console.ReadLine());

            var userInput = (x <= 10 &&  x >= -10) ? $"{x} is between -10 and 10." : $"{x} is not between -10 and 10.";
            Console.WriteLine(userInput);
        }

        public static void Multiply()
        {
            int i; 
            int num;

            Console.WriteLine("Enter a number.");
            num = int.Parse(Console.ReadLine());

            for (i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0} X {1} = {2} \n", num, i, num * i);
            }
            
          

        }
            
  

    }
}
