/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

        ListNode finalList = null;

        int carry = 0;
        do{
            ListNode f1 = addValues(l1,l2,carry);
            carry = SetCarryValue(f1);
            if(l1 != null){
                l1 = l1.next;
            }
            if(l2 != null){
                l2 = l2.next;
            }
            
            finalList = PlaceNode(finalList, f1);
        }while(l1 != null || l2 != null || carry != 0);
        return finalList;
    }

    public ListNode PlaceNode(ListNode f1, ListNode p1){
        ListNode l1 = f1;
        if(l1 == null){
            return p1;
        }
        
        while(l1.next != null){
            l1 = l1.next;
        }
        l1.next = p1;
        return f1;
    }
    

    public ListNode addValues(ListNode n1, ListNode n2, int carry){
        ListNode l1 = new ListNode();
        if(n2 == null && n1 == null){
            l1.val = carry;
        }else if(n2 == null){
            l1.val = n1.val + carry;
        }else if(n1 == null){
            l1.val = n2.val + carry;
        }else{
            l1.val = n1.val+n2.val+carry;
        }
        return l1;
    }

    public int SetCarryValue(ListNode l1){
        if(l1.val >= 10){
            l1.val -= 10;
            return 1;
        }else{
            return 0;
        }
    }

    

    public ListNode FlipList(ListNode l1){
        ListNode previous = null;
        ListNode current = l1;
        ListNode next = l1;

        while(current != null){
            next = next.next;
            current.next = previous;
            previous = current;
            current = next;
            
        }
        return previous;
    }
    

    public int ConvertToInteger(ListNode la){
        String s1 = String.Empty;
        do{
            s1 = s1 + la.val.ToString();
            la = la.next;
        } while(la != null);
        return Int32.Parse(s1);
    }
    
    public ListNode ConvertToListNode(int number){
        String s1 = number.ToString();
        ListNode l1 = null;
        for(int a = s1.Length-1; a >= 0 ; a--){
            ListNode l2 = new ListNode();
            int n1 = s1[a] - '0';
            l2.val = n1;
            l2.next = l1;
            l1 = l2;
        }

        return l1;

    }

}