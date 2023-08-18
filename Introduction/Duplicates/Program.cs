namespace Duplicates
{
    internal class Program
    {
        //Write a program and ask the user to enter a few numbers separated by a hyphen. 
        //If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. 
        //If so, display "Duplicate" on the console.

        static void Main()
        {
            Console.WriteLine("Enter few numbers seperated by hypen");
            var input = Console.ReadLine();
            if (!(String.IsNullOrWhiteSpace(input)))
            {
                var inpArray = input.Split('-');
                //var intArray = Array.ConvertAll(inpArray, int.Parse);
                for (var i = 0; i < inpArray.Length; i++)
                {
                    if (Array.IndexOf(inpArray, inpArray[i]) != Array.LastIndexOf(inpArray, inpArray[i]))
                    {
                        Console.WriteLine("Duplicate");
                        break;
                    }
                }
            }
        }
    }
}