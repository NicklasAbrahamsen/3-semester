var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

int nextId = 0;

Spørgsmål[] Quiz = new Spørgsmål[]
{
    new Spørgsmål {Id = nextId++, SpgText = "Hvad hedder dette fag?", Svarmuligheder = new string[] {"Cloud Computing", "Sofwarearkitektur","System design","Digital kultur"}, SvarIndex = 1 },
    new Spørgsmål {Id = nextId++, SpgText = "Hvilken IPhone blev udgivet i år 2022?", Svarmuligheder = new string[] {"IPhone 11", "IPhone 12", "IPhone 22","IPhone 14" }, SvarIndex = 3 },
};


app.MapGet("/api/questions", () =>
{
    var nytArray = Quiz.Select(p => new SpgUdenSvar
    {
        SpgText = p.SpgText,
        Svarmuligheder = p.Svarmuligheder
    });
    return nytArray;
});




app.MapGet("/api/questions/{id}", (int id) =>
{
    var nytArray = Quiz.Select(p => new SpgIdUdenSvar
    {
        Id = p.Id,
        SpgText = p.SpgText,
        Svarmuligheder = p.Svarmuligheder,
    }).Where(q => q.Id == id);

    return nytArray;
});


app.MapPost("api/questions/{id}/validate", (int id, SvarMuligheder Svaret) =>
{
    var svarIndex = Quiz.Where(q => q.Id == id).Select(x => x.SvarIndex).First();
    if (Svaret.svar == Quiz[id].Svarmuligheder[svarIndex].ToString())
    {
        return true;
    }
    else
    {
        return false;
    }
});





app.Run();

record SvarMuligheder(string svar);


public class SpgIdUdenSvar
{
    public long Id { get; set; }
    public string SpgText { get; set; }
    public string[] Svarmuligheder { get; set; }
}

public class SpgUdenSvar
{
    public long Id { get; set; }
    public string SpgText { get; set; }
    public string[] Svarmuligheder { get; set; }
}

public class Spørgsmål
{
    public long Id { get; set; }
    public string SpgText { get; set; }
    public string[] Svarmuligheder { get; set; }
    public int SvarIndex { get; set; }
}

/*/
Opgave 3 - Mini-projekt: Byg en Quiz API

En quiz indeholder en spørgsmålstekst, samt mindst fire svarmuligheder. En af svarmulighederne er angivet som den rigtige.

Du skal som minimum implementere følgende endpoints:

GET /api/questions: Henter alle spørgsmål og deres svarmuligheder, men ikke hvilke svar der er de rigtige
GET /api/questions/{id}: Henter et bestemt spørgsmål og dets svarmuligheder, men ikke hvilket svar der er det rigtige
POST /api/questions/{id}/validate: Her kan postes et spørgsmåls-id og en svarmulighed, og så får man at vide, om svaret er rigtigt eller forkert
Sørg for der er noget testdata i programmet når det starter op. Det er ikke nødvendigt at gemme data i en rigtig database (bare brug et array eller en list).

Test API’en med Postman eller curl.
/*/
