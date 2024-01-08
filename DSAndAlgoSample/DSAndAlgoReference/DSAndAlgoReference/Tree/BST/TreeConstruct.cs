using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.Tree.BST
{
    public class TreeConstruct
    {
        public TreeConstruct() { }

        public static TreeNode GenerateSampleBST()
        {
            TreeNode SampleBST = new TreeNode(10);//Root
            SampleBST.Left = new TreeNode(2);
            SampleBST.Right = new TreeNode(3);
            SampleBST.Left.Left = new TreeNode(1);
            SampleBST.Left.Right = new TreeNode(20);

            return SampleBST;
        }
    }
}
