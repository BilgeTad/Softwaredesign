using System;

namespace Aufgabe08
{
    class QuizMultiple : Quizelement
    {
        public String question;
        public Answer[] answers;
        public int correctAnswers;
        public QuizMultiple(String question, Answer[] answers, int correctAnswers) {

            this.question = question;
            this.answers = answers;

        }
    }
}