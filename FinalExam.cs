using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system
{
    public class FinalExam : Exam
    {
        //FinalExam
        public List<int> userAnswerID = new List<int>();
        public FinalExam(int time, int numbersOfq) : base(time, numbersOfq)
        {
        }

        public override void ShowExam()
        {

            Console.WriteLine("Final Exam:");
            int totalGrade = 0;
            int maxMarks = 0;

            for(int i = 0; i < questions.Count; i++)
            {
                maxMarks += questions[i].Mark;
                Console.WriteLine($"Question {i+1}: {questions[i].BodyOfq} Mark:{questions[i].Mark}");

                for (int j = 0; j < questions[i].Answers.Length; j++)
                {
                    Console.WriteLine($"{questions[i].Answers[j].AnswerID}- {questions[i].Answers[j].AnswerText}");
                }

                Console.WriteLine("Enter Your Answer ID: ");
                int.TryParse(Console.ReadLine(),out int result);
                int studentAnswerID = result;

                if (studentAnswerID == questions[i].RightAnswer.AnswerID)
                {
                    totalGrade += questions[i].Mark;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Final Exam Results : Your Total Grade is {totalGrade} From {maxMarks}");

           
        }
        
    }
}
