namespace Sortering;

public static class MergeSort
{

    public static void Sort(int[] array)
    {
        _mergeSort(array, 0, array.Length - 1);
    }

    private static void _mergeSort(int[] array, int l, int h)
    {
        if (l < h)
        {
            int m = (l + h) / 2;
            _mergeSort(array, l, m);
            _mergeSort(array, m + 1, h);
            Merge(array, l, m, h);
        }
    }

    private static void Merge(int[] array, int low, int middle, int high)
    {
        int[] left = new int[middle - low + 1];
        int[] right = new int[high - middle];

        Array.Copy(array, low, left, 0, middle - low + 1);
        Array.Copy(array, middle + 1, right, 0, high - middle);

        int i = 0;
        int j = 0;
        int k = low;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                array[k] = left[i];
                i++;
            }
            else
            {
                array[k] = right[j];
                j++;
            }
            k++;
        }

        while (i < left.Length)
        {
            array[k] = left[i];
            i++;
            k++;
        }

        while (j < right.Length)
        {
            array[k] = right[j];
            j++;
            k++;
        }
    }

}

/*/
Metoden Merge tager arrayet, startindekset for området der skal sorteres (low), midtpunktet for området 
der skal sorteres (middle) og enden for området der skal sorteres (high) som sine parametre. Den splitter 
først inputarrayet i to dele - venstre halvdel og højre halvdel. Den venstre array oprettes ved at bruge 
Array.Copy metoden til at kopiere elementerne fra inputarrayet mellem low og middle indekserne, og den 
højre array oprettes ved at bruge Array.Copy metoden til at kopiere elementerne fra inputarrayet mellem 
middle+1 og high indekserne. Derefter oprettes der tre pegere, en for hver af de venstre og højre arrays, 
og en for inputarrayet, for at holde styr på den nuværende position i hver af arrays under merge-processen. 
Derefter går den igennem begge arrays og sammenligner elementerne på den nuværende position i hvert array. 
Det mindste element kopieres til inputarrayet på den nuværende position af pegeren. Derefter øges pegeren 
for den korresponderende array. Til sidst, når en array er helt gennemgået, kopieres de resterende 
elementer fra den anden array til inputarrayet.
/*/