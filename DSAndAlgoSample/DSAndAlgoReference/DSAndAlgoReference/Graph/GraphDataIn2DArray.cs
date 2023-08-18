using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.Graph
{
    public class GraphDataIn2DArray
    {
        //Sample graph
        //1-------3--------------|
        //|       |              |
        //|       |              5
        //|       |              |
        //2-------4--------------|


        /// <summary>
        /// Adjacency matric to represent graph
        /// Space adj[n+1][n+1]. Requires more space
        /// </summary>
        public static void Usage()
        {
            //Input - total elements(n), edge count(m)
            //All edges. I.e. m edges
            //For above graph the possible edges are
            //[1,3] [1,2] [2,1] [2,4] [3,1]
            //[3,5] [3,4] [4,3] [4,2] [4,5]
            //[5,3] [5,4] 
            int n = 5;
            int m = 12;//number of edges
            int[,] AdjMatrix = new int[n + 1, n + 1];
            //To store
            //For the above row*column in 2D array set the value as 1 to indicate that 
            //there is an edge
            int edgR = 0, edgC = 0;//Scan this data from user for each iteration in below loop
            for (int i = 0; i < m; i++)
            {
                AdjMatrix[edgR, edgC] = 1;
                //Below line is required if its undirected graph. For directed graph edge direction is based on input
                AdjMatrix[edgC, edgR] = 1;
            }
        }
    }
}
