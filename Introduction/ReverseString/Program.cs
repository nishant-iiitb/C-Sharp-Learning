
namespace ReverseString
{
    //Write a program and ask the user to enter their name.
    //Use an array to reverse the name and then store the result in a new string.
    //Display the reversed name on the console.
    class Program
    {

        static void Main(string[] args)
        {
            // var names = new List<string>();
            Console.WriteLine("Enter name");
            var name = Console.ReadLine();
            char[] array = name.ToCharArray();
            char[] reverseArray = new char[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reverseArray[i] = array[array.Length - i - 1];
            }
            var reverseName = new string(reverseArray);
            Console.WriteLine(reverseName);
        }
    }
}