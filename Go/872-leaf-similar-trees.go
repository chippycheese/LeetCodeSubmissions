/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func leafSimilar(root1 *TreeNode, root2 *TreeNode) bool {
    var tree1Leaves []int
    var tree2Leaves []int

    tree1Leaves = tree(root1, tree1Leaves)
    tree2Leaves = tree(root2, tree2Leaves)

    if(len(tree1Leaves) != len(tree2Leaves)){
        return false
    }

    a := 0
    for(a < len(tree1Leaves)){
        if(tree1Leaves[a] != tree2Leaves[a]){
            return false
        }
        a ++
    }
    return true
    
}

func tree(root *TreeNode, leaves []int) []int {
    
    if(root.Left != nil){
        leaves = tree(root.Left, leaves)
    }
    if(root.Right != nil){
        leaves = tree(root.Right, leaves)
    }
    if(root.Left == nil && root.Right == nil){
        
        leaves = append(leaves, root.Val)
    }
    
    return leaves
    
}