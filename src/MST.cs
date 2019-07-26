using System;
using System.Collections.Generic;

namespace MST_Prim
{
    //
    //Implementation of MST Prim's Algorithm
    //Using 'Min Heap' to implement Q
    //number of steps= |V| + log(|V|) + |V| + |V|*log(|V|) + |V|*|E|
    //runtime: O(|V|*log(|V|))
    //
    //Ahmed Ibrahim Mahmoud Ibrahim
    //Sec. 1
    //
    //Dept. of Computers Science  
    //Analysis and Design of Algorithms (3rd Year) 
    //Fall 2017/2018 
    //
    //Input: Undirected Weighted Graph G, start vertex r
    //Output: Minimum Spanning Tree  MST
    //
    class MSTPrim
    {
        public List<Vertex> MST;
        public MSTPrim()
        {
            MST = new List<Vertex>();
        }
        public void MST_Prim(Graph G, Vertex r)
        {
            foreach (Vertex u in G.V)
            {
                u.key = int.MaxValue;
                u.pi = null;
            }
            //
            r.key = 0;
            //using Q min priority queue implemented with min heap
            Min_Priority_Queue Q = new Min_Priority_Queue(G.V);
            //
            while (Q.heapsize >= 0)
            {
                Vertex u = Q.extract_Min();
                MST.Add(u);
                foreach (Vertex v in u.adj)
                {
                    if (v.is_Element_of_Q && G.w(u, v) < v.key)
                    {
                        v.pi = u;
                        Q.decrease_Key(v.i, G.w(u, v));  //v.key = G.w(u, v);
                    }
                }
            }
            //
            MST.Remove(r); // MST = { ( v, v.pi ) : v element of  V - {r} }
        }
        //
        public void print()
        {
            int cost = 0;
            string route = "";
            //
            Console.WriteLine("\n-----------    |||Minimum Spaninning Tree|||    -----------\n");
            foreach (Vertex v in MST)
            {
                string vertex = v.label;
                string parent = v.pi.label;
                int weight = v.key;
                //
                Console.WriteLine("# "+ vertex+ " > " + parent + " :  " + weight);
                route += " >>> "+ vertex + parent;
                cost += v.key;
            }
            Console.WriteLine("\n:: Minimum Spaninning Tree: " + route + "\n");
            Console.WriteLine("\n:: Cost of MST: "+ cost +"\n");
            Console.WriteLine("\n-----------    |||          End          |||    -----------\n");

        }
    }
}
