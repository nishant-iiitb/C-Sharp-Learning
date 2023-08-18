namespace VowelCounter
{
    //Write a program and ask the user to enter an English word.
    //Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter an English Word");
            var input = Console.ReadLine();
            var count = 0;
            foreach (var ch in input)
            {
                if ("aeiouAEIOU".Contains(ch))
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}