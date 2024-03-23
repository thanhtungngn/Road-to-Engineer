// See https://aka.ms/new-console-template for more information
using Common;

var listNode = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, null))));
ReorderList(listNode);

Console.WriteLine(listNode.Print());

void ReorderList( ListNode head)
{
    var first = head;
    ListNode current = null;
    var reverse = ReverseList(head);

    while (first != null || reverse != null)
    {

        current = new ListNode(reverse.val, new ListNode(first.val, current));
        reverse = reverse.next;
        first = first.next;
    }
    var result = ReverseList(current);

    while(result != null )
    {
        if( head == null)
        {
            head = result;
            break;
        }
        head.val = result.val;
        head = head.next;
        result = result.next;
    }

}

ListNode ReverseList(ListNode head)
{
    if (head == null) return null;
    var newHead = new ListNode(head.val, null);

    while (head.next != null)
    {
        newHead = new ListNode(head.next.val, newHead);
        head = head.next;
    }

    return newHead;
}