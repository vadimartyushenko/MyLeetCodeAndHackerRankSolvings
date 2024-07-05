namespace LeetCodeSolution;

public static class FindCenterSolution
{
    public static void Solve()
    {
        int[][] edges = [[1, 2], [2, 3], [4, 2]];
        var result = FindCenter(edges);
    }
    
    static int FindCenter(int[][] edges)
    {
        return edges[0][0] == edges[1][0] ? edges[0][0] : edges[0][0] == edges[1][1] ? edges[0][0] : edges[0][1];
    }
    
}