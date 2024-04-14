# Definition for a binary tree node.
# class TreeNode
#     attr_accessor :val, :left, :right
#     def initialize(val = 0, left = nil, right = nil)
#         @val = val
#         @left = left
#         @right = right
#     end
# end
# @param {TreeNode} root
# @return {Integer}
def sum_of_left_leaves(root)
    @count = 0
    root.val = 0

    unless root.left.nil?
        @count = @count + root.left.val
        node_check(root.left)
    end
    unless root.right.nil?
        root.right.val = 0
        node_check(root.right)
    end

    return @count

end

def node_check(treeNode)

    if treeNode.left.nil? &&  treeNode.right.nil?
        treeNode.val = 0
    end
    @count = @count - treeNode.val
    
    unless treeNode.left.nil?  
        @count = @count + treeNode.left.val
        node_check(treeNode.left)
    end
    unless treeNode.right.nil?
        treeNode.right.val = 0
        node_check(treeNode.right)
    end
    
end