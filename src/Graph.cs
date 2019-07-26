using System.Collections.Generic;

namespace MST_Prim
{
    //
    //Implementation of Undirected Weighted Graph
    //
    //Custom Graph for Prim's Algorithm
    //
    //Ahmed Ibrahim Mahmoud Ibrahim
    //Sec. 1
    //
    class Graph
    {
        public Vertex[] V;
        public Dictionary<KeyValuePair<Vertex, Vertex>, Edge> E;
        public Graph(Vertex[] V, Dictionary<KeyValuePair<Vertex, Vertex>, Edge> E) // Using 'Hash Table' To implement G.w(u, v) in Constant Time
        {
            this.V = V;
            this.E = E;
            //
            foreach (Edge e in this.E.Values)
            {
                e.v.adj.AddLast(e.w);
                e.w.adj.AddLast(e.v);
            }
        }
        //
        public int w(Vertex u, Vertex v)
        {
            KeyValuePair<Vertex, Vertex> key = new KeyValuePair<Vertex, Vertex>(u, v);
            //
            if (!E.ContainsKey(key))
            {
                key = new KeyValuePair<Vertex, Vertex>(v, u);
            }
            //
            return E[key].weight;
            //
            //i mean :
            //
            //try { return E[key].weight; }
            //catch (KeyNotFoundException) { key = new KeyValuePair<Vertex, Vertex>(v, u); }
            //
        }
    }
}
