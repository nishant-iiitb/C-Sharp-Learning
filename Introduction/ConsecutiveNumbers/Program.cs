namespace ConsecutiveNumbers
{
    class Program
    {
        //Write a program and ask the user to enter a few numbers separated by a hyphen. 
        //Work out if the numbers are consecutive. 
        //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
        static void Main()
        {
            Console.WriteLine("Enter few numbers separated by '-' e.g.'5-6-7-8-9' or '20-19-18-17-16'");
            var input = Console.ReadLine();
            var inpArray = input.Split('-');
            var check = 0;
            var flag = true;
            for (int i = 0; i < inpArray.Length; i++)
            {
                if (i == 0)
                {
                    var x = int.Parse(inpArray[i]);
                    var y = int.Parse(inpArray[i + 1]);
                    if (Math.Abs(x - y) == 1)
                        check = x - y;
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                else
                {
                    var x = int.Parse(inpArray[i - 1]);
                    var y = int.Parse(inpArray[i]);
                    if ((x - y) == check)
                        continue;
                    else
                    {
                        flag = false;
                        break;
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }
    }
}