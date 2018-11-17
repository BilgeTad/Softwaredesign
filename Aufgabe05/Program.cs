using System;

namespace Aufgabe05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Text: ");
            string enteredText = Console.ReadLine();
            
            string turnedText = TurnAll(enteredText);
            string outputTurnedWord = TurnWord(enteredText);
            string outputText = TurnWordLetter(enteredText);

            Console.WriteLine(turnedText);
            Console.WriteLine(outputTurnedWord);
            Console.WriteLine(outputText);


        }
        public static string TurnAll(string enteredText)
        {
            string turnedText = "";
            for (int i = enteredText.Length - 1; i >= 0; i--)
            {
                turnedText += enteredText[i];
            }
            return turnedText;
        }

        public static string TurnWord(string enteredText)
        {
            string[] words = enteredText.Split(' ');
            string[] turnedWords = new string[words.Length];


            for (int i = 0, k = words.Length - 1; i <= words.Length - 1; i++, k--)
            {
                turnedWords[k] = words[i];
            }
            return string.Join(" ", turnedWords);


        }

        public static string TurnWordLetter(string enteredText)
        {
            string[] word = enteredText.Split(' ');
            string wordToTurn = "";
            string[] outputText = new string[word.Length];

            for (int i = 0; i <= word.Length - 1; i++)
            {
                wordToTurn = word[i];

                string wordIsTurned = "";
                for (int k = wordToTurn.Length - 1; k >= 0; k--)
                {
                    wordIsTurned += wordToTurn[k];
                }
                outputText[i] = wordIsTurned;

            }
            return string.Join(" ", outputText);
        }
    }
}
