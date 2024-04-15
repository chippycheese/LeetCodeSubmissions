/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number}
 */
var sumNumbers = function(root) {

    var sumNumbers = [];

    addToNumber(root, "0", sumNumbers);

    //sum up heap
    var totalSum = 0;
    for(var cnt = 0; cnt < sumNumbers.length; cnt++){
        totalSum += parseInt(sumNumbers[cnt]);
    }
    return totalSum;
};

function addToNumber(treeNode, currentValue, numbers){

    currentValue = currentValue + treeNode.val.toString();
    
    if(treeNode.left === null && treeNode.right === null){
        numbers.push(currentValue);
        currentValue.slice(0, -1)
    }else{
        if(treeNode.left !== null){
            addToNumber(treeNode.left,currentValue, numbers);
        }
        if(treeNode.right !== null){
            addToNumber(treeNode.right,currentValue, numbers);
        }
    }
    
}