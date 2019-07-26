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
    //
    class Test
    {
        static void Main(string[] args)
        {
            ////////////Testing/////////////
            //
            //test sample Graph G1
            //
            Vertex a = new Vertex("a");
            Vertex b = new Vertex("b");
            Vertex c = new Vertex("c");
            Vertex d = new Vertex("d");
            Vertex e = new Vertex("e");
            Vertex f = new Vertex("f");
            Vertex g = new Vertex("g");
            Vertex h = new Vertex("h");
            Vertex i = new Vertex("i");
            Vertex[] V1 = new Vertex[] { a, b, c, d, e, f, g, h, i };
            //
            Edge[] E1 = new Edge[]
            {
                new Edge(a,b,4),
                new Edge(a,h,8),
                new Edge(b,c,8),
                new Edge(b,h,11),
                new Edge(c,d,7),
                new Edge(c,i,2),
                new Edge(c,f,4),
                new Edge(d,e,9),
                new Edge(d,f,14),
                new Edge(e,f,10),
                new Edge(f,g,2),
                new Edge(g,i,6),
                new Edge(g,h,1),
                new Edge(h,i,7),
            };
            //
            Dictionary<KeyValuePair<Vertex, Vertex>, Edge> Edges1 = new Dictionary<KeyValuePair<Vertex, Vertex>, Edge>();
            Add_TO_Edges_Dictionary(ref Edges1, E1);
            //
            Graph G1 = new Graph(V1, Edges1);
            //
            MSTPrim myMST1 = new MSTPrim();
            myMST1.MST_Prim(G1, G1.V[0]);
            myMST1.print();
            //
            //
            //
            //test sample Graph G2
            //
            Vertex A = new Vertex("A");
            Vertex B = new Vertex("B");
            Vertex C = new Vertex("C");
            Vertex D = new Vertex("D");
            Vertex E = new Vertex("E");
            Vertex F = new Vertex("F");
            Vertex[] V2 = new Vertex[] { A, B, C, D, E, F };
            //
            Edge[] E2 = new Edge[]
            {
                new Edge(A,B,1),
                new Edge(A,D,1),
                new Edge(A,F,5),
                new Edge(B,C,6),
                new Edge(B,E,2),
                new Edge(C,D,3),
                new Edge(C,F,4),
                new Edge(D,E,3),
                new Edge(E,F,2)
            };
            Dictionary<KeyValuePair<Vertex, Vertex>, Edge> Edges2 = new Dictionary<KeyValuePair<Vertex, Vertex>, Edge>();
            Add_TO_Edges_Dictionary(ref Edges2, E2);
            //
            Graph G2 = new Graph(V2, Edges2);
            //
            MSTPrim My_MST2 = new MSTPrim();
            My_MST2.MST_Prim(G2, G2.V[0]);
            //
            My_MST2.print();
            //
            //
            Console.ReadKey();
        }

        private static void Add_TO_Edges_Dictionary(ref Dictionary<KeyValuePair<Vertex, Vertex>, Edge> E, Edge[] edges)
        {
            foreach (Edge  e in edges)
            {
                E.Add(new KeyValuePair<Vertex, Vertex>(e.v, e.w), e);

            }
        }
    }
}
