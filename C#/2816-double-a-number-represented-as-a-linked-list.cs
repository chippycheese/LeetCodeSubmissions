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
    public ListNode DoubleIt(ListNode head) {
        var extra = DoubleNode(head);
        if(extra == 0){
            return head;
        }else{
            return new ListNode(1, head);
        }
    }

    public int DoubleNode(ListNode node){
        var extra = 0;
        if(node.next != null){
            extra = DoubleNode(node.next);
        }
        node.val = node.val * 2 + extra;
        if(node.val >= 10){
            node.val -= 10;
            return 1;
        }
        return 0;
    }
}