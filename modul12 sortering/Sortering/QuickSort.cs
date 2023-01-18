namespace Sortering;

public static class QuickSort
{

    private static void Swap(int[] array, int k, int j)
    {
        int tmp = array[k];
        array[k] = array[j];
        array[j] = tmp;
    }

    private static void _quickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivot = Partition(array, low, high);
            _quickSort(array, low, pivot - 1);
            _quickSort(array, pivot + 1, high);
        }
    }

    private static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = (low - 1);

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }
        Swap(array, i + 1, high);
        return i + 1;
    }

    public static void Sort(int[] array)
    {
        _quickSort(array, 0, array.Length - 1);
    }
}

/*/
Når man deler QuickSort op, vælger man et index som man kalder for pivot, og laver opdeling omkring den.
Der er mange måde at vælge pivot på. Her løses det med en hjælpefunktion der hedder partition.

Når man starter, sættes low til 0 og high til array.length - 1.

Partitionsmetoden bruges til at dele inputarrayet i to underarrays, én der indeholder elementer, der er 
mindre end eller lig med pivoten, og én der indeholder elementer, der er større end pivoten. Den tager 
arrayet, startindekset for området der skal partitions (low), og enden for området der skal partitions 
(high) som parametre.
Det starter med at vælge pivoten som det sidste element i det givet område. Derefter oprettes en pointer 
'i' og initialiseres til low-1.
Derefter starter den med at iterere arrayet ved hjælp af pointer 'j', fra low til high (ikke inklusive), 
hvis det nuværende element er mindre eller lig med pivoten, øges pointer i og elementerne i pointer i og j 
byttet plads.
Til sidst bytter det elementet i i+1 med high-indeks elementet og returnerer i+1.
Efter det kalder Sort metoden _quickSort metoden rekursivt og sender det passende område baseret på pivoten. 
Basistilfældet for rekursionen er når low er større eller lig med high.
/*/