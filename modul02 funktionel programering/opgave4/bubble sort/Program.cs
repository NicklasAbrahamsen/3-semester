using System;

Person[] people = new Person[]
{
    new Person { Name = "Jens Hansen", Age = 45, Phone = "+4512345678" },
    new Person { Name = "Jane Olsen", Age = 22, Phone = "+4543215687" },
    new Person { Name = "Tor Iversen", Age = 35, Phone = "+4587654322" },
    new Person { Name = "Sigurd Nielsen", Age = 31, Phone = "+4512345673" },
    new Person { Name = "Viggo Nielsen", Age = 28, Phone = "+4543217846" },
    new Person { Name = "Rosa Jensen", Age = 23, Phone = "+4543217846" },
};

public class BubbleSort
{
    // Bytter om på to elementer i et array
    private static void Swap(Person[] array, int i, int j)
    {
        Person temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    // Laver sortering på array med Bubble Sort. 
    // compareFn bruges til at sammeligne to personer med.
    public static void Sort(Person[] array, Func<Person, Person, int> compareFn)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            for (int j = 0; j <= i - 1; j++)
            {
                // Laver en ombytning, hvis to personer står forkert sorteret
                if (compareFn(array[j], array[j + 1]) > 0)
                {
                    Swap(array, j, j + 1);
                }
            }
        }
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Phone { get; set; }

    public override string ToString()
    {
        return Name + "," + Age + "," + "+" + Phone;
    }

}

// Opgave 1: Sortér arrayet efter alder
Func<Person, Person, int> compareByAge = (Person p1, Person p2) => p1.Age < p2.Age ? -1 : p1.Age == p2.Age ? 0 : 1;

// Opgave 2: Sortér arrayet efter navn
Person[] array = {new Person { Name = "John", Age = 30 }, new Person { Name = "Jane", Age = 25 }, new Person { Name = "Bob", Age = 35 }};

BubbleSort.Sort(array, compareByAge);

foreach (Person person in array)
{
    Console.WriteLine(person.Name + " " + person.Age);
}


// Opgave 3: Sortér arrayet efter navn
Func<Person, Person, int> compareByName = (Person p1, Person p2) => string.Compare(p1.Name, p2.Name);
BubbleSort.Sort(people, compareByName);

foreach (Person person in







