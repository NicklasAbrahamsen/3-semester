var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//opgave 3

app.MapGet("/", () => new { Message = "Hello world!" });

app.MapGet("/api/hello/", () => "Hello World!");

app.MapGet("/api/hello/{name}", (string name) => new { Message = $"Hello {name}!"});

app.MapGet("/api/hello/{name}/{age}", (string name, string age) => new { Message = $"Hello {name}! du er {age} gammel"});

app.Run();

/*/
Opgave 4 - Mere “hello” API

Du skal nu tilføje lidt nyt til hello-api’en.

Tilføj følgende endpoint til din kode og test den:

app.MapGet("/api/hello/{name}", (string name) => new { Message = $"Hello {name}!"));
Når du har fået den til at virke, skal du også tilføje kode, der svarer til dette endpoint:

GET /api/hello/{name}/{age}: En hello-funktion der hilser dig og fortæller dig din alder.
/*/