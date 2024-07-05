namespace LeetCodeSolution;

public class TwoSumSolution
{
    public static void Solve()
    {
        int[] nums = [2,7,11,15];
        int target = 9;
        var result = TwoSum(nums, target);
    }

    static int[] TwoSum(int[] nums, int target)
    {
        var orderNum = nums.Select((num, idx) => (idx, num)).OrderByDescending(x => x.num).ToArray();
        if (orderNum.Length == 2)
            return orderNum.Select(x => x.idx).ToArray();

        int i = 0, j = orderNum.Length - 1;
        while (true)
        {
            var sum = orderNum[i].num + orderNum[j].num;
            if (sum == target)
                return [orderNum[i].idx, orderNum[j].idx];
            else if (sum > target)
                i++;
            else
                j--;
        }
    }
}