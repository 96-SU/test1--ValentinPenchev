using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int[] count = new int[10];

        for (int i = a; i <= b; i++)
        {
            int num = i;

            while (num > 0)
            {
                int digit = num % 10;
                count[digit]++;
                num /= 10;
            }
        }

        int maxCount = 0;
        int resultDigit = 0;

        for (int d = 0; d <= 9; d++)
        {
            if (count[d] > maxCount)
            {
                maxCount = count[d];
                resultDigit = d;
            }
        }

        Console.WriteLine($"Digit {resultDigit} - {maxCount} times");
    }
}