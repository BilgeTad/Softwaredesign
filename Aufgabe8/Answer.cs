using System;
using System.Collections.Generic;

namespace Aufgabe8
{
    public class Answer
    {
        public String text;
        public Boolean verity;
        public Answer(String text, Boolean verity) {
            this.text = text;
            this.verity = verity;
        }

        public Boolean isTrue(){
            return verity;
        }
    }
}