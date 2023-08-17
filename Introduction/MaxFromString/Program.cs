namespace MaxFromString
{
    //Write a program and ask the user to enter a series of numbers separated by comma.
    //Find the maximum of the numbers and display it on the console.
    //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
    class Program
    {
        static void Main(string[] args)
        {

            int maximum = -999;
            Console.WriteLine("Enter Series of Numbers seperated by comma");
            var input = Console.ReadLine();
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == ',' || input[i] == ' ')
                    continue;
                else
                {

                    var number = (int)char.GetNumericValue(input[i]);
                    // Console.WriteLine("{0}\t{1}\t{2}",input[i],number, maximum);
                    if (number > maximum)
                        maximum = number;
                }
            }
            Console.WriteLine(maximum);
        }
    }
}