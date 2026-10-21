using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system
{
    public class Answers
    {
        //MCQ
        public Answers(int answerID, string answerText)
        {
            AnswerID = answerID;
            AnswerText = answerText;
        }

        public int AnswerID { get; set; }
        public string AnswerText { get; set; }

        override public string ToString()
        {
            return $"Answer ID: {AnswerID}, Answer Text: {AnswerText}";
        }

    } 
}

