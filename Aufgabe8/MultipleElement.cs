using System;
using System.Collections.Generic;

namespace Aufgabe8
{
    class MultipleElement:Quizelement{
       
        public MultipleElement(String question, Answer[] answers) {
            this.question = question;
            this.answers = answers;
            
        }
    }
}