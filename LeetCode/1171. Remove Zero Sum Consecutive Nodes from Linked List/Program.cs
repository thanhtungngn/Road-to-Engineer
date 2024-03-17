// See https://aka.ms/new-console-template for more information
using Common;
Console.WriteLine("Hello, World!");

//Console.WriteLine(RemoveZeroSumSublists(new ListNode(1, new ListNode(2, new ListNode(-3, new ListNode(3, new ListNode(1, null)))))));
//Console.WriteLine(RemoveZeroSumSublists(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(-3, new ListNode(4, null)))))));
Console.WriteLine(RemoveZeroSumSublists(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(-3, new ListNode(-2, null)))))).Print());

ListNode RemoveZeroSumSublists(ListNode head)
{
    Dictionary<int, ListNode> dict = new Dictionary<int, ListNode>();
    ListNode node = new ListNode(0, head);
    int sum = 0;

    ListNode current = node;
    while (current is not null)
    {
        sum += current.val;
        dict[sum] = current;
        current = current.next;
    }

    current = node;
    sum = 0;

    while (current is not null)
    {
        sum += current.val;
        current.next = dict[sum].next;
        current = current.next;
    }

    return node.next;

}


