using System;

namespace MST_Prim
{
    //
    //Implementation of 'Min Heap'
    //run-time :O(nlg(n))
    //
    //Ahmed Ibrahim Mahmoud Ibrahim
    //Sec. 1
    //
    class min_Heap
    {
        public Vertex[] A;
        public int heapsize;
        public min_Heap(Vertex[] A)
        {
            this.A = A;
            heapsize = this.A.Length - 1;
        }
        //
        Boolean in_HeapSize(int i) { return (i <= heapsize); }
        //
        public int left(int i) { return (2 * i); }
        public int right(int i) { return (2 * i + 1); }
        public int parent(int i) { return i / 2; }
        //
        public void min_Heapify(int i)
        {
            int l = left(i);
            int r = right(i);
            int smallest = i;
            //
            if (in_HeapSize(l) && A[i].key > A[l].key)
                smallest = l;
            //
            if (in_HeapSize(r) && A[r].key < A[smallest].key)
                smallest = r;
            //
            if (i != smallest)
            {
                exchange(i, smallest);
                if (smallest <= heapsize / 2)
                    min_Heapify(smallest);
            }

        }
        //
        public void build_Min_Heap()
        {
            int len = A.Length / 2;
            for (int j = len - 1; j >= 0; j--)
                min_Heapify(j);
        }
        //
        public void heap_Sort()
        {
            build_Min_Heap();
            for (int k = A.Length - 1; k >= 1; k--)
            {
                exchange(k, 0);
                heapsize--;
                min_Heapify(0);
            }
        }
        //
        public void exchange(int x, int y)
        {
            Vertex temporary = A[x];
            A[x] = A[y];
            A[y] = temporary;
            //
            //Update the index of swapped vertices in the min priority queue, for Line 11 in Prim's Algorithm, for Deacrease-Key
            A[x].i = x;
            A[y].i = y;
        }
    }
}
