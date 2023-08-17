namespace distinct5Numbers
{
    //Write a program and ask the user to enter 5 numbers.
    //If a number has been previously entered, display an error message and ask the user to re-try.
    //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
    class Program
    {
        static void Main(string[] args)
        {
            var inparray = new int[5];
            var count = 0;
            Console.WriteLine("Enter 5 unique Numbers");
            while (count < 5)
            {
                var input = int.Parse(Console.ReadLine());
                var index = Array.IndexOf(inparray, input);
                if (index == -1)
                {
                    inparray[count++] = input;
                }
                else
                {
                    Console.WriteLine("Value Exists already, please retry.");
                }
            }
            Array.Sort(inparray);
            foreach (var i in inparray)
            {
                Console.WriteLine(i);
            }
        }
    }
}