namespace TimeValidator
{
    internal class Program
    {
        //Write a program and ask the user to enter a time value in the 24-hour time format(e.g. 19:00).
        //A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time".
        //If the user doesn't provide any values, consider it as invalid time.

        static void Main()
        {
            Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00)");
            var input = Console.ReadLine();
            if ((String.IsNullOrWhiteSpace(input)))
                Console.WriteLine("Invalid Time");
            var time = input.Split(':');
            var intTime = Array.ConvertAll(time, int.Parse);
            if ((intTime[0] >= 0 && intTime[0] < 24) && (intTime[1] >= 0 && intTime[1] < 60))
                Console.WriteLine("Ok");
            else
                Console.WriteLine("Invalid Time");
        }
    }
}