namespace LeetCodeSolution;

public static class AddTwoNumbersSolution
{
    public static void Solve()
    {
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(0, new ListNode(4));
        var result = AddTwoNumbers(l1, l2);
    }
    
    static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var remind = 0;
        var result = new ListNode();
        var next = result;
        while (true)
        {
            var value = (l1?.val ?? 0) + (l2?.val ?? 0) + remind;
            remind = value / 10;
            next.val = value % 10;
            if (l1?.next == null && l2?.next == null && remind == 0)
                break;
            next.next = new ListNode();
            next = next.next;
            l1 = l1?.next;
            l2 = l2?.next;
        } 
        return result;
    }
    
    public class ListNode {
        public int val;
        public ListNode next;
     
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next; 
        }
    }
}
