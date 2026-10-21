namespace Examination_system
{
    public class Program
    {
        static void Main(string[] args)
        {
            int examType = 0;
            do
            {
                Console.WriteLine("Enter The Type Of The Exam(1 for Practical,2 for final) ");
                examType = int.Parse(Console.ReadLine()!);

            }
            while (examType>2||examType<1);

            int examtime = 0;
            do
            {
                Console.WriteLine("Please Enter The Time Of The Exam(30 t0 180 minustes)");
                int.TryParse(Console.ReadLine(), out int result);
                examtime = result;
            }
            while(examtime<30||examtime>180);

            Console.WriteLine("Please Enter Number Of The Questions ");
            int.TryParse(Console.ReadLine(), out int num);

            Exam exam=null;

            if (examType == 1)
            {
                exam = new PracticalExam(examtime, num);

            }
            else if (examType == 2)
            {
                exam = new FinalExam(examtime, num);
            }
            Console.Clear();

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter details for question {i+1}:");

                Question q = null;

                if (examType == 1)
                {
                    q = new MCQ();
                    q.QuestionImplementation();
                }
                else
                {
                    Console.WriteLine("Choose question type: 1 for MCQ ,2 for True/False:");
                    int qType;
                    int.TryParse(Console.ReadLine(), out qType);

                    if(qType == 1)
                    {
                        q = new MCQ();
                    }
                    else
                    {
                        q = new T_Or_F();
                    }
                    q.QuestionImplementation();
                }
                exam.questions.Add(q);
                Console.Clear();
            }

            Console.WriteLine("Do You Want To Start Exam (Y|N)");
            char startchoice;
            char.TryParse(Console.ReadLine(), out startchoice);

            if(startchoice =='y' || startchoice == 'Y')
            {
                Console.Clear();
                exam.ShowExam();
            }
            Console.WriteLine("\nThank You!");
        }
    }
}
