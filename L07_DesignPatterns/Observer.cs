using System;

namespace L07_DesignPatterns
{
    class Calculator{

        public event ReportProgressMethod ProgressMethod;

        public Calculator()
        {
            ProgressMethod += ProgressInPercent;
            ProgressMethod += ProgressInfo;
        }

        public void CalculateSomething()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i == 20 || i == 40 || i == 60 || i == 80 || i == 100)
                {
                    ProgressMethod(i);
                }
            }
        }

        public void ProgressInPercent(int progress)
        {
            Console.WriteLine(progress + " %");
        }

        public void ProgressInfo(int progress)
        {
            if (progress == 100)
            {
                Console.WriteLine("Finished");
            }
            else
            {
                Console.WriteLine("Loading");
            }
        }
    }
}