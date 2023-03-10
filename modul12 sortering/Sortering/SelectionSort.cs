namespace Sortering;

public class SelectionSort
{
    private static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
 public static void Sort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int min = i;
        // Find det mindste element i resten af det usorterede array
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[min])
            {
                min = j;
            }
        }
        // Byt det mindste element med det første element i det usorterede array
        Swap(array, i, min);
    }
}
}
