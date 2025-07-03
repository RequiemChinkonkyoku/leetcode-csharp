using System;
using System.Text;

public class Program
{
    static void Main()
    {
        var sol = new Solution();

        //Testcases
        ListNode l1 = new ListNode(1);
        ListNode current = l1;

        for (int i = 0; i < 29; i++)
        {
            current.next = new ListNode(0);
            current = current.next;
        }

        current.next = new ListNode(1); // Last node


        // Build l2: 5 -> 6 -> 4
        ListNode l2 = new ListNode(5);
        l2.next = new ListNode(6);
        l2.next.next = new ListNode(4);

        // Call solution
        ListNode result = sol.AddTwoNumbers(l1, l2);

        // Print the result
        while (result != null)
        {
            Console.Write(result.val);
            if (result.next != null) Console.Write(", ");
            result = result.next;
        }
        Console.WriteLine();
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode current1 = l1;
        ListNode current2 = l2;
        ListNode result = new ListNode();
        ListNode current = result;
        
        int temp = current1.val + current2.val;
        
        int carry = temp / 10;
        if (carry != 0)
        {
            current.val = temp % 10;
        }
        else
        {
            current.val = temp;
        }

        current1 = current1.next;
        current2 = current2.next;

        while (current1 != null && current2 != null)
        {
            current.next = new ListNode();
            current = current.next;
            int temp1 = current1.val + current2.val + carry; 
            carry = temp1 / 10;
            if (carry != 0)
            {
                current.val = temp1 % 10;
            }
            else
            {
                current.val = temp1;
            }
            
            current1 = current1.next;
            current2 = current2.next;
        }

        if (current1 != null)
        {
            while (current1 != null)
            {
                current.next = new ListNode();
                current = current.next;
                
                int temp1 = current1.val + carry; 
                carry = temp1 / 10;
                if (carry != 0)
                {
                    current.val = temp1 % 10;
                }
                else
                {
                    current.val = temp1;
                }

                current1 = current1.next;
            }
        }
        
        if (current2 != null)
        {
            while (current2 != null)
            {
                current.next = new ListNode();
                current = current.next;

                int temp1 = current2.val + carry; 
                carry = temp1 / 10;
                if (carry != 0)
                {
                    current.val = temp1 % 10;
                }
                else
                {
                    current.val = temp1;
                }
                
                current2 = current2.next;
            }
        }

        if (carry != 0)
        {
            current.next = new ListNode();
            current = current.next;
            current.val = carry;
        }
        
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
}