using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structura_dz
{
    public struct DecimalNumber
    {
        public int value;

        public DecimalNumber(int value)
        {
            this.value = value;
        }

        public string ToBinary()
        {
            return Convert.ToString(value, 2);
        }

        public string ToOctal()
        {
            return Convert.ToString(value, 8);
        }

        public string ToHexadecimal()
        {
            return Convert.ToString(value, 16);
        }
    }

    internal class Task2
    {
        public static void task2()
        {
            DecimalNumber number = new DecimalNumber(42);
            string binary = number.ToBinary();
            Console.WriteLine(binary);

             number = new DecimalNumber(42);
            string octal = number.ToOctal();
            string hexadecimal = number.ToHexadecimal();
            Console.WriteLine(octal); // виведе 52
            Console.WriteLine(hexadecimal); // виведе 2A


        }
    }
}
