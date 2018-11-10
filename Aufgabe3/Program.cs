using System;

namespace Aufgabe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie eine Zahl ein:");
            int dec = int.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToHexal(dec));
            Console.WriteLine("Geben Sie eine Zahl ein:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Von welchem System möchten Sie die Zahl konvertieren?");
            int fromSystem = int.Parse(Console.ReadLine());
            Console.WriteLine("Zu welchem System möchten Sie die Zahl konvertieren?");
            int toSystem = int.Parse(Console.ReadLine());
            Console.WriteLine("Die Lösung ist:");
            Console.WriteLine(ConvertNumberFromSystemToSystem(number, fromSystem, toSystem));
            
        }

        static int DecimalToHexal(int dec)
        {
            int result = 0;
            int factor = 1;
            while (dec != 0)
            {
                int digit = dec % 6;
                dec /= 6;
                result += factor * digit;
                factor *= 10;
            }
            return result;
        }
        static int ConvertNumberFromSystemToSystem(int number, int fromSystem, int toSystem)
        {
            int result = 0;
            result = OtherToDecimal(number, fromSystem);
            result = DecimalToOther(result, toSystem);
            return result;
        }

        static int DecimalToOther(int dec, int system)
        {
            int result = 0;
            int factor = 1;
            while (dec != 0)
            {
                int digit = dec % system;
                dec /= system;
                result += factor * digit;
                factor *= 10;
            }
            return result;
        }

        static int OtherToDecimal(int other, int system)
        {
            int result = 0;
            int factor = 1;
            while (other != 0)
            {
                int digit = other % 10;
                other /= 10;
                result += factor * digit;
                factor *= system;
            }
            return result;
        }
    }
}

