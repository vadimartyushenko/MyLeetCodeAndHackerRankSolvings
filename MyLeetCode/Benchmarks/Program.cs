using BenchmarkDotNet.Running;
using RandomString4Net;
using System.Drawing;

namespace Benchmarks;

internal class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<LengthOfLongestSubstringBench>();
    }
}
