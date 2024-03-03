// See https://aka.ms/new-console-template for more information
using Common;

Console.WriteLine("Hello, World!");
//Console.WriteLine(RemoveNthFromEnd(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))), 2).Print());
Console.WriteLine(RemoveNthFromEnd(new ListNode(1, new ListNode(2)), 2).Print());

/**
 * Definition for singly-linked list.
 * public class listnode {
 *     public int val;
 *     public listnode next;
 *     public listnode(int val=0, listnode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

ListNode RemoveNthFromEnd(ListNode head, int n)
{
    ListNode first = null;
    if (n == 1 && head.next == null)
    {
        return null;
    }
    while (head != null)
    {
        first = new ListNode(head.val, first);
        head = head.next;
    }
    ListNode result = null;
    while (first != null)
    {
        if (n == 1)
        {
            if (first.next != null)
            {
                first.val = first.next.val;
                first.next = first.next.next;
                result = new ListNode(first.val, result);
                first = first.next;

            }
            else
            {
                first = null;
            }
        }
        else
        {
            result = new ListNode(first.val, result);
            first = first.next;
        }

        n--;
    }
    return result;

}



