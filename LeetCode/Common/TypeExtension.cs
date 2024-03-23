namespace Common
{
    public static class TypeExtension
    {
        public static string Print(this int[] array)
        {
            var result = String.Join(", ", array);
            return result;

        }

        public static string Print(this IList<string> array)
        {
            var result = String.Join(", ", array);
            return result;

        }

        public static string Print(this long[] array)
        {
            var result = String.Join(", ", array);
            return result;

        }

        public static string Print(this int[][] array)
        {
            var result = string.Empty;
            for (int i = 0; i < array.Length; i++) {
                if (array[i] != null )
                {
                    result += string.Join(", ", array[i]) + "\n";

                }
            }
            return result;
        }

        public static string Print(this ListNode listNode)
        {
            var result = String.Empty;
            while (listNode != null)
            {
                result = result + listNode.val + " -> ";
                listNode = listNode.next;
            }
            result = result + " null";
            return result;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public ListNode ReverseList(ListNode head)
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
    }

   

}


