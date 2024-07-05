namespace LeetCodeSolution;

internal class LengthOfLongestSubstringSolution
{
    public static void Solve()
    {
        
        string s = "abcabcbb";
        var result = LengthOfLongestSubstring(s);
    }

    static int LengthOfLongestSubstring(string s)
    {
        int max = 1, current = 1;
        var span = s.AsSpan();
        for (int i = 1; i < span.Length; ++i) {
            if (span[i - 1] != span[i])
                ++current;
            else
                current = 1;
            if (current > max)
                max = current;
        }
        return max;
    }
}
