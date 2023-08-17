namespace findingDistinct
{
    //Write a program and ask the user to continuously enter a number or type "Quit" to exit.
    //The list of numbers may include duplicates.
    //Display the unique numbers that the user has entered.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers and press Enter. Type 'Quit' to Exit");
            var numbers = new List<int>();
            while(true)
            {
                var input = Console.ReadLine();
                if (input == "Quit")
                {
                    break;
                }
                else
                {
                    int inp = int.Parse(input);
                    if (numbers.Contains(inp))
                        continue;
                    else
                        numbers.Add(inp);
                }
            }

            foreach (var number in numbers)
                Console.WriteLine(number);

        }
    }
}