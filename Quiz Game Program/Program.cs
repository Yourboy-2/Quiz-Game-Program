using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Game_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the South African questions and answers
            var quiz = new List<Question>
            {
                new Question("What is the capital city of South Africa?", new List<string> { "1. Johannesburg", "2. Pretoria", "3. Cape Town", "4. Durban" }, 2),
                new Question("Which South African president won the Nobel Peace Prize in 1993?", new List<string> { "1. Thabo Mbeki", "2. Nelson Mandela", "3. F.W. de Klerk", "4. Jacob Zuma" }, 2),
                new Question("What is the national animal of South Africa?", new List<string> { "1. Springbok", "2. Lion", "3. Elephant", "4. Rhino" }, 1),
                new Question("Which South African city is known as the Mother City?", new List<string> { "1. Johannesburg", "2. Durban", "3. Cape Town", "4. Pretoria" }, 3),
                new Question("What is the currency of South Africa?", new List<string> { "1. Rand", "2. Dollar", "3. Euro", "4. Pound" }, 1)
            };

            int score = 0;

            Console.WriteLine("Welcome to the South African Quiz!");
            Console.WriteLine("----------------------------");

            // Loop through each question
            foreach (var question in quiz)
            {
                Console.WriteLine(question.QuestionText);
                foreach (var option in question.Options)
                {
                    Console.WriteLine(option);
                }

                int userAnswer = GetValidAnswer();

                if (userAnswer == question.CorrectAnswer)
                {
                    Console.WriteLine("Correct!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer was option {question.CorrectAnswer}.\n");
                }
            }

            // Display final score with enhanced formatting
            Console.WriteLine("----------------------------");
            Console.WriteLine("Quiz Completed!");
            Console.WriteLine($"You scored {score} out of {quiz.Count}.");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Thanks for playing!");
        }

        // Method to get a valid answer from the user
        static int GetValidAnswer()
        {
            int userAnswer;
            while (true)
            {
                Console.Write("Enter the number of your answer: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out userAnswer) && userAnswer >= 1 && userAnswer <= 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                }
            }

            return userAnswer;
        }
    }

    // Class to represent a quiz question
    class Question
    {
        public string QuestionText { get; }
        public List<string> Options { get; }
        public int CorrectAnswer { get; }

        public Question(string questionText, List<string> options, int correctAnswer)
        {
            QuestionText = questionText;
            Options = options;
            CorrectAnswer = correctAnswer;
        }
    }
}
