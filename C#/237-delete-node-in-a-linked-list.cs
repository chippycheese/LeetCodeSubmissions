/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        UpdateNode(node, node.next);
    }

    public void UpdateNode(ListNode currentNode, ListNode nextNode){
        if(currentNode == null || currentNode.next == null){
            return;
        }
        currentNode.val = nextNode.val;
        if(nextNode.next == null){
            currentNode.next = null;
        }else{
            UpdateNode(currentNode.next, nextNode.next);
        }
    }
}