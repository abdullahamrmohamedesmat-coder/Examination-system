using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system
{
    public abstract class Question
    {
        //Question
        protected Question(Answers[] answers, Answers rightAnswer, string? headerOfq, string? bodyOfq, int mark)
        {
            Answers = answers;
            RightAnswer = rightAnswer;
            
            HeaderOfq = headerOfq;
            BodyOfq = bodyOfq;
            Mark = mark;
        }
        public Question()
        {

        }

        public Answers[] Answers { get; set; }

        public Answers RightAnswer { get; set; }
      
        public string? HeaderOfq { get; set; }
        public string? BodyOfq { get; set; }
        public int Mark {  get; set; }

        public abstract void QuestionImplementation();

    }
}
