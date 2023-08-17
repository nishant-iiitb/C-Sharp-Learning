namespace Smallest3
{
    /// <summary>
    /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
    /// If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
    /// otherwise, display the 3 smallest numbers in the list.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter list of comma separated numbers  (e.g 5, 1, 9, 2, 10)");
            while (true)
            {
                var inpString = Console.ReadLine();
                var arrString = inpString.Split(", ");
                if (inpString == null || String.IsNullOrWhiteSpace(inpString))
                {
                    Console.WriteLine("Invalid List. Please Retry");
                    continue;
                }
                
                else if (arrString.Length < 5)
                {
                    Console.WriteLine("Invalid List. Please Retry");
                    continue;
                }

                else
                {
                    var intArr = new int[arrString.Length];
                    for (var i = 0; i < intArr.Length; i++ )
                    {
                        intArr[i] = int.Parse(arrString[i]);
                    }
                    Array.Sort(intArr);
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine(intArr[i]);
                    }
                    break;
                }
                
            }
        }
    }
}