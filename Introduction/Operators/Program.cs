namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            Console.WriteLine(a/b);
            Console.WriteLine((float)a/(float)b);
            var c = 5;
            Console.WriteLine(a+b*c);
            Console.WriteLine((a+b)*c);
            Console.WriteLine(a>b);
            Console.WriteLine(a==b);
            Console.WriteLine(a<b);
            Console.WriteLine(a!=b);
            Console.WriteLine(!(a!=b));
            Console.WriteLine(c>b && c>a);
            Console.WriteLine(c > b && c < a);
            Console.WriteLine(c > b || c > a);
            Console.WriteLine(!(c > b && c > a));
        }
    }
}