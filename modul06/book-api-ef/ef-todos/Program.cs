using Model;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var db = new TodoContext())
        {
            Console.WriteLine($"Database BoardId: {db.DbPath}.");

            // Create
            Console.WriteLine("Indsæt et ny todo");
            //db.Todos.Add(new Todo("Nicklas", "oprydning", new User("MATTY")));
            //db.Users.Add(new User("Michael H. Sloth"));
            var board = new Board { BoardId = 55 };
            board.Todoes.Add(new Todo("michael", "vagt", new User("hejsa")));
            db.Boards.Add(board);
            db.SaveChanges();


            
                         //Read
                        Console.WriteLine("Find det sidste todo");
                        var lastBoard = db.Boards
                            .OrderBy(b => b.BoardId)
                            .Last();
                        Console.WriteLine($"Toto: {lastBoard.BoardId}");


/*/Update
   Console.WriteLine("Update den sidste todo");
    var newTodo = db.Todos.First(t=>t.Id ==3);
    newTodo.Name = "Ny opdatering5";
    db.SaveChanges();
/*/


    /*/Delete opgave
    var deleteTodo = db.Todos.First(t=>t.Id ==6);
    db.Todos.Remove(deleteTodo);
    db.SaveChanges();
    /*/

    /*/
    Opgave 2 - Model-ændringer

Du får nu at vide, at Todo skal ændres. I stedet for et name og en category, skal de to ting nu slås sammen til en titel. Titler på eksisterende tasks skal stå på formen “category: name” (nye titler behøver ikke overholde dette format). Du må ikke miste dit gamle data i databasen. I stedet skal det konverteres til det nye format.

Kort og godt, så skal du slå to gamle kolonner sammen til en ny kolonne i databasen, uden at miste data. Få inspiration fra dagens præsentation og den officielle dokumentation til EF.
    Problemet kunne også være, at vi har to kolonner FirstName og LastName, som vi vil slå sammen til en ny kolonne FullName. Her virker Rename ikke. I stedet kan vi skrive noget raw sql:

migrationBuilder.AddColumn<string>(
    name: "Name",    
    table: "Todo",    
    nullable: true);
migrationBuilder.Sql(
@"
    UPDATE Todo    
    SET Titel = Name || ' ' || Category;
");
// TODO: Drop de to gamle kolonner

    /*/

        }
    }
}
 
