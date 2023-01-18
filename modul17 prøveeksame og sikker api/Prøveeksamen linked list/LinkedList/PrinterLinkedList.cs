namespace LinkedList
{
    class Node
    {
        public Node(Printer data, Node next)
        {
            this.Data = data;
            this.Next = next;
        }
        public Printer Data;
        public Node Next;
    }

    class PrinterLinkedList
    {
        private Node first = null!;

        public void AddFirst(Printer Printer)
        {
            Node node = new Node(Printer, first);
            first = node;
        }

       public bool Contains(Printer Printer)
    {
        Node current = first;
        while (current != null)
        {
            if (current.Data.Equals(Printer))
                return true;
            current = current.Next;
        }
        return false;
    }

/*/
"InvalidOperationException" Det betyder, at noget i programmet forsøger at gøre noget, som ikke kan gøres 
i den nuværende tilstand eller ikke er gyldigt. Denne type af undtagelse er normalt brugt, når der er 
behov for at afbryde programmet og give brugeren eller udvikleren besked om, hvad der gik galt.
/*/

/*/
Koden er en metode, der fjerner den første node i en linked list, der forventer at indeholde Printer objekter, 
og returnerer det fjernede Printer objekt.

Først tjekker metoden om listen er tom ved at kontrollere om variablen "first" er null. Hvis det er 
tilfældet, så kaster metoden en InvalidOperationException med en besked "Linked list is empty.".

Hvis listen ikke er tom, så gemmer den første node's "Data" i en variabel "removedData", og derefter 
opdateres "first" til den næste node i listen ved at hente dens "Next" property. Derefter returneres 
"removedData", som er Printer objektet i den fjernede node.
/*/
        public Printer RemoveFirst()
    {
        if (first == null)
        {
            throw new InvalidOperationException("Linked list is empty.");
        }
        Printer removedData = first.Data;
        first = first.Next;
        return removedData;
    }

/*/
Koden er en metode, der fjerner en bestemt node, der indeholder et bestemt Printer objekt, fra en linked list.
Metoden tager et Printer objekt som argument og finder den tilsvarende node i listen ved at sammenligne objekternes 
"Name" properties.

Metoden starter ved at definere to variable: "node", der starter ved den første node i listen, og "previous" 
som er null. Der er også en variabel "found" som starter som false, det bruges til at holde styr på om den 
ønskede node er blevet fundet eller ej.

Derefter er der en while-loop, der kører så længe "found" er false og "node" ikke er null. I hver iteration 
af løkken, tjekker metoden om "node.Data.Name" er lig med "Printer.Name". Hvis de er ens, så sætter den "found" 
til true, og tjekker om "node" er den første node i listen.

Hvis "node" er den første node i listen, så kaldes RemoveFirst() metoden, og så den første node i listen er 
fjernet. Hvis ikke "node" er den første node, så sætter metoden "previous.Next" til "node.Next", hvilket 
fjerner "node" fra listen, og sikrer at listen er korrekt forbundet efter fjernelsen.

Hvis den ønskede node ikke er fundet, så opdateres "previous" til den nuværende "node" og "node" opdateres 
til den næste node i listen.
/*/
        public void RemovePrinter(Printer Printer)
        {
            Node node = first;
            Node previous = null!;
            bool found = false;

            while (!found && node != null)
            {
                if (node.Data.Name == Printer.Name)
                {
                    found = true;
                    if (node == first)
                    {
                        RemoveFirst();
                    }
                    else
                    {
                        previous.Next = node.Next;
                    }
                }
                else
                {
                    previous = node;
                    node = node.Next;
                }
            }
        }

        public Printer GetFirst()
        {
            return first.Data;
        }

/*/
Koden er en metode, der henter den sidste node i en linked list, som forventer at indeholde Printer objekter.
Metoden tjekker først om listen er tom ved at kontrollere om variablen "first" er null. Hvis det er tilfældet, så kaster metoden en InvalidOperationException med en besked "Linked list is empty.".

Hvis listen ikke er tom, så definerer den en variabel "current" der starter ved den første node i listen. 
Der er derefter en while-loop, der kører, så længe "current.Next" ikke er null. I hver iteration af løkken, 
opdateres "current" til den næste node ved at hente sin "Next" property.

Når loopet er færdig, så returneres "current.Data", som er Printer objektet i den sidste node i listen, som er 
den node, der ikke har en "Next" property ikke er null.
/*/
         public Printer GetLast()
    {
        if (first == null)
        {
            throw new InvalidOperationException("Linked list is empty.");
        }
        Node current = first;
        while (current.Next != null)
        {
            current = current.Next;
        }
        return current.Data;
    }

/*/
Koden er en metode, der tæller antallet af noder i en linked list. Den starter ved at initialisere en variabel "count" til nul. Derefter definerer den en variabel "current", der starter ved den første node i listen.

Så er der en while-loop, der kører, så længe "current" ikke er null. I hver iteration af løkken, øges "count" med 1, og "current" opdateres til den næste node i listen ved at hente sin "Next" property.

Endelig returneres "count" som resultatet af metoden, som giver antallet af noder i listen.
/*/
        public int CountPrinters()
        {
        int count = 0;
        Node current = first;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
        }

        public override String ToString()
        {
            Node node = first;
            String result = "";
            while (node != null)
            {
                result += node.Data.Name + ", ";
                node = node.Next;
            }
            return result.Trim();
        }

    public void PrintListByPriority()
    {
        if (first == null)
        {
            Console.WriteLine("Listen er tom.");
            return;
        }
        // Initialiserer en tom liste kaldet "sortedList" og en variabel "currentNode" 
        //som starter ved den første node i listen.
        List<Printer> sortedList = new List<Printer>();
        Node currentNode = first;

        // While loop der kører så længe "currentNode" ikke er null.
        while (currentNode != null)
        {
            // Gemmer data fra den nuværende node i variablen "currentPrinter"
            Printer currentPrinter = currentNode.Data;
            // Opdaterer "currentNode" til den næste node i listen
            currentNode = currentNode.Next;
            // Initialiserer en variabel "i" som starter ved 0
            int i = 0;
            // En while loop der kører så længe "i" er mindre end antallet af elementer i "sortedList" 
            //og prioriteten på det nuværende element i "sortedList" er mindre eller lig med prioriteten 
            //på "currentPrinter"
            while (i < sortedList.Count && sortedList[i].Prioritet <= currentPrinter.Prioritet)
            {
                 // Øger "i" med 1
                i++;
            }
            // Indsætter "currentPrinter" på plads "i" i "sortedList"
            sortedList.Insert(i, currentPrinter);
        }

        Console.WriteLine("Printer listen efter priority:");
        foreach (Printer printer in sortedList)
        {
            Console.WriteLine(printer.Name + " - Priority: " + printer.Prioritet);
        }
    }
}

}