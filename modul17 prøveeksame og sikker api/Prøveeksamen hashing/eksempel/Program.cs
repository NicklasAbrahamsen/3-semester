class Program
{
    static void Main(string[] args)
    {
        landHashtable landHashtable1 = new landHashtable { Navn = "Danmark", Befolkning = 5.822 };
        landHashtable landHashtable2 = new landHashtable { Navn = "Sverige", Befolkning = 10.234 };
        landHashtable landHashtable3 = new landHashtable { Navn = "Norge", Befolkning = 5.378 };
        landHashtable landHashtable4 = new landHashtable { Navn = "Danmark", Befolkning = 5.822 };

        Console.WriteLine(landHashtable1.GetHashCode());
        Console.WriteLine(landHashtable2.GetHashCode());
        Console.WriteLine(landHashtable3.GetHashCode());
        Console.WriteLine(landHashtable4.GetHashCode());

        Console.WriteLine(landHashtable1.Equals(landHashtable4));
        Console.WriteLine(landHashtable1 == landHashtable4);

        System.Collections.Hashtable landhashtabel = new System.Collections.Hashtable();
        landhashtabel.Add(landHashtable1.Navn, landHashtable1);
        landhashtabel.Add(landHashtable2.Navn, landHashtable2);
        landhashtabel.Add(landHashtable3.Navn, landHashtable3);
        landhashtabel.Add(landHashtable4.Navn, landHashtable4);

        Console.WriteLine("Udskriv Hashtable med landHashtablee");
        foreach (DictionaryEntry landHashtable in landhashtabel) {
            Console.WriteLine(((landHashtable)landHashtable.Value).Navn);
        }

        Console.WriteLine("Find landHashtableet Danmark");
        landHashtable danmark = (landHashtable)landhashtabel[landHashtable1.Navn];

        landhashtabel.Remove(landHashtable3.Navn);

        int antallandHashtablee = landhashtabel.Count;

        Console.WriteLine(danmark.Navn);
        Console.WriteLine("Antal landHashtablee i Hashtable");
        Console.WriteLine(antallandHashtablee);
        Console.WriteLine("Udskriv Hashtable med landHashtablee, hvor Norge er fjernet");
        foreach (DictionaryEntry landHashtable in landhashtabel) {
        Console.WriteLine(((landHashtable)landHashtable.Value).Navn);
}
}
}

public class landHashtable {
public string Navn { get; set; }
public double Befolkning { get; set; } 
public override bool Equals(object obj)
{
    landHashtable input = (landHashtable) obj;
    return input.Navn == this.Navn;
}

public override int GetHashCode()
{
    return Navn.GetHashCode();
}
}
