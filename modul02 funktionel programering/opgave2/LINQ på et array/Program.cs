using System.Linq;

Person[] people = new Person[]
{
    new Person { Name = "Jens Hansen", Age = 45, Phone = "+4512345678" },
    new Person { Name = "Jane Olsen", Age = 22, Phone = "+4543215687" },
    new Person { Name = "Tor Iversen", Age = 35, Phone = "+4587654322" },
    new Person { Name = "Sigurd Nielsen", Age = 31, Phone = "+4512345673" },
    new Person { Name = "Viggo Nielsen", Age = 28, Phone = "+4543217846" },
    new Person { Name = "Rosa Jensen", Age = 23, Phone = "+4543217846" },
};

// Find og udskriv personen med mobilnummer "+4543215687"
Person person = people.FirstOrDefault(p => p.Phone == "+4543215687");
if (person != null) {
    Console.WriteLine("The person with phone number +4543215687 is " + person.Name);
}

// Vælg alle som er over 30 og udskriv dem.
var over30 = people.Where(p => p.Age > 30);
foreach (var p in over30) {
    Console.WriteLine(p.Name + " is over 30 years old.");
}

//3. Lav et nyt array med de samme personer, men hvor “+45” er fjernet fra alle telefonnumre.

var newPerson = people.Select(p => new Person { Name = p.Name, Age = p.Age, Phone = p.Phone.Substring(3) }); 
Console.WriteLine(string.Join(", ", newPerson));

// Generér en string med navn og telefonnummer på de personer, der er yngre end 30, adskilt med komma
string namesAndPhones = string.Join(", ", people
    .Where(p => p.Age < 30)
    .Select(p => p.Name + " (" + p.Phone + ")"));
Console.WriteLine("People younger than 30: " + namesAndPhones);

public class Person {
    public string Name { get; set; }
    public int Age { get; set; }
    public string Phone { get; set; }

    public override string ToString()
    {
        return Name + "," + Age + "," + "Phone Number" + Phone;
    }
}