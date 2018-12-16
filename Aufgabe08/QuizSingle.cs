using System;
using System.Collections.Generic;

namespace Aufgabe08
{
    class QuizSingle : Quizelement
    {
        public Answer[] answers;
        public QuizSingle(string question, Answer[] answers)
        {
            this.question= question;
            this.answers= answers;
        }
    }
}