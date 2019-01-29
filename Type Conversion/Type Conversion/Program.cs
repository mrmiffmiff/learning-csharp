using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 1;
            int j = a;
            Console.WriteLine(j);

            int i = 1000;
            byte b = (byte) i;
            Console.WriteLine(b);

            var number = "1234";
            int k = Convert.ToInt32(number);
            Console.WriteLine(k);

            try
            {
                byte m = Convert.ToByte(number);
                Console.WriteLine(m);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            try
            {
                string str = "true";
                bool c = Convert.ToBoolean(str);
                Console.WriteLine(c);
            }
            catch (Exception)
            {
                Console.WriteLine("The value could not be converted to a boolean.");
            }
        }
    }
}
