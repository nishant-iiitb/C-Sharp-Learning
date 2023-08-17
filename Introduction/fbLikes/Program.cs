﻿
namespace fbLikes
{
//    When you post a message on Facebook, depending on the number of people who like your post,
//    Facebook displays different information.
//    If no one likes your post, it doesn't display anything.
//    If only one person likes your post, it displays: [Friend's Name] likes your post.
//    If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
//    If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
//    Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
//    Depending on the number of names provided, display a message based on the above pattern.
    class Program
    {

        static void Main(string[] args)
        {
            var names = new List<string>();
            Console.WriteLine("Enter names, just press enter to exit");
            while (true)
            {
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                else
                    names.Add(input);
            }

            var count = names.Count;
            if (count == 0)
                Console.WriteLine();
            else if (count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else if (count == 2)
                Console.WriteLine("{0} and {1} likes your post.", names[0], names[1]);
            else
                Console.WriteLine("{0}, {1} and {2} others likes your post.", names[0], names[1], (count - 2));
        }
    }
}

