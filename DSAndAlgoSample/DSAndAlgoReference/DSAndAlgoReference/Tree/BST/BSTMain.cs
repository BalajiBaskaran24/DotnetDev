using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.Tree.BST
{
    internal class BSTMain
    {
        public static void Starter()
        {
            TreeNode SampleBST = TreeConstruct.GenerateSampleBST();
            DFS.PreorderTraversal(SampleBST);
            DFS.PostorderTraversal(SampleBST);
            DFS.InorderTraversal(SampleBST);
        }
    }
}
