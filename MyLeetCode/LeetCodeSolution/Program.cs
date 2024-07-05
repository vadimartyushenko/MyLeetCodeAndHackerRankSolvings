using LeetCodeSolution;

var task_name = "TwoSum";

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
    default:
        throw new ArgumentException("Unexpected task");
}