namespace Sortering
{
    public class InsertionSort
    {
        public static void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int next = array[i];
                int j = i;
                bool found = false;
                while (!found && j > 0)
                {
                    if (next >= array[j - 1])
                    {
                        found = true;
                    }
                    else
                    {
                        array[j] = array[j - 1]; //skub de sorterede ellementer en plads op
                        j--;
                    }
                }
                array[j] = next;
            }
        }
    }
}

/*/
Insertionsort er en simpel sorteringsalgoritme, hvor man tager det første element i en usorteret liste 
og antager, at det er det første element i den sorterede liste. Derefter tager man det næste element i 
den usorterede liste og sammenligner det med hvert element i den sorterede del af listen. Så snart man 
finder et element i den sorterede del, som er større end det aktuelle element, så skubber man det større 
element og alle de efterfølgende elementer en plads frem, så der er plads til det aktuelle element. 
Endelig indsætter man det aktuelle element på den plads, det nu hører til i den sorterede del af listen. 
Denne proces gentages for hvert element i den usorterede del af listen, indtil hele listen er sorteret i 
stigende rækkefølge.
/*/