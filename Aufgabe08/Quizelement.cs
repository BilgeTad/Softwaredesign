using System;
using System.Collections.Generic;

namespace Aufgabe08
{
    public class Quizelement
    {
        public string question;
        //public Answer[] answers;
        public List<Answer> answers;
        public string callToAction;
   
        public Quizelement(String question, List<Answer> answers)
        {
            this.question = question;
            this.answers = answers;
        }
        public void Show()
        {
            Console.Write("\n" + question + "\n");
            for (int i = 0; i < answers.Length; i++)
            {
                Console.WriteLine(answers[i].text);
            }
        }
    }
}