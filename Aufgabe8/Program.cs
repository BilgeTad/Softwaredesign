using System;
using System.Collections.Generic;

namespace Aufgabe8
{
    class Program
    {
        static int score = 0;
        static List<Quizelement> quizelements = new List<Quizelement>();
        static int currentQuizelement = 0;
        static void Main(string[] args)
        {
            GetDefaultQuestions();
            while (FollowUserInstruction()) { }
        }

        public static void GetDefaultQuestions()
        {
            quizelements.Add(new SingleElement("Who was the first Chancellor of the Federal Republic of Germany?", new Answer[]{
                new Answer("1) Barack Obama", false),
                new Answer("2) Helmut Kohl", false),
                new Answer("3) Konrad Adenauer", true),
                new Answer("4) Angela Merkel", false)
            }));
            quizelements.Add(new MultipleElement("Which of the following countries aren't part of the European Union?", new Answer[] {
                new Answer("1) Croatia", false),
                new Answer("2) Serbia", true),
                new Answer("3) Germany", false),
                new Answer("4) Turkey", true)
            }));
            quizelements.Add(new FreeElement("Zu welcher Gruppe der Elementarteilchen gehört das Elektron?", "Leptonen"));
            quizelements.Add(new BinaryElement("Istanbul is the Capital of Turkey?", false));
            
        }

        public static Boolean FollowUserInstruction()
        {
            Console.Write("Your score is " + score);
            Console.Write("\nDo you want to:\n\nS) Solve a quiz,\nA) Add a question or\nE) End the program?\n\n> ");

            switch (Console.ReadLine().ToUpper())
            {
                case "S":
                    if (currentQuizelement < quizelements.Count)
                    {
                        SolveAQuestion(quizelements[currentQuizelement]);
                        return true;
                    }
                    else
                    {
                        Console.Write("There are no questions left.\n\n");
                        return false;
                    }
                case "A":
                    AddQuestion();
                    return true;
                default:
                    Console.Write("You left the game.\n\n");
                    return false;
            }
        }

        public static void SolveAQuestion(Quizelement quizelemente)
        {
            quizelemente.ShowQuestion();
            Console.Write("\nYour choice: ");
            if (quizelemente.answers[Int32.Parse(Console.ReadLine()) - 1].isTrue())
            {
                score += 10;
                Console.Write("\nRight!");
            }
            else
            {
                Console.Write("\nWrong!");
            }
            currentQuizelement++;
        }

        public static void AddQuestion()
        {
            Console.WriteLine("What type of question do you want to add ? \n 1. QuizSingle \n 2. QuizMultiple \n 3. QuizBinary \n 4. QuizGuess \n 5. QuizFree");
            string questionType = Console.ReadLine();
            switch(questionType)
            {
                case "1":
                    quizelements.Add(AddQuizSingle());
                    break;
                case "2":
                    quizelements.Add(AddQuizMultiple());
                    break;
                case "3":
                    quizelements.Add(AddQuizBinary());
                    break;
                case "4":
                    quizelements.Add(AddQuizFree());
                    break;
                case "5":
                    quizelements.Add(AddQuizFree());
                    break;
            }
        }


        public static Quizelement AddQuizMultiple()
        {
            Console.Write("\nType in the question:\n> ");
            String newQuestion = Console.ReadLine();

            Console.WriteLine("How many possible answers should the question have?");
            int answerCount = Int32.Parse(Console.ReadLine());
            Answer[] newAnswers = new Answer[answerCount];

            Console.Write("\nWhich Answers are true? \n> ");
            newAnswers[0] = new Answer(Console.ReadLine(), true);

            for (int i = 1; i < answerCount; i++)
            {
                Console.Write("Type in your wrong answer:");
                newAnswers[i] = new Answer(Console.ReadLine(), false);
            }
            quizelements.Add(new MultipleElement(newQuestion, newAnswers));
            return new MultipleElement(newQuestion, newAnswers);
        }
        public static Quizelement AddQuizBinary()
        {
            Console.Write("\nType in the question:\n> ");
            String newQuestion = Console.ReadLine();

            Console.WriteLine("Is the answer correct? (y/n)");
            bool theAnswer = Console.ReadLine() == "y";
            quizelements.Add(new BinaryElement(newQuestion, theAnswer));
            return new BinaryElement(newQuestion, theAnswer);
        }
        public static Quizelement AddQuizFree()
        {
            Console.Write("\nType in the question:\n> ");
            String newQuestion = Console.ReadLine();

            Console.WriteLine("What is the correct answer?");
            return new FreeElement(newQuestion, Console.ReadLine());
        }
    }
}

