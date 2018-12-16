using System;

namespace Aufgabe08
{
    class QuizFree : Quizelement
    {
        public String question;
        public String answer;
        public QuizFree(String question, String answer) {
            this.question = question;
            this.answer = answer;
        }
        public void ShowQuestion() 
        {
            Console.Write($"\n{question}\n\n");
        }
    }
}