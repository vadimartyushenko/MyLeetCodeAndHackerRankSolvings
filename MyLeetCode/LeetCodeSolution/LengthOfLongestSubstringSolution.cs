using System.Diagnostics;

namespace LeetCodeSolution;

internal class LengthOfLongestSubstringSolution
{
    public static void Solve()
    {
        var s0 = "dvdf";
        var result0 = LengthOfLongestSubstring(s0);
        Debug.Assert(result0 == 3);
        
        var s = "pwwkew";
        var result = LengthOfLongestSubstring(s);
        Debug.Assert(result == 3);
        
        
        var s1 = "bbbbb";
        var result1 = LengthOfLongestSubstring(s1);
        Debug.Assert(result1 == 1);
        
        
        var s2 = "abcabcbb";
        var result2 = LengthOfLongestSubstring(s2);
        Debug.Assert(result2 == 3);
    }

    static int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;
        int max = 1, current = 1;
        var span = s.AsSpan();
        var dict = new Dictionary<char, int> { {span[0], 0} };
        for (var i = 1; i < span.Length; ++i) {
            if (!dict.ContainsKey(span[i])) {
                dict[span[i]] = i;
                ++current;
            } else {
                var ch = span[i];
                foreach (var key in dict.Where(x => x.Value <= dict[ch]).Select(x => x.Key).ToArray())
                    dict.Remove(key);
                dict.Add(ch, i);
                current = dict.Count;
            }

            if (current <= max) 
                continue;
            max = current;
        }
        return max;
    }
}
