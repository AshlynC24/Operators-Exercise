namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise One-------
            int num1 = 1;
            int num2 = 2;
            int addition = num1 + num2;
            Console.WriteLine(addition);// writing addition 1+2= 3 

            int Subtraction = num2 - num1;
            Console.WriteLine(Subtraction);// showing subtraction 2-1= 1 

            int Multiplication = (num1 * num2);
            Console.WriteLine(Multiplication);//showing multiplication of 1x2 = 2

            int Division = num2 / num1;
            Console.WriteLine(Division);// dividing 2/1= 2 

            int Modulus = num2 % num1;
            Console.WriteLine(Modulus);// remainder of 2/1= 0 

            int a = 17;// these are my two variables for division 
            int b = 4;

            int quotient = a / b;

            int remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine("Please enter the radius for your circle:");
            var UserInput = Console.ReadLine();// this line takes the input and stores it in UserInput

            var radius = double.Parse(UserInput);// has to be in the main method to call the other
            //method below

            //now call the method
            AreaOfACircle(radius);

            // write out what the input made you print out
            Console.WriteLine($"The area of {radius} size circle is {AreaOfACircle(radius)}");

        }

        // Exercise 2----
        // Define the method- AreaOfACircle
        public static double AreaOfACircle(double radius)
        {
            // this is the scope
            var area = Math.PI * Math.Pow(radius, 2);
            return area;


        }
    }
}
