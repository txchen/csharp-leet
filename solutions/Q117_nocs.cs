// no cs yet, this is javascript

/**
 * Definition for binary tree with next pointer.
 * function TreeLinkNode(val) {
 *     this.val = val;
 *     this.left = this.right = this.next = null;
 * }
 */
 /**
  * Definition for binary tree with next pointer.
  * function TreeLinkNode(val) {
  *     this.val = val;
  *     this.left = this.right = this.next = null;
  * }
  */

 /**
  * @param {TreeLinkNode} root
  * @return {void} Do not return anything, modify tree in-place instead.
  */
 var connect = function(root) {
     if (!root) {
         return
     }
     connectInt(root, null)
 };

 function connectInt(node, parentNext) {
     while (parentNext && !parentNext.left && !parentNext.right) {
         parentNext = parentNext.next
     }
     if (parentNext) {
         if (parentNext.left) {
             node.next = parentNext.left
         } else if (parentNext.right) {
             node.next = parentNext.right
         }
     }
     // now deal with children
     if (node.left && node.right) {
         node.left.next = node.right
         connectInt(node.right, node.next)
         connectInt(node.left, null)
     } else if (node.right) {
         connectInt(node.right, node.next)
     } else if (node.left) {
         connectInt(node.left, node.next)
     }
 }
