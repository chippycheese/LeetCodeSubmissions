/**
 * Definition for singly-linked list.
 * type ListNode struct {
 *     Val int
 *     Next *ListNode
 * }
 */
func hasCycle(head *ListNode) bool {
    if(head == nil){
        return false
    }
    slow := head
    fast := head
    for(fast.Next != nil && fast.Next.Next != nil){
        fast = fast.Next
        if(slow == fast){
            return true
        }
        slow = slow.Next
        fast = fast.Next
        if(slow == fast){
            return true
        }
    }
    return false
}