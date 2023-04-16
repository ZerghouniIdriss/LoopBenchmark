# LoopBenchmark in C#
In C#, the choice between using a for loop or a foreach loop largely depends on the specific use case and the data structure being used. Generally, for loops are faster when working with arrays and List<T> collections, while foreach loops are more convenient when working with other collections that implement IEnumerable.


This repository have a simple benchmark example to illustrate the performance difference between for and foreach loops when iterating over an array and a list.

This example shows that the for loop tends to have better performance than the foreach loop, especially when working with arrays or lists. However, keep in mind that the performance difference is often negligible for most applications. It's more important to choose the loop type that results in more readable and maintainable code, depending on the specific use case. If performance is a critical concern, always run benchmarks on your specific code to determine the best option.

