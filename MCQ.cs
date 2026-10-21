using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system
{
    public class MCQ : Question
    {
        //MCQ 
        
        public List<Answers> choices = new List<Answers>();
       public int correctAnswerID;

        public MCQ(Answers[] answers, Answers rightAnswer, string? headerOfq, string? bodyOfq, int mark) : base(answers, rightAnswer, headerOfq, bodyOfq, mark)
        {
        }

       public MCQ()
        {

        }

        public  override void QuestionImplementation()
        {
            //input Header OF the Question
            Console.WriteLine("Please Enter Header of The Quesion");
            HeaderOfq = Console.ReadLine();

            //input Body Of The Question
            Console.WriteLine("Please Enter Body Of The Question");
            BodyOfq = Console.ReadLine();

            //input Mark Of The Question
            Console.WriteLine("Please Enter Mark Of The Question");
            int.TryParse(Console.ReadLine(), out int result);
            Mark = result;
            
            //Input Choices
            Console.WriteLine("Choices Of Question");
            
            Console.WriteLine("Please Enter Numbers Of Choices");
            int.TryParse(Console.ReadLine(),out int Num_choices);
           
            for (int i = 0; i < Num_choices; i++)
            {
                
                Console.WriteLine($"Please Enter Choice Number {i+1}");
                string? answerText = Console.ReadLine();
                choices.Add(new Answers(i + 1, answerText!));
            }
            
            do
            {
                Console.WriteLine("Please Enter The ID Of The Correct Answer");
                int.TryParse(Console.ReadLine(), out  correctAnswerID);
            }
            while (correctAnswerID < 1 || correctAnswerID > choices.Count);

            Answers = choices.ToArray();
            RightAnswer = choices[correctAnswerID - 1];


        }
    }
}
