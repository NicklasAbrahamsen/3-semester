namespace Sortering;

public class BubbleSort
{
    private static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

/*/
Dette er en implementering af bobblesort, en enkel sorteringsalgoritme. Bobblesort arbejder ved at 
gentagende at gennemgå en liste og sammenligne og bytte elementer, indtil listen er sorteret.

I dette eksempel tager metoden "Sort" en int array som parameter. Derefter bruger den to 
for-loops for at gennemgå arrayet. Den ydre loop løber fra array.Length - 1 til 0, mens den indre loop 
løber fra 0 til i - 1. For hver iteration af den indre loop, sammenlignes array[j] og array[j + 1], hvis 
array[j] er større end array[j + 1], så bliver de to elementer byttet plads ved hjælp af metoden Swap. 
Denne proces fortsætter, indtil listen er sorteret i stigende orden.
/*/
     public static void Sort(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            for (int j = 0; j <= i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    Swap(array, j, j + 1);
                }
            }
        }
    }
}
