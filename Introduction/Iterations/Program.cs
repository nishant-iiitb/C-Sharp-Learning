namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i<=10; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            var name = "John Smith";
            for (var i =0; i< name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach(var ch in name)
            {
                Console.WriteLine(ch);
            }

            var numbers = new int[] { 1, 2, 3, 4 };
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            var j = 0;
            while(j<=10)
            {
                if(j%2 == 0)
                    Console.WriteLine(j);
                j++;
            }

            while(true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;
                
            }

        }
    }
}