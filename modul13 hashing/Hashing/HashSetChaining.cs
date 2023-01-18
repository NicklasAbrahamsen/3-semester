using Hashing;


public class HashSetChaining : HashSet
{
    private Node[] buckets;
    private int currentSize;
    

    private class Node
    {
        public Node(Object data, Node next)
        {
            this.Data = data;
            this.Next = next;
        }
        public Object Data { get; set; }
        public Node Next { get; set; }
    }

    public HashSetChaining(int size)
    {
        buckets = new Node[size];
        currentSize = 0;
    }

    public bool Contains(Object x)
    {
        int h = HashValue(x);
        Node bucket = buckets[h];
        bool found = false;
        while (!found && bucket != null)
        {
            if (bucket.Data.Equals(x))
            {
                found = true;
            }
            else
            {
                bucket = bucket.Next;
            }
        }
        return found;
    }

    public bool Add(Object x)
    {
        int h = HashValue(x);

        Node bucket = buckets[h];
        bool found = false;
        while (!found && bucket != null)
        {
            if (bucket.Data.Equals(x))
            {
                found = true;
            }
            else
            {
                bucket = bucket.Next;
            }
        }

        if (!found)
        {
            Node newNode = new Node(x, buckets[h]);
            buckets[h] = newNode;
            currentSize++;
        }

        return !found;
    }
   
        /*/
        I denne implementering, beregner vi den hash-værdi, som x skal placeres i, ved hjælp af HashValue() 
        metoden. Derefter går vi gennem listen i denne "bucket" og søger efter x. Hvis vi finder det, 
        fjerner vi det ved at ændre linksene i listen så x ikke længere er en del af listen. Vi returnerer 
        true hvis vi fjerner et element og false hvis vi ikke gør det.
        /*/
        public bool Remove(Object x)
    {
        // TODO: Implement!
        // SKal returnerer true hvis den finder noget at fjerne
        
        int h = HashValue(x);
        Node prev = null;
        Node bucket = buckets[h];
        while (bucket != null)
        {
            if (bucket.Data.Equals(x))
            {
                if (prev == null)
                {
                    buckets[h] = bucket.Next;
                }
                else
                {
                    prev.Next = bucket.Next;
                }
                currentSize--;
                return true;
            }
            prev = bucket;
            bucket = bucket.Next;
        }
        return false;
    }


    private int HashValue(Object x)
    {
        int h = x.GetHashCode();
        if (h < 0)
        {
            h = -h;
        }
        h = h % buckets.Length;
        return h;
    }

    public int Size()
    {
        return currentSize;
    }

    public override String ToString()
    {
        String result = "";
        for (int i = 0; i < buckets.Length; i++)
        {
            Node temp = buckets[i];
            if (temp != null)
            {
                result += i + "\t";
                while (temp != null)
                {
                    result += temp.Data + " (h:" + HashValue(temp.Data) + ")\t";
                    temp = temp.Next;
                }
                result += "\n";
            }
        }
        return result;
    }
    
}
