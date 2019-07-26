namespace MST_Prim
{
    //
    //Implementation of Minimum Priority Queue
    //Using 'Min Heap'
    //runtime: 
    //extract_Min: log(n)
    //decrease_Key: log(n)
    //insert: log(n)
    //
    //
    //Ahmed Ibrahim Mahmoud Ibrahim
    //Sec. 1
    //
    class Min_Priority_Queue :min_Heap
    {
        public Min_Priority_Queue(Vertex[] A): base(A)
        {
            for (int i = 0; i <= heapsize; i++)
            { //Initiate the index of each vertex in the min priority queue, for Line 11 in Prim's Algorithm, for Deacrease-Key
                A[i].i = i;
            }
            //
            build_Min_Heap();
        }
        //
        public Vertex minimum()
        {
            return A[0];
        }
        //
        public Vertex extract_Min()
        {
            if (heapsize < 0) { return null; } // Q is empty
            Vertex min = A[0];
            //
            min.is_Element_of_Q = false;// custom for prim's Algorithm, Line 9, to keeping it in constant time 
            //
            A[0] = A[heapsize];
            heapsize--;
            min_Heapify(0);
            return min;
        }
        //
        public void decrease_Key(int i, int key)
        {
            if (key < A[i].key)
                A[i].key = key;
            //
            while (i > 0 && A[i].key < A[parent(i)].key)
            {
                exchange(i, parent(i));
                i = parent(i);
            }
        }
        //
        public void insert(int key)
        {
            heapsize++;
            //
            inc_HeapSize();
            //
            A[heapsize].key = int.MaxValue;
            decrease_Key(heapsize, key);
        }
        //
        void inc_HeapSize()
        {// Arrays here is fixed size!
            var tmp = A;
            A = new Vertex[heapsize + 1];
            for (int i = 0; i < heapsize; i++)
                A[i] = tmp[i];
            //
        }
    }

}
