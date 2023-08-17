
namespace GuessNumber
{
    //Write a program that picks a random number between 1 and 10.
    //Give the user 4 chances to guess the number.
    //If the user guesses the number, display “You won"; otherwise, display “You lost".
    //(To make sure the program is behaving correctly, you can display the secret number on the console first.)
    class Program
    {
        static void Main(string[] args)
        {
            var flag = false;
            var random = new Random();
            var ran = random.Next(0, 10);
            Console.WriteLine(ran);
            Console.WriteLine("Guess the number. Number is between 1 to 10. You have 4 attempts");
            for(var i=0;i<4;i++)
            {
                var input = int.Parse(Console.ReadLine());
                if(ran==input)
                {
                    flag = true;
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine("Correct Guess");
            }
            else
            {
                Console.WriteLine("Wrong Guess");
            }
        }
    }
}