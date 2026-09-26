using BenchmarkDotNet.Attributes;
using System.Text;

namespace AcademyScheduleAnalyzer.Benchmarks;

[MemoryDiagnoser]
public class StringBenchmark
{
    // [Benchmark]
    // public void StringConcatenation()
    // {
    //     string result = "";

    //     for (int i = 0; i < 100; i++)
    //     {
    //         result += "Academy";
    //     }
    // }

    // [Benchmark]
    // public void StringBuilderConcatenation()
    // {
    //     StringBuilder result = new StringBuilder();

    //     for (int i = 0; i < 100; i++)
    //     {
    //         result.Append("Academy");
    //     }
    // }

    [Params(100, 1000, 10000, 100000)]
    public int Iterations;

    [Benchmark]
    public void StringConcatenation()
    {
        string result = "";

        for (int i = 0; i < Iterations; i++)
        {
            result += "Academy";
        }
    }

    [Benchmark]
    public void StringBuilderConcatenation()
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < Iterations; i++)
        {
            result.Append("Academy");
        }
    }
}