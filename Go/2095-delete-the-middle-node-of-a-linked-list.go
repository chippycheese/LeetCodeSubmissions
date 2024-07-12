/**
 * Definition for singly-linked list.
 * type ListNode struct {
 *     Val int
 *     Next *ListNode
 * }
 */
func deleteMiddle(head *ListNode) *ListNode {
    node2 := head.Next
    node1 := head
    
    for(node2 != nil && node2.Next != nil && node2.Next.Next != nil){
        node1 = node1.Next
        node2 = node2.Next.Next
    }

    if(node1.Next != nil){
        node1.Next = node1.Next.Next
    }else{
        head = nil
    }
    
    return head
}