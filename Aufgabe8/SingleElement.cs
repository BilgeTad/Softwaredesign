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
    }

}