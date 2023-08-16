namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number=255;
            int random = 3569;
            float salary = 10000.25f;
            char ch = 'A';
            string firstName = "Nishant";
            bool isWorking = true;
            Console.WriteLine(number);
            Console.WriteLine(random);
            Console.WriteLine(salary);
            Console.WriteLine(ch);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0},{1}",byte.MinValue, byte.MaxValue);
            const float PI = 3.14f;
            Console.WriteLine(PI);
        }
    }
}