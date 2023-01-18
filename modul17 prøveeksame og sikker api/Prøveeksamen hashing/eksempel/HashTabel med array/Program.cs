Land land1 = new Land { Navn = "Oslo"};
Land land2 = new Land { Navn = "Rom"};
Land land3 = new Land { Navn = "Athen"};
Land land4 = new Land { Navn = "Berlin"};


Console.WriteLine(land1.GetHashCode());
Console.WriteLine(land2.GetHashCode());
Console.WriteLine(land3.GetHashCode());
Console.WriteLine(land4.GetHashCode());

Console.WriteLine(land1.Equals(land4));
Console.WriteLine(land1 == land4);

Land[] landArray = new Land[] { land1, land2, land3, land4 };

Console.WriteLine("Udskriv array med byer");
foreach (Land land in landArray) {
        Console.WriteLine(land.Navn);
    }

// Find landet "Danmark"
Console.WriteLine("Find byen Oslo");
Land Oslo = Array.Find(landArray, x => x.Navn == "Oslo");

// Fjern landet "London"
//"val" er en parameter, der referer til hvert element i landArray, og bruges til at tjekke om det er 
//forskellige fra land3. "Where" er en LINQ metode, som giver dig mulighed for at filtrere et array baseret
//på en bestemt betingelse. "ToArray()" metoden konverterer det filtrerede resultat tilbage til et array, 
//og gemmer det i landArray.
landArray = landArray.Where(val => val != land3).ToArray();

// Tæl antallet af lande
int antalLande = landArray.Length;

Console.WriteLine(Oslo.Navn);
Console.WriteLine("Antal byer i arrayet");
Console.WriteLine(antalLande);
Console.WriteLine("Udskriv array med byer, hvor London er fjernet");
foreach (Land land in landArray) {
        Console.WriteLine(land.Navn);
    }

/*/
Land nyBy = new Land { Navn = "Paris"};
land1.AddCity(landArray, nyBy);
/*/

    

public class Land {
public string Navn { get; set; }

/*/
public void AddCity(ref Land[] landArray, Land nyBy) {
  

        // Opret et nyt array med plads til en ekstra by
        Land[] nytArray = new Land[antalByer + 1];

        // Kopiér alle eksisterende byer til det nye array
        for (int i = 0; i < antalByer; i++) {
            nytArray[i] = landArray[i];
        }

        // Tilføj den nye by til det nye array
        nytArray[antalByer] = nyBy;

        // Tildel det nye array til landArray
        landArray = nytArray;
    }
    /*/

public override bool Equals(object obj)
{
    Land input = (Land) obj;
    return input.Navn == this.Navn;
}

public override int GetHashCode()
{
    return Navn.GetHashCode();
}

}

/*/
En hashtabel er en måde at organisere data på, så det er nemt at finde igen senere. 
Det gør det ved at give hver data en unik "nøgle" og derefter bruge denne nøgle til hurtigt at finde 
dataene igen. Det er meget hurtigere end at lede igennem en liste med mange data for at finde det, man 
leder efter.

Men nogle gange kan flere nøgler få den samme "hash-værdi", og så vil de blive placeret på samme sted i 
hashtabellen. Dette kaldes en kollision. Der er flere måder at håndtere kollisioner på, fx ved at placere 
dem i en kæde eller lede efter et andet ledigt sted i hashtabellen.

/*/