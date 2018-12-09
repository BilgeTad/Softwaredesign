using System;
using System.Collections.Generic;

namespace Aufgabe8
{
    public class Quizelement
    {
        public String question;
        public Answer[] answers;
        //public String solution;
        public String callToAction;

        public void ShowQuestion(){

            Console.Write ("\n" + question + "\n");
            for (int i = 0; i < answers.Length; i++) {
                Console.WriteLine (answers[i].text);
            }
        }
        public Boolean IsTrue(){
            return false;
        }
    }
}