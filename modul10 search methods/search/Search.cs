namespace SearchMethods
{
    public class Search
    {
        /// <summary>
        /// Finder tallet i arrayet med en lineær søgning.
        /// </summary>
        /// <param name="array">Det array der søges i.</param>
        /// <param name="tal">Det tal der skal findes.</param>
        /// <returns></returns>
        /*/
        For at implementere den lineære søgning i FindNumberLinear metoden kan du bruge en simpel 
        forloop til at gennemgå hver element i arrayet og sammenligne det med det tal, du søger efter. 
        Hvis elementet matcher det søgte tal, returner du indexpladsen for det element. 
        Hvis ikke tallet findes i arrayet, returner du -1.
        /*/
       public static int FindNumberLinear(int[] array, int tal) {
            for (int i = 0; i < array.Length; i++) {
                if (array[i] == tal) {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Finder tallet i arrayet med en binær søgning.
        /// </summary>
        /// <param name="array">Det array der søges i.</param>
        /// <param name="tal">Det tal der skal findes.</param>
        /// <returns></returns>

         /*/
        For at implementere den binære søgning i FindNumberBinary metoden kan du bruge C#'s 
        inbyggede Array.BinarySearch() metode. Dette metode kræver, at arrayet er sorteret, 
        så du bør kontrollere om arrayet er sorteret først, og sortere det hvis det ikke er. 
        Array.BinarySearch() metoden returnerer indexet for det søgte tal hvis det findes i arrayet, 
        ellers returnerer det et negativt tal, der angiver det første tal i arrayet, der er større end 
        det søgte tal.
        /*/
       public static int FindNumberBinary(int[] array, int tal) {
            Array.Sort(array);
            int index = Array.BinarySearch(array, tal);
            if (index < 0) {
                return -1;
            }
            else
                return index;
        }

        private static int[] sortedArray { get; set; } =
            new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        private static int next = 0;

        /// <summary>
        /// Indsætter et helt array. Arrayet skal være sorteret på forhånd.
        /// </summary>
        /// <param name="sortedArray">Array der skal indsættes.</param>
        /// <param name="next">Den næste ledige plads i arrayet.</param>
        public static void InitSortedArray(int[] sortedArray, int next)
        {
            Search.sortedArray = sortedArray;
            Search.next = next;
        }

        /// <summary>
        /// Indsætter et tal i et sorteret array. En kopi af arrayet returneres.
        /// Array er fortsat sorteret efter det nye tal er indsat.
        /// </summary>
        /// <param name="tal">Tallet der skal indsættes</param>
        /// <returns>En kopi af det sorterede array med det nye tal i.</returns>
        /*/
        For at implementere InsertSorted metoden, kan du bruge en almindelig indsætningsalgoritme. 
        Du går gennem arrayet og finder den første index, hvor tallet er større end det tal, 
        du vil indsætte, og derefter skubbe alle elementerne efter dette index et skridt mod højre, 
        og derefter indsætte det nye tal på den tomme plads.
        /*/
       public static int[] InsertSorted(int tal) {
            int index = next;
            while (index > 0 && sortedArray[index-1] > tal) {
                sortedArray[index] = sortedArray[index-1];
                index--;
            }
            sortedArray[index] = tal;
            next++;
            return (int[])sortedArray.Clone();
        }
        
        
    }
}