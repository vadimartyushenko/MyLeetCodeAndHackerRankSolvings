using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using RandomString4Net;
using static LeetCodeSolution.LengthOfLongestSubstringSolution;

namespace Benchmarks;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class LengthOfLongestSubstringBench
{
    private static string testStr;

    [Params(10, 100, 1_000)]
    public int Size { get; set; }

    [GlobalSetup]
    public void GlobalSetup()
    {
        testStr = RandomString.GetString(Types.ALPHANUMERIC_MIXEDCASE_WITH_SYMBOLS, Size);
    }

    [Benchmark]
    public void TestDictionaryApproach()
    {
        var result = LengthOfLongestSubstring(testStr);
    }
    [Benchmark]
    public void TestListApproach()
    {
        var result = LengthOfLongestSubstring2(testStr);
    }
}
