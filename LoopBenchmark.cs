using System;
using System.Collections.Generic;
using System.Diagnostics;

class LoopBenchmark
{
    static void Main()
    {
        int numIterations = 1000000;
        int[] array = new int[numIterations];
        List<int> list = new List<int>(array);

        var stopwatch = new Stopwatch();

        // Measure time for 'for' loop with array
        stopwatch.Start();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }
        stopwatch.Stop();
        Console.WriteLine($"For loop (array): {stopwatch.ElapsedMilliseconds} ms");

        // Measure time for 'foreach' loop with array
        stopwatch.Restart();
        int index = 0;
        foreach (var item in array)
        {
            array[index++] = item;
        }
        stopwatch.Stop();
        Console.WriteLine($"Foreach loop (array): {stopwatch.ElapsedMilliseconds} ms");

        // Measure time for 'for' loop with list
        stopwatch.Restart();
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = i;
        }
        stopwatch.Stop();
        Console.WriteLine($"For loop (list): {stopwatch.ElapsedMilliseconds} ms");

        // Measure time for 'foreach' loop with list
        stopwatch.Restart();
        index = 0;
        foreach (var item in list)
        {
            list[index++] = item;
        }
        stopwatch.Stop();
        Console.WriteLine($"Foreach loop (list): {stopwatch.ElapsedMilliseconds} ms");
    }
}
