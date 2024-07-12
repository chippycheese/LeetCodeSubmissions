/**
 * Definition for singly-linked list.
 * type ListNode struct {
 *     Val int
 *     Next *ListNode
 * }
 */
func reverseList(head *ListNode) *ListNode {
    if(head == nil){
        return head
    }

    return reassign(head, head.Next)
}

func reassign(previous *ListNode, head *ListNode) *ListNode{
    if(head == nil){
        return previous
    }
    finalHead := reassign(head, head.Next)
    previous.Next = nil
    head.Next = previous
    return finalHead
}