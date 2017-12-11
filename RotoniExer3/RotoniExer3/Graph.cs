using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotoniExer3
{
    public class Graph // This is where I put all my methods.
    {
        LinkedList[] AdjList;
        public int VertexNumber;

        public Graph(int x) // This is where you create a graph and inialize the number of vertices.
        {
            AdjList = new LinkedList[x];
            for (int i = 0; i < AdjList.Length; i++)
            {
                AdjList[i] = new LinkedList();
            }

            VertexNumber = x;
        }


        public void EnQ(int x, int y) // This is where I add or enqueue the adjacent vertices.
        {
            AdjList[x].EnQ(y);
        }

        public void DFSPrint(Form1 form1) // This is where I print the final order of Depth First Traversal
        {
            bool[] visited = new bool[VertexNumber]; // This is where you mark all the vertices unvisited
            for (int i = 0; i < VertexNumber; i++)
            {
                visited[i] = false;
            }

            string PrintValue = "";
            bool blank = false;
            int x = 0;
            DepthFirstSearch(0, visited, ref PrintValue, ref blank, x); // This is where you call the recursive function and perform the Depth First Traversal
            form1.label1.Text = String.Format("The Depth First Traversal(DFS) is: " + PrintValue);
        }

        public void DFSearch(Form1 form1, int x) // This is where I search the inserted value in Graph 1 using Depth First Search
        {
            bool[] visited = new bool[VertexNumber]; // This is where you mark all the vertices unvisited
            for (int i = 0; i < VertexNumber; i++)
            {
                visited[i] = false;
            }

            string blank = "";
            bool found = false;
            DepthFirstSearch(0, visited, ref blank, ref found, x); // This is where you call the recursive function and perform the Depth First Traversal

            if (found == true)
            {
                form1.label1.Text = String.Format("Found! Vertex {0} is in Graph 1!", x); // Prints a message if the inserted value is in the Graph
            }
            else
            {
                form1.label1.Text = String.Format("There is no vertex {0} in Graph 1.", x); // Prints a message if the inserted value is not in the Graph
            }
        }

        public void DepthFirstSearch(int v, bool[] visited, ref string PrintValue, ref bool found, int x)
        {
            visited[v] = true; // It marks the vertex if it has visited.
            PrintValue = PrintValue + v + " "; // Stores all the visited vertices 

            LinkedList list = AdjList[v]; 
            Node temp;
            temp = list.Head;

            for (; temp != null; temp = temp.Next) // Will go to the adjacent vertex 
            {
                if (v == x) // Will compare the inserted value and the vertex. 
                {
                    found = true;
                }
                if (!visited[temp.Vertex]) // It will recur if the vertex has not visited yet
                {
                    DepthFirstSearch(temp.Vertex, visited, ref PrintValue, ref found, x);
                }
            }
        }

        public void BFSPrint(Form1 form1) // This is where I print the final order of Breadth First Traversal
        {
            bool blank = false;
            string PrintValue = "";
            int blank1 = 0;
            BreadthFirstSearch(blank1, ref blank, ref PrintValue);
            form1.label1.Text = String.Format("The Breadth First Traversal(BFS) is: " + PrintValue);
        }

        public void BFSearch(Form1 form1, int x) // This is where I search the inserted value in Graph 2 using Breadth First Search
        {
            bool found = false;
            string blank = "";
            BreadthFirstSearch(x, ref found, ref blank);

            if (found == true)
            {
                form1.label1.Text = String.Format("Found! Vertex {0} is in Graph 2!", x); // Prints a message if the inserted value is in the Graph
            }
            else
            {
                form1.label1.Text = String.Format("There is no vertex {0} in Graph 2.", x); // Prints a message if the inserted value is not in the Graph
            }
        }

        public void BreadthFirstSearch(int x, ref bool found, ref string PrintValue)
        {
            bool[] visited = new bool[VertexNumber]; // This is where you mark all the vertices unvisited
            for (int i = 0; i < VertexNumber; i++)
            {
                visited[i] = false;
            }

            LinkedList Queue = new LinkedList(); // This is where you create queue for Breadth First Search
            int q = 0;
            visited[q] = true;
            Queue.EnQ(q);

            while (Queue.Head != null) // Will loop until all the vertices has visited
            {
                q = Queue.Head.Vertex;
                PrintValue = PrintValue + q + " "; // Stores all the visited vertices 
                if (q == x) // Will compare the inserted value and the vertex. 
                {
                    found = true;
                }
                Queue.DeQ(); // Will remove the value if it has already visited


                LinkedList list = AdjList[q];
                Node temp;
                temp = list.Head;

                for (; temp != null; temp = temp.Next) // Will go to the adjacent vertex 
                {
                    if (!visited[temp.Vertex])
                    {
                        visited[temp.Vertex] = true; // It marks the vertex if it has visited.
                        Queue.EnQ(temp.Vertex);
                    }
                }
            }
        }

    }

}
