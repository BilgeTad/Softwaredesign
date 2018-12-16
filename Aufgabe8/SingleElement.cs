using System;
using System.Collections.Generic;

namespace Aufgabe8
{   
    class SingleElement:Quizelement{
        public SingleElement(string question, Answer[] answers)
        {
            this.question = question;
            this.answers = answers;
        }

        public static Quizelement AddQuizSingle() 
        {
            Console.Write("\nType in the question:\n> ");
            String newQuestion = Console.ReadLine();

            Console.WriteLine("How many possible answers should the question have?");
            int answerCount = Int32.Parse(Console.ReadLine());
            Answer[] newAnswers = new Answer[answerCount];

            Console.Write("\nType in the correct answer:\n> ");
            newAnswers[0] = new Answer(Console.ReadLine(), true);

            for (int i = 1; i < answerCount; i++)
            {
                Console.Write("Type in your wrong answer:");
                newAnswers[i] = new Answer(Console.ReadLine(), false);
            }
            quizelements.Add(new SingleElement(newQuestion, newAnswers));
            return new SingleElement(newQuestion, newAnswers);
        }
    }

}