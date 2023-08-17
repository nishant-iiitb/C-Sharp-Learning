namespace divBy3
{
    /// <summary>
    /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
    /// Display the result on the console.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            for(var i=1; i <= 100; i++)
            {
                if (i%3==0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}