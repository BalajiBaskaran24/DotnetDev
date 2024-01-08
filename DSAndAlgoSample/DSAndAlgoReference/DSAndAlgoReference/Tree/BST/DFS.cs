using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.Tree.BST
{
    /// <summary>
    /// Tree traversal: Depth First Search 
    /// </summary>
    public class DFS
    {
        public static void PreorderTraversal(TreeNode node)
        {
            if (node == null)
                return;

            Console.WriteLine($"Value: {node.Data}");
            PreorderTraversal(node.Left);
            PreorderTraversal(node.Right);
        }

        public static void InorderTraversal(TreeNode node)
        {
            if (node == null)
                return;

            InorderTraversal(node.Left);
            Console.WriteLine($"Value: {node.Data}");
            InorderTraversal(node.Right);
        }

        public static void PostorderTraversal(TreeNode node)
        {
            if (node == null)
                return;

            PostorderTraversal(node.Left);
            PostorderTraversal(node.Right);
            Console.WriteLine($"Value: {node.Data}");
        }
    }
}
