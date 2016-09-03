using System;

namespace VariablesNameExpressions
{
    public class Statistics
    {
        // Task 2. Method PrintStatistics in C#
        public void PrintStatistics(double[] statisticsNumbers, int statisticsNumbersCount)
        {
            double maxNumber = double.MinValue;
            double temp = 0;

            for (int index = 0; index < statisticsNumbersCount; index++)
            {
                if (statisticsNumbers[index] > maxNumber)
                {
                    maxNumber = statisticsNumbers[index];
                }
            }
            PrintMax(maxNumber);
            temp = 0;
            maxNumber = 0;
            for (int index = 0; index < statisticsNumbersCount; index++)
            {
                if (statisticsNumbers[index] < maxNumber)
                {
                    maxNumber = statisticsNumbers[index];
                }
            }
            PrintMin(maxNumber);

            temp = 0;
            for (int index = 0; index < statisticsNumbersCount; index++)
            {
                temp += statisticsNumbers[index];
            }
            PrintAvg(temp / statisticsNumbersCount);
        }

        // Method is needed for compilation
        private void PrintAvg(double v)
        {
            throw new NotImplementedException();
        }

        // Method is needed for compilation
        private void PrintMin(double max)
        {
            throw new NotImplementedException();
        }

        // Method is needed for compilation
        private void PrintMax(double max)
        {
            throw new NotImplementedException();
        }
    }
}