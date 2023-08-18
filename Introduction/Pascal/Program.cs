namespace Pascal
{
    internal class Program
    {
        //Write a program and ask the user to enter a few words separated by a space.
        //Use the words to create a variable name with PascalCase.
        //For example, if the user types: "number of students", display "NumberOfStudents".
        //Make sure that the program is not dependent on the input.
        //So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

        static void Main()
        {
            Console.WriteLine("Enter a few words separated by a space");
            var input = Console.ReadLine();
            var strArray = input.Split(' ');
            var strArray1 = new string[strArray.Length];
            for (var i = 0; i < strArray.Length; i++)
            {
                strArray1[i] = strArray[i][0].ToString().ToUpper() + strArray[i].Substring(1);
            }
            var str = String.Join("", strArray1);
            Console.WriteLine(str);
        }
    }

}