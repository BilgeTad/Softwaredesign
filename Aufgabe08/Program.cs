using System;
using System.Collections.Generic;

namespace Aufgabe08
{
    class Program
    {
        static int score = 0;

        public static List<Quizelement> quizelementsList;
        static void Main(string[] args)
        {
            QuizMenu();
            CreateNewQuiz();
        }

        public void QuizMenu()
        {
            while (true)
            {
                Console.WriteLine("Deine Highscore ist: " + score + "\n");
                Console.WriteLine("Bitte auswählen: :\n 1) Quiz beantworten\n 2) Neue Fragen stellen\n 3) Das Spiel beenden\n");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Random random = new Random();
                    int randomQuestion = random.Next(quizelementsList.Count);
                    AnswerQuestion(quizelementsList[randomQuestion]);
                    QuizMenu();
                }

                else if (choice == 2)
                {
                    AddNewQuestion();
                    QuizMenu();

                }

                else if (choice == 3)
                {
                    break;
                }

            }
        }

        public static void CreateNewQuiz()
        {
            
            Quizelement QuizSingle = new QuizSingle();
            QuizSingle.question ="Who was the first Chancellor of the Federal Republic of Germany?";
                QuizSingle.answers.Add(new Answer("1) Barack Obama", false));
                QuizSingle.answers.Add(new Answer("2) Helmut Kohl", false));
                QuizSingle.answers.Add(new Answer("3) Konrad Adenauer", true));
                QuizSingle.answers.Add(new Answer("4) Angela Merkel", false));
            question.Add(QuizSingle);
        
            quizelementsList.Add(new QuizMultiple("Which of the following countries aren't part of the European Union?", new Answer[] {
                new Answer("1) Croatia", false),
                new Answer("2) Serbia", true),
                new Answer("3) Germany", false),
                new Answer("4) Turkey", true)
            }));
            quizelementsList.Add(new QuizBinary("Istanbul is the Capital of Turkey?", false)); 
            quizelementsList.Add(new QuizFree("Zu welcher Gruppe der Elementarteilchen gehört das Elektron?", "Leptonen"));
            
        }

        public void ChooseQuestionType(int score){

            Console.WriteLine("Which type of question do you want to answer?");
            string type = Console.ReadLine();
            if (type == "QuizSingle")
            {
                quizSingle.Show();
                QuizSingle.AnswerQuizSingle(score);
            }

            if (type == "QuizMultiple")
            {
                //multipleElements.Show();
                QuizMultiple.AnswerQuizMultiple(score);
            }

            if (type == "QuizBinary")
            {
                binaryElements.Show();
                QuizBinary.AnswerQuizBinary(score);
            }

            if (type == "QuizGuess")
            {
                
                QuizGuess.AnswerQuizGuess(score);
            }

            if (type == "QuizFree")
            {
                freeElements.Show();
                QuizFree.AnswerQuizFree(score);
            }
        }
        

        public static void AnswerQuestion(Quizelement quizelements)
        {
            quizelements.Show();
            Console.Write("\nBitte eine Antwort wählen ");
            int AnswerChoice = int.Parse(Console.ReadLine()) - 1;

            if (quizelements.answers[AnswerChoice].IsAnswerCorrect())
            {
                score += 1;
                Console.Write("\nRichtig\n");
            }
            else
            {
                Console.Write("\nFalsch\n");
            }

        } 

        
        public void AnswerQuizSingle(int score)
       {
           //Quizelement quizSingle = new Quizelement();
            quizSingle.question = "Wer war der erste Bundeskanzler der BRD?";
            string[] answers = new string[4];
            answers[0] = "Barak Obama";
            answers[1] = "Helmut Kohl";
            answers[2] = "Konrad Adenauer";
            answers[3] = "Angela Merkel";
           Console.WriteLine(QuizSingle.question);
           Console.WriteLine(QuizSingle.answers);
           Console.WriteLine("Bitte wähle die richtige Antwort:");
           int answerChoice = int.Parse(Console.ReadLine());
           if (answerChoice == 3)
           {
               Console.WriteLine("Korrekt");
               score ++;
           }
           else
           {
               Console.WriteLine("Falsch");
           }
       }

        public static void AddNewQuestion()
        {
            Console.Write("Gebe eine neue Frage ein\n> ");
            String addUserQuestion = Console.ReadLine();
            Console.Write("Wieviele Antwortmöglichkeiten soll die Frage haben?\n> ");
            int addHowManyAnswers = Int32.Parse(Console.ReadLine());
            Answer[] userAnswer = new Answer[addHowManyAnswers];

            Console.Write("Gebe die Richtige Antwort ein: \n> ");
            userAnswer[0] = new Answer(Console.ReadLine(), true);
            for (int i = 1; i < addHowManyAnswers; i++)
            {
                Console.Write("Bitte weitere Antwortmöglichkeiten eingeben\n> ");
                userAnswer[i] = new Answer(Console.ReadLine(), false);
            }
            quizelementsList.Add(new Quizelement(addUserQuestion, userAnswer));
        }
    }
}
