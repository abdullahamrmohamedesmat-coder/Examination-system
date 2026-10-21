using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Examination_system
{
    public class T_Or_F : Question
    {
        public T_Or_F( Answers rightAnswer, string? headerOfq, string? bodyOfq, int mark) : 
            base(new Answers[] { new Answers(1,"True"),new Answers(2,"False")}, rightAnswer, headerOfq, bodyOfq, mark)
        {
        }

        public T_Or_F()
        {

        }

        int correctAnswerID;
        public List<Answers> choices = new List<Answers>();
        public override void QuestionImplementation()
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

            Answers = new Answers[] { new Answers(1, "True"), new Answers(2, "False") };

            do
            {
                Console.WriteLine("Please Enter The ID Of The Correct Answer (1 = True, 2 = False)");
                int.TryParse(Console.ReadLine(), out correctAnswerID);
            }
            while (correctAnswerID < 1 || correctAnswerID > 2);

            RightAnswer = Answers[correctAnswerID - 1];
          

        }
    }
}
