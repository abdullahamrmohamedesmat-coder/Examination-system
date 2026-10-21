using System;
using System.Collections.Generic;
using System.Text;

namespace Examination_system
{
    public abstract class Exam
    {
        //Exam
        public int Time { get; set; }
        public int NumbersOfq {  get; set; }

        
        

        
        public List<Question> questions = new List<Question>();
       
        public Exam(int time, int numbersOfq)
        {
            this.Time = time;
            this.NumbersOfq = numbersOfq;
        }

       public abstract void ShowExam();
    }
}
