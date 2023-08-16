namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;
            if(hour>0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if (hour>=12 && hour < 18) 
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }

            bool isGoldCustomer = false;
            float price = (isGoldCustomer)? 19.95f : 29.95f;
            Console.WriteLine(price);

            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's Summer");
                    break;
                default: Console.WriteLine("Default Season");
                    break;
            }



        }
    }
}