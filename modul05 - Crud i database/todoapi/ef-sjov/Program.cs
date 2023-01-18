using Model;

using (var db = new TaskContext())
{
    Console.WriteLine($"Database path: {db.DbPath}.");
    
    // Create
    Console.WriteLine("Indsæt et nyt task");
    db.Add(new TodoTask("En opgave der skal løses", 3, true, "Nicklas","oprydning"));
    db.SaveChanges();
    //

    // Read
    Console.WriteLine("Find det sidste task");
    var lastTask = db.Tasks
        .OrderBy(b => b.TodoTaskId)
        .Last();
    Console.WriteLine($"Text: {lastTask.Text}");
    //

//Update
   Console.WriteLine("Update den sidste task");
    var newTask = db.Tasks.First(t=>t.TodoTaskId ==3);
    newTask.Text = "Ny opdatering5";
    newTask.Område = 5;
    db.SaveChanges();
//
    
   /*/ Delete opgave
    var deleteTask = db.Tasks.First(t=>t.TodoTaskId ==2);
    db.Tasks.Remove(deleteTask);
    db.SaveChanges();
    /*/
 
}