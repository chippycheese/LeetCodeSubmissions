/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func isSameTree(p *TreeNode, q *TreeNode) bool {
    a := getExpandedTree(p, make([]int, 0))
    b := getExpandedTree(q, make([]int, 0))
    return areEqual(a, b)
}

func getExpandedTree(root *TreeNode, nodes []int) []int {
    if(root == nil){
        nodes = append(nodes, -99999)
        return nodes
    }
    nodes = append(nodes, root.Val)
    nodes = getExpandedTree(root.Left, nodes)
    nodes = getExpandedTree(root.Right, nodes)
    return nodes
}

func areEqual(a []int, b []int) bool {
    if(len(a) != len(b)) {
        return false
    }
    i := 0
    for(i < len(a)) {
        if a[i] != b[i] {
            return false
        }
        i ++
    }
    
    return true
}