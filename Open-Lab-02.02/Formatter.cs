using System;

namespace Open_Lab_02._02
{
    public class Formatter
    {
        public void Format(double[] numbers)
        {
            int i = 0;
            foreach (double item in numbers)
            {   
                double rounded = Math.Round(item, 2);
                numbers[i] = rounded;
                i = i + 1;
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
