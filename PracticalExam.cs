using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;

namespace Examination_system
{
    public class PracticalExam : Exam
    {
        
        public List<int> userAnswerID =new List<int>();
        public PracticalExam(int time, int numbersOfq) : base(time, numbersOfq)
        {
        }

        public override void ShowExam()
        {
            


            Console.WriteLine("Practical Exam");
            int totalGrade = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"Question {i+1}: {questions[i].BodyOfq}");
                // Display the question details here
              
                Console.WriteLine($"MCQ Questoin: Mark {questions[i].Mark} ");
                for(int j = 0; j < questions[i].Answers.Length; j++)
                {
                    Console.WriteLine($"{questions[i].Answers[j].AnswerID}-{questions[i].Answers[j].AnswerText}");
                }

                Console.WriteLine("Enter Your Answer ID:");
                int studentAnswerID = int.Parse(Console.ReadLine()!);

                if (studentAnswerID == questions[i].RightAnswer.AnswerID)
                {
                    totalGrade += questions[i].Mark;
                }
                Console.WriteLine();      
            }

            Console.WriteLine("Practical Exam Results:");
            for(int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"Question {i + 1}:{ questions[i].BodyOfq}");
                Console.WriteLine($"Correct Answer => {questions[i].RightAnswer.AnswerText}");
            }
            Console.WriteLine($"Your Grade is {totalGrade}");

        

       
        }
    }
}
