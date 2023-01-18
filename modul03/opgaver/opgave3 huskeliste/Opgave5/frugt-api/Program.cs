var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

String[] frugter = new String[]
{
    "æble", "banan", "pære", "ananas"
};

// opgave 4 og 5
app.MapGet("/", () => "Dette er en frugt api");

app.MapGet("/api/fruit", () => frugter );

app.MapGet("/api/fruit/{index}", (int index) => frugter[index] );

app.MapGet("/api/fruit/random", () => 
{
    var random = new Random (); 
    return frugter [random.Next(frugter.Length)];
});


// opgave 6

app.MapPost("/api/fruit", (Fruit fruit) =>
{
    if (string.IsNullOrEmpty(fruit.name)) {
        // Return 400
        return Results.BadRequest();
    } else {
        frugter = frugter.Append(fruit.name).ToArray();
        return Results.Ok(frugter);
    }
});

app.Run();
record Fruit(string name);

