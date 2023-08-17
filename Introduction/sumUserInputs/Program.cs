namespace sumUserInputs
{
    /// <summary>
    /// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
    /// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            Console.WriteLine("Enter the number or 'OK' to exit");
            while (true)
            {
                var input = Console.ReadLine();
                if (input.ToLower().Equals("ok"))
                    break;
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine(sum);
        }
    }
}