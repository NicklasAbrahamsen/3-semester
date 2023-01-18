/*/
"static void Main(string[] args)" det betyder at det er den første metode, der køres, når et program køres.

"static" keywordet betyder, at metoden er en statisk metode, som kan kaldes direkte på klassen, uden at 
der skal oprettes en instans af klassen.

"void" er returtypen for metoden, og det betyder, at metoden ikke returnerer noget.

"Main" er navnet på metoden.

"(string[] args)" er parameterlisten for metoden. Det betyder, at metoden tager et array af strenge som 
input, kaldet args.
/*/

class Program {
    static void Main(string[] args) {
        Land land1 = new Land { Navn = "Oslo"};
        Land land2 = new Land { Navn = "Rom"};
        Land land3 = new Land { Navn = "Athen"};
        Land land4 = new Land { Navn = "Berlin"};

        Land[] landArray = new Land[] { land1, land2, land3, land4 };

        Console.WriteLine("Udskriv array med byer");
        foreach (Land land in landArray) {
            Console.WriteLine(land.Navn);
        }

        // Find landet "Oslo"
        Console.WriteLine("Find byen Oslo");
        Land Oslo = Array.Find(landArray, x => x.Navn == "Oslo");
        Console.WriteLine(Oslo.Navn);

        //mangler en funktion der retunere true hvis oslo findes

        //Lambda-udtryk er en kortform for at skrive en anonym funktion i C#. Det er en kort og enkel 
        //måde at definere en funktion uden at give den et navn.
        // Fjern landet "Athen"
        landArray = landArray.Where(val => val != land3).ToArray();
        Console.WriteLine("Udskriv array med byer, hvor Athen er fjernet");
        foreach (Land land in landArray) {
            Console.WriteLine(land.Navn);
        }

        // Tæl antallet af byer
        int antalByer = landArray.Length;
        Console.WriteLine("Antal byer i arrayet: " + antalByer);

        // Tilføj en by til arrayet
        Land nyBy = new Land { Navn = "Paris"};
        land1.AddCity(ref landArray, nyBy);

        Land nyBy2 = new Land {Navn = "københavn"};
        land3.AddCity(ref landArray, nyBy2);

        Land nyBy3 = new Land {Navn = "Skive"};
        land4.AddCity(ref landArray, nyBy3);

        

        // Udskriv arrayet igen
        Console.WriteLine("Udskriv array med byer efter at have tilføjet Paris");
        foreach (Land land in landArray) {
            Console.WriteLine(land.Navn);
        }
    }
}

public class Land {
    public string Navn { get; set; }
    //"ref" keyword foran en parameter i en metode, betyder det at metoden modtager en reference til den 
    //oprindelige variable i stedet for en kopi af dens værdi. Det betyder, at eventuelle ændringer, der 
    //gøres til denne parameter i metoden, også vil ændre den oprindelige variable.
    public void AddCity(ref Land[] landArray, Land nyBy) {
        // Find antallet af byer i arrayet
        int antalByer = landArray.Length;

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

        //find metode 
        
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

Hashtabellen kan hurtigt slå en nøgle op og returnere den tilhørende værdi ved hjælp af en hash-funktion, 
hvilket giver en tidskompleksitet på O(1) i gennemsnit. Dette er langt hurtigere end at søge igennem en 
liste, hvor tidskompleksiteten er O(n) i gennemsnit.

/*/