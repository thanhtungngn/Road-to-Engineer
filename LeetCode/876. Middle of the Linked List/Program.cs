// See https://aka.ms/new-console-template for more information
using Common;
Console.WriteLine("Hello, World!");
Console.WriteLine(MiddleNode(new ListNode(1, new ListNode(2, new ListNode (3, new ListNode(4, new ListNode(5,null)))))).Print());
Console.WriteLine(MiddleNode(new ListNode(1, new ListNode(2, new ListNode (3, new ListNode(4, new ListNode(5,new ListNode(6,null))))))).Print());


ListNode MiddleNode(ListNode head)
{
    int length = 0;
    var currentNode = head;
    while(head != null)
    {
        head = head.next;
        length++;
    }
    var nodeNeeded = length / 2 + 1;
    while(nodeNeeded > 1)
    {
        currentNode = currentNode.next;
        nodeNeeded--;
    }
    return currentNode;
}
