using System;
using System.Collections.Generic;

namespace Aufgabe8
{
        class GuessElement:Quizelement{  
           
        public double number;
        public double tolerance;
        public GuessElement(String question, double number, double tolerance){
            this.question = question;
            this.number = number;
            this.tolerance = tolerance;
            this.callToAction = "Type in the tolarance: ";
        } 
    }
}