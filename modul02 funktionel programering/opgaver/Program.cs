Person[] people = new Person[]
{
    new Person { Name = "Jens Hansen", Age = 45, Phone = "+4512345678" },
    new Person { Name = "Jane Olsen", Age = 22, Phone = "+4543215687" },
    new Person { Name = "Tor Iversen", Age = 35, Phone = "+4587654322" },
    new Person { Name = "Sigurd Nielsen", Age = 31, Phone = "+4512345673" },
    new Person { Name = "Viggo Nielsen", Age = 28, Phone = "+4543217846" },
    new Person { Name = "Rosa Jensen", Age = 23, Phone = "+4543217846" },
};

/*
// Udregner den samlede alder for alle mennesker.
int totalAge = 0;
for (int i = 0; i < people.Length; i++)
{
    totalAge += people[i].Age;
}
*/
//delopgave 1
var sumAge = people.Sum(person => person.Age);
Console.WriteLine(sumAge);

/*
// Tæller hvor mange der hedder "Nielsen"
int countNielsen = 0;
for (int i = 0; i < people.Length; i++)
{
    if (people[i].Name.Contains("Nielsen"))
    {
        countNielsen++;
    }
}
*/
//delopgave 2
var count = people.Count(p => p.Name.Contains("Nielsen"));
Console.WriteLine(count);


/*/ Find den ældste person
Person oldestPerson = null;
for (int i = 0; i < people.Length; i++)
{
    if (oldestPerson == null || people[i].Age > oldestPerson.Age)
    {
        oldestPerson = people[i];
    }
}
/*/
// delopgave 3
//OrderByDescending-metoden sorterer menneskene efter alder fra størst til mindst
//FirstOrDefault-metoden returnerer det første element i kollektionen (i dette tilfælde den ældste person).
Person oldestPerson = people.OrderByDescending(p => p.Age).FirstOrDefault();
Console.WriteLine(oldestPerson.Name);

class Person {
    public string Name { get; set; }
    public int Age { get; set; }
    public string Phone { get; set; }
}
