namespace datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 01, 01);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine(today);
            Console.WriteLine(now.Hour);

            Console.WriteLine(now.AddDays(1));
            Console.WriteLine(now.AddDays(-1));
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss.ss"));

            var timeSpan = new TimeSpan(1,2,3);
            var timeSpan1 = new TimeSpan(1,0,0);
            var timeSpan2 = TimeSpan.FromHours(1);
            var timeSpan3 = today - dateTime;
            Console.WriteLine(timeSpan);
            Console.WriteLine(timeSpan1);
            Console.WriteLine(timeSpan2);
            Console.WriteLine(timeSpan3);

            Console.WriteLine(timeSpan.Minutes);
            Console.WriteLine(timeSpan.TotalMinutes);
            Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(20)));
            Console.WriteLine(timeSpan.Subtract(TimeSpan.FromMinutes(20)));

            Console.WriteLine(timeSpan.ToString());
            Console.WriteLine(TimeSpan.Parse("03:26:35"));

        }
    }
}