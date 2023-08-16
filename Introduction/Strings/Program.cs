namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Mosh";
            var lastName = "Hamedani";
            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            var myFullName = string.Format("{1} {0}", firstName, lastName);
            Console.WriteLine(myFullName);
            var names = new string[] { "John", "Mary", "Jack" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);
         }
    }
}