using LeetCodeSolution;

var task_name = "LengthOfLongestSubstring";

switch (task_name)
{
    case "AddTwoNumbers":
        AddTwoNumbersSolution.Solve();
        break;
    case "FindCenter":
        FindCenterSolution.Solve();
        break;
    case "TwoSum":
        TwoSumSolution.Solve();
        break;
    case "LengthOfLongestSubstring":
        LengthOfLongestSubstringSolution.Solve();
        break;
    default:
        throw new ArgumentException("Unexpected task");
}