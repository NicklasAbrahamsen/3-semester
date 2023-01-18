using LinkedList;

Printer Biblotek = new Printer("Biblotek", 1);
Printer Kantinen = new Printer("Kantinen", 2);
Printer Klasselokalet = new Printer("Klasselokalet", 3);
Printer Biblotek2 = new Printer("Biblotek2", 4);
Printer Kantinen2 = new Printer("Kantinen2", 5);
Printer Klasselokalet2 = new Printer("Klasselokalet2", 6);

PrinterLinkedList list = new PrinterLinkedList();
list.AddFirst(Biblotek);
list.AddFirst(Kantinen);
list.AddFirst(Klasselokalet);
list.AddFirst(Biblotek2);
list.AddFirst(Kantinen2);
list.AddFirst(Klasselokalet2);

Console.WriteLine(list.CountPrinters());
Console.WriteLine(list);

if (list.Contains(Klasselokalet))
{
    Console.WriteLine("Listen indeholder Klasselokalet");
}
else
{
    Console.WriteLine("Listen indeholder ikke Klasselokalet");
}

list.RemovePrinter(Klasselokalet);


Console.WriteLine(list.CountPrinters());
Console.WriteLine(list);

if (list.Contains(Klasselokalet))
{
    Console.WriteLine("Listen indeholder Klasselokalet");
}
else
{
    Console.WriteLine("Listen indeholder ikke Klasselokalet");
}

//Kald PrintListByPriority metoden her
list.PrintListByPriority();


