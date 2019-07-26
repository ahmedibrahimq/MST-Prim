using System.Collections.Generic;

namespace MST_Prim
{
    //
    //Custom vertex for Prim's Algorithm
    //
    //Ahmed Ibrahim Mahmoud Ibrahim
    //Sec. 1
    //

    class Vertex
    {
        public int key { get; set; }
        public Vertex pi;
        public LinkedList<Vertex> adj;
        public string label;
        public bool is_Element_of_Q;
        public int i; // index in the min priority queue, for Line 11 in Prim's Algorithm, for Deacrease-Key
        public Vertex(string label)
        {
            this.i = 0;
            this.label = label;
            this.is_Element_of_Q = true;
            pi = null;
            adj = new LinkedList<Vertex>();
        }
    }
}
