/**
 * Definition for singly-linked list.
 * type ListNode struct {
 *     Val int
 *     Next *ListNode
 * }
 */
 func mergeTwoLists(list1 *ListNode, list2 *ListNode) *ListNode {
    
    
    var finalListPointer *ListNode

    if (list1 == nil && list2 == nil){

    }else if (list1 == nil){
        finalListPointer = list2;
        if(list2.Next == nil){
            list2 = nil
        }else{
            list2 = list2.Next
        }
    }else if(list2 == nil){
        finalListPointer = list1;
        if(list1.Next == nil){
            list1 = nil
        }else{
            list1 = list1.Next
        }
    }else if(list1.Val < list2.Val){
        finalListPointer = list1;
        if(list1.Next == nil){
            list1 = nil
        }else{
            list1 = list1.Next
        }
    }else{
        finalListPointer = list2;
        if(list2.Next == nil){
            list2 = nil
        }else{
            list2 = list2.Next
        }
    }
    var list3 = finalListPointer

    for{
        if (list1 == nil && list2 == nil){
            break;
        }

        if (list1 == nil){
            finalListPointer.Next = list2;
            if(list2.Next == nil){
                list2 = nil
            }else{
                list2 = list2.Next
            }
        }else if(list2 == nil){
            finalListPointer.Next = list1;
            if(list1.Next == nil){
                list1 = nil
            }else{
                list1 = list1.Next
            }
        }else if(list1.Val < list2.Val){
            finalListPointer.Next = list1;
            if(list1.Next == nil){
                list1 = nil
            }else{
                list1 = list1.Next
            }
        }else{
            finalListPointer.Next = list2;
            if(list2.Next == nil){
                list2 = nil
            }else{
                list2 = list2.Next
            }
        }
        finalListPointer = finalListPointer.Next


    }

    return list3;   
}