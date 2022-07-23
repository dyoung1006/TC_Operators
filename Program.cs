namespace Operators
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Wee be doing some math\n");
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);
            int a = 17;
            int b = 4;

            var o = new Operators();
            o.RunTheseNumbers(a, b, radius);
            o.DisplayResults(a, b, radius);
        }
    }

    public class Operators
    {
        int resultAdd;
        int resultSubtraction;
        int resultMultiply;
        int quotient;  //result of division
        int remainder; //modulus
        double radius;
        public static int Add(int num1, int numb2)
        {
            return num1 + numb2;
        }

        public static int Subtraction(int num1, int num2)
        {
            return num1 - num2;

        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int numb2)
        {
            return num1 / numb2;
        }

        public static int Modulus(int num1, int numb2)
        {
            return num1 % numb2;
        }

        public static double AreaOfCircle(double num)
        {
            return Math.PI * Math.Pow(num,2);
        }
        public void RunTheseNumbers(int num1, int num2, double num3)
        {
            resultAdd = Add(num1, num2);
            resultSubtraction = Subtraction(num1, num2);
            resultMultiply = Multiply(num1, num2);
            quotient = Divide(num1, num2);
            remainder = Modulus(num1, num2);
            radius = AreaOfCircle(num3);

        }

        public void DisplayResults(int num1, int num2, double num3)
        {
            Console.WriteLine("Hello, here is the ouput:");
            Console.WriteLine($"Addition: \n {num1} + {num2} = {resultAdd}\n ");
            Console.WriteLine($"Subtraction: \n {num1} - {num2} = {resultSubtraction}\n ");
            Console.WriteLine($"Multiplication: \n {num1} * {num2} = {resultMultiply}\n ");
            Console.WriteLine($"Division: \n {num1} / {num2} = {quotient}\n ");
            Console.WriteLine($"Modulus (remainder) \n {num1} % {num2} = {remainder}\n");
            Console.WriteLine($"The area of a circle with a radius of {num3} is {radius}\n");
        }
    }
}