using LeetCodeSolution;

var task_name = "FindCenter";

switch (task_name)
{
    case "AddTwoNumbers":
        AddTwoNumbersSolution.Solve();
        break;
    case "FindCenter":
        FindCenterSolution.Solve();
        break;
    default:
        throw new ArgumentException("Unexpected task");
}