using Model;

using (var db = new LandeContext())
{
    Console.WriteLine($"Database path: {db.DbPath}.");
    
    // Create
    Console.WriteLine("Indsæt et nyt land");
    db.Add(new Land( 40,"Norge", "Europa", "NATO"));
    db.SaveChanges();
    //

    // Read
    Console.WriteLine("Find det sidste task");
    var lastLand = db.Land
        .OrderBy(b => b.LandKodeId)
        .Last();
    Console.WriteLine($"Name: {lastLand.Name}");
    //

/*/Update
   Console.WriteLine("Update den sidste task");
    var newLand = db.Land.First(t=>t.LandKodeId ==40);
    newLand.Name = "Finland";
    newLand.Område = "Ikke europa";
    db.SaveChanges();
/*/
    
   /*/ Delete opgave
    var deleteTask = db.Land.First(t=>t.LandKodeId ==40);
    db.Land.Remove(deleteTask);
    db.SaveChanges();
    /*/
 
}