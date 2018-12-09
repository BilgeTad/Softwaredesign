using System;
using System.Collections.Generic;

namespace Aufgabe8
{
    class BinaryElement:Quizelement{
        public Boolean truth;
        public BinaryElement(String question, Boolean truth) {
            this.question = question;
            this.truth = truth;
            this.callToAction = "Type in Y or N: ";
        }
    }
}