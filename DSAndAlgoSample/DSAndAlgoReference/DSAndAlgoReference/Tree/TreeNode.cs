using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.Tree
{
    public class TreeNode
    {
        public int Data { get; }
        public TreeNode Left, Right;

        public TreeNode(int data)
        {
            Left = Right = null;
            Data = data;
        }
    }
}
