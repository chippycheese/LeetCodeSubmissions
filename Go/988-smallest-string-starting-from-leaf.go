/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
 import "fmt"
 import "sort"
 
 func smallestFromLeaf(root *TreeNode) string {
	 
	 alphabet := "abcdefghijklmnopqrstuvwxyz"
	 completeValues := []string{}
 
	 movingValue := ""
	 
	 transverseNode(root, movingValue, &completeValues, alphabet)
 
	 //sort list and return top result
	 sort.Strings(completeValues)
	 fmt.Println(completeValues)
	 return completeValues[0]
 }
 
 func transverseNode(root *TreeNode, movingValue string, completeValues *[]string, alphabet string) {
 
	 //add letter left of string
	 movingValue = string(alphabet[root.Val]) + movingValue
 
	 if(root.Left != nil){
		 transverseNode(root.Left, movingValue, completeValues, alphabet)
	 }
	 if(root.Right != nil){
		 transverseNode(root.Right, movingValue, completeValues, alphabet)
	 }
	 //if no nodes present add to list
	 if(root.Right == nil && root.Left == nil){
		 *completeValues = append(*completeValues, movingValue);
	 }
 
 }