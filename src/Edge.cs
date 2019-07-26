namespace MST_Prim
{
    //
    //Ahmed Ibrahim Mahmoud Ibrahim
    //Sec. 1
    //
    class Edge
    {
        public Vertex v;
        public Vertex w;
        public int weight;
        public Edge(Vertex v, Vertex w, int weight)
        {
            this.v = v;
            this.w = w;
            this.weight = weight;
        }
    }
}
