using System;
using System.Collections.Generic;

namespace Aufgabe8
{    
    class FreeElement:Quizelement{
        public string solution;
        public FreeElement(String question, String solution)
        {
            this.question = question;
            this.solution = solution;
            this.callToAction = "Type in the right word: ";
        }
    }
}