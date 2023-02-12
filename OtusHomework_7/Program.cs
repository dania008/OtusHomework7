using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] values = { 5, 10, 20 };
        foreach (int value in values)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int result = GetFibonacciRecursive(value);
            stopwatch.Stop();
            Console.WriteLine($"Recursive method for {value}: {result} ({stopwatch.ElapsedMilliseconds}ms)");
            stopwatch = Stopwatch.StartNew();
            result = GetFibonacciIterative(value);
            stopwatch.Stop();
            Console.WriteLine($"Iterative method for {value}: {result} ({stopwatch.ElapsedMilliseconds}ms)");
        }
    }

    private static int GetFibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;
        return GetFibonacciRecursive(n - 1) + GetFibonacciRecursive(n - 2);
    }
    static int GetFibonacciIterative(int n)
    {
        int prev = 0;
        int current = 1;
        int next;
        for (int i = 0; i < n; i++)
        {
            next = prev + current;
            prev = current;
            current = next;
        }
        return prev;
    }
}