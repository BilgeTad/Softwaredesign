using System;

namespace L07_DesignPatterns
{
    class Calculator{

        public event ReportProgressMethod ProgressMethod;

        public Calculator()
        {
            ProgressMethod += ProgressInPercent;
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
    }
}