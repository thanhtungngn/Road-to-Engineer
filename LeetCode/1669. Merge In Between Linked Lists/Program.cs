// See https://aka.ms/new-console-template for more information
using Common;


ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
{
    ListNode removal = new ListNode();
    var result = new List<int>();
    while(list1 != null)
    {
        if(a > 0)
        {
            result.Add(list1.val);
            a--;
            b--;
        }
        else if( a <=0 && b >0 )
        {
            result.Add(list2.val);
            list2 = list2.next;
            b--;
        }
        else
        {
            result.Add(list1.val);
        }
        list1 = list1.next;

    }

    ListNode merge = new ListNode();
    for (int i = 0; i< result.Count; i++)
    {
        merge = new ListNode(result[i],merge);
    }
    return merge;
}