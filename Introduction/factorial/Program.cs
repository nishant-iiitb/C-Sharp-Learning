namespace factorial
{
    /// <summary>
        /// Write a program which takes a single argument from the console, computes the factorial and prints the 
        /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        /// and display it as 5! = 120.
        /// </summary>
        
    class Program
    {
        static void Main(string[] args)
        {
            var fac = 1;
            Console.WriteLine("Enter the number");
            var input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                fac *= i;
            }
            Console.WriteLine(fac);
        }
    }
}