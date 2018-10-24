using System;
using System.Text;

namespace Softwaredesign
{
    class Program
    {
        static void Main(string[] args)
        
        { 
           int inputNumber = Int32.Parse(args[0]);

            Console.WriteLine(GetRomanNumber(inputNumber));

        }
    
        public static String GetRomanNumber(int number) 
        {
            if ((number <= 0) || (number > 999) )
            return "Error: Eingabe ausserhalb des Wertebereichs";
            
            StringBuilder Roman = new StringBuilder();
            
            string snumber  = Convert.ToString(number); // Konvertiert den Typ integer in einen Typ String

            int[] valueHundred    = {100, 400, 500, 900, 1000};  
            string[] romanHundred = {"C", "CD", "D", "CM", "M"};  

            int[] valueTens       = {10, 40, 50, 90};
            string[] romanTens    = {"X", "XL", "L", "XC"};

            int[] valueOnes       = {1, 4, 5, 9};
            string[] romanOnes    = {"I", "IV", "V", "IX"};
            
            

            
            // Überprüfe ob die Zahl im Hunderter Bereich ist
            if(snumber.Length == 3)
            {
                while(number > 100)
                {
                     // Ausgabe von der Hunderter Zahl
                    for (int i = valueHundred.Length - 1; i >= 0; i--)
                        if (number / valueHundred[i] >= 1)
                        {
                            number = number - valueHundred[i];
                            Roman.Append(romanHundred[i]);
                            break;
                        }  
                }
            }



             // Überprüfe ob die Zahl im Zehner Bereich ist
            if(snumber.Length >= 2) 
            {
                while(number > 10)
                {
                    // Ausgabe von der Zehner Zahl
                    for (int i = valueTens.Length - 1; i >= 0; i--)
                        if (number / valueTens[i] >= 1)
                        {
                            number = number - valueTens[i];
                            Roman.Append(romanTens[i]);
                            break;
                        }  
                }
            }


             // Überprüfe ob die Zahl im Einser Bereich ist
            if(snumber.Length >= 1)
            {
                while(number > 0)
                {
                    // Ausgabe von der Einser Zahl
                    for (int i = valueOnes.Length - 1; i >= 0; i--)
                        if (number / valueOnes[i] >= 1)
                        {
                            number = number - valueOnes[i];
                            Roman.Append(romanOnes[i]);
                            break;
                        }  
                }
            }
            
            return Roman.ToString();
            
        }
    }
} 
