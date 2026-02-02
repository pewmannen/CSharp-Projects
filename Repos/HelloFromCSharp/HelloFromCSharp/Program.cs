using System;

class Program
{
    // This matches what the platform usually calls
    public static int[] solution(int[] numbers)
    {
        if (numbers == null || numbers.Length < 3)
            return Array.Empty<int>();

        int n = numbers.Length;
        int[] result = new int[n - 2];

        for (int i = 0; i < n - 2; i++)
        {
            int a = numbers[i];
            int b = numbers[i + 1];
            int c = numbers[i + 2];

            bool zigzag = (a < b && b > c) || (a > b && b < c);

            if (zigzag)
            {
                result[i] = 1;
            }
            else
            {
                result[i] = 0;
            }
        }

        return result;
    }

    // This is ONLY for local testing
    static void Main()
    {
        int[] numbers = { 1, 2, 1, 3, 4 };

        int[] output = solution(numbers);

        Console.WriteLine(string.Join(", ", output));
        // Expected: 1, 1, 0
    }
}
