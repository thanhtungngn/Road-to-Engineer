// See https://aka.ms/new-console-template for more information
using Common;

Console.WriteLine("Hello, World!");

bool IsPalindrome(ListNode head)
{
    var current = head;
    var listValue = new List<int>();
    while (current != null)
    {
        listValue.Add(current.val);
        current = current.next;
    }

    for (int i = listValue.Count - 1; i >= 0; i--)
    {
        if(head.val != listValue[i])
        {
            return false;
        }
        head = head.next;
    }

    return true;
}