
using BenchmarkDotNet.Running;
using CsArrayCopyMethodsBenchMark;

internal class Program
{
    private static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<TestArrayCopyClass>();
    }
}