using Hashing;

public class HashSetLinearProbing : HashSet {
    private Object[] buckets;
    private int currentSize;
    private enum State { DELETED }

    public HashSetLinearProbing(int bucketsLength) {
        buckets = new Object[bucketsLength];
        currentSize = 0;
    }

/*/
Metoden "Contains" beregner den hash-værdi, som x skal placeres i, og derefter går den gennem listen 
i denne "bucket" og søger efter x ved hjælp af linear probing teknikken. Hvis x findes i listen, 
returnerer den true, ellers false.
/*/
        public bool Contains(Object x) {
             // TODO: Implement!
        int h = HashValue(x);
        int idx = h;
        while (buckets[idx] != null) {
            if (buckets[idx].Equals(x)) {
                return true;
            }
            idx = (idx + 1) % buckets.Length;
        }
        return false;
    }

/*/
Metoden "Add" beregner den hash-værdi, som x skal placeres i, og derefter går den gennem listen i denne 
"bucket" for at se om x allerede findes i listen ved hjælp af linear probing teknikken. Hvis x ikke 
findes i listen, tilføjer den x til listen og returnerer true, ellers returnerer den false.
/*/
    public bool Add(Object x) {
         // TODO: Implement!
        if (currentSize == buckets.Length) {
            throw new Exception("HashSet is full");
        }
        int h = HashValue(x);
        int idx = h;
        while (buckets[idx] != null && !buckets[idx].Equals(State.DELETED)) {
            if (buckets[idx].Equals(x)) {
                return false;
            }
            idx = (idx + 1) % buckets.Length;
        }
        buckets[idx] = x;
        currentSize++;
        return true;
    }

/*/
Metoden "Remove" beregner den hash-værdi, som x skal placeres i, og derefter går den gennem listen i denne 
"bucket" og søger efter x ved hjælp af linear probing teknikken. Hvis den finder x, fjerner den x ved at 
sætte det til State.DELETED og returnerer true, ellers returnerer den false.

/*/
    public bool Remove(Object x) {
         // TODO: Implement!
        int h = HashValue(x);
        int idx = h;
        while (buckets[idx] != null) {
            if (buckets[idx].Equals(x)) {
                buckets[idx] = State.DELETED;
                currentSize--;
                return true;
            }
            idx = (idx + 1) % buckets.Length;
        }
        return false;
    }


    public int Size() {
        return currentSize;
    }

    private int HashValue(Object x) {
        int h = x.GetHashCode();
        if (h < 0) {
            h = -h;
        }
        h = h % buckets.Length;
        return h;
    }

    public override String ToString() {
        String result = "";
        for (int i = 0; i < buckets.Length; i++) {
            int value = buckets[i] != null && !buckets[i].Equals(State.DELETED) ? 
                    HashValue(buckets[i]) : -1;
            result += i + "\t" + buckets[i] + "(h:" + value + ")\n";
        }
        return result;
    }

}
