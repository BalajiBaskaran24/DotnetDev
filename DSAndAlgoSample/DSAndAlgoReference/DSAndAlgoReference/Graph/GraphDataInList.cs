using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.Graph
{
    public class GraphDataInList
    {
        //Sample graph
        //1-------3--------------|
        //|       |              |
        //|       |              5
        //|       |              |
        //2-------4--------------|


        /// <summary>
        /// List to represent graph
        /// Space: Twice of edges
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
            List<List<int>> graph = new List<List<int>>();
            List<List<EdgeWithWeight>> weightedGraph = new List<List<EdgeWithWeight>>();
            List<List<Tuple<int, double>>> weightedGraphTup = new List<List<Tuple<int, double>>>();
            //To store
            //Use graph of size n. Each element in graph is graph<int> to represent all nodes assciated with current node
            //For the above case the data will be stored in this format
            //1 -> {3,2}
            //2 -> {1,4}
            //3 -> {1,4,5}
            //4 -> {2,3,5}
            //5 -> {3,4}
            int edjR = 0, edjC = 0, Weight = 0;
            for (int i = 0; i < m; i++)
            {
                graph[edjR].Add(edjC);//Ex: 1,3
                //Below line is not required for directed graph. Since the edge direction as per input
                graph[edjC].Add(edjR);//Ex: 3,1

                //For weighted graph
                weightedGraph[edjR].Add(new EdgeWithWeight() { NodeVal = edjC, NodeWeight = Weight });
                weightedGraphTup[edjR].Add(new Tuple<int, double>(edjC, Weight));//Using tuple
            }
        }
    }

    public class EdgeWithWeight
    {
        public int NodeVal;
        public int NodeWeight;
    }
}
