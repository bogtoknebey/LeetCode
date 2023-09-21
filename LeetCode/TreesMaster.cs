using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreesMaster
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public static int?[] GetArrayByTree(TreeNode root)
        {
            if (root == null)
            {
                return new int?[0]; // Return an empty array for an empty tree
            }

            List<int?> result = new List<int?>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode current = queue.Dequeue();
                if (current != null)
                {
                    result.Add(current.val);
                    queue.Enqueue(current.left);
                    queue.Enqueue(current.right);
                }
                else
                {
                    result.Add(null); // Use null to represent null nodes in the array
                }
            }

            return result.ToArray();
        }

        public static TreeNode GetTreeByArray(int?[] arr)
        {
            if (arr == null || arr.Length == 0 || arr[0] == null)
            {
                return null; // Return null for an empty or null array or if the root is null
            }

            TreeNode root = new TreeNode(arr[0].Value);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int index = 1;

            while (index < arr.Length)
            {
                TreeNode current = queue.Dequeue();

                if (arr[index] != null) // Check for non-null values in the array
                {
                    current.left = new TreeNode(arr[index].Value);
                    queue.Enqueue(current.left);
                }
                index++;

                if (index < arr.Length && arr[index] != null)
                {
                    current.right = new TreeNode(arr[index].Value);
                    queue.Enqueue(current.right);
                }
                index++;
            }

            return root;
        }


    }
}
