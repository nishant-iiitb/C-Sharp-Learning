namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            int i2 = 2333;
            byte b2 = (byte)i2;
            Console.WriteLine(b2);

            string number = "1234";
            //int i3 = (int)number;
            int i3 = Convert.ToInt32(number);
            Console.WriteLine(i3);
            try
            {
                byte b3 = byte.Parse(number);
                Console.WriteLine(b3);
            }
            catch(Exception)
            {
                Console.WriteLine("Number cannot be converted to Byte");
            }
            try
            {
                string str = "true";
                bool bb = Convert.ToBoolean(str);
                Console.WriteLine(bb);
            }
            catch (Exception)
            {
                Console.WriteLine("Number cannot be converted to Boolean");
            }


        }
    }
}