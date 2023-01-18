using System.Collections.Generic;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Kunder[] kunde = new Kunder[] {
    new Kunder { Id = 1, Navn = "Nicklas",Email = "hejsa@1", Erhverv = true},
    new Kunder { Id = 2, Navn = "Michael",Email = "hejsa@2", Privat = true},
    new Kunder { Id = 3, Navn = "Matty", Email = "hejsa@3", Erhverv = true},
};

List<KunderList> kundelist = new List<KunderList> {
new KunderList { Id = 1, Navn = "Nicklas",Email = "hejsa@1", Erhverv = true},
new KunderList { Id = 2, Navn = "Michael",Email = "hejsa@2", Privat = true},
new KunderList { Id = 3, Navn = "Matty", Email = "hejsa@3", Erhverv = true},
};

app.MapGet("/api/kundelist/", () => kundelist);

app.MapGet("/api/kundelist/{id}", (int id) => {
    return Results.Ok(kundelist.Where(t => t.Id == id));
});

/*
GET /api/kunde
GET /api/kunde/{id}
PUT /api/kunde/{id}
DELETE /api/kunde/{id}
POST /api/kunde/
*/

app.MapGet("/", () => "Dette er en kunde api");

app.MapGet("/api/kunde/", () => kunde);

app.MapGet("/api/kunde/{id}", (int id) => {
    return Results.Ok(kunde.Where(t => t.Id == id));
});


int NytId = 3; 
app.MapPost("/api/kunde/", (NewKunde data) => 
{
    NytId ++;
 kunde [NytId] = new Kunder {Id = NytId, Navn = data.Navn, Email = data.Email, Erhverv = data.Erhverv, Privat = data.Privat}; 
});

app.MapDelete("/api/kunde/{id}", (int id) =>
{
    kunde = kunde.Where(t => t.Id != id).ToArray();
    return Results.Ok(kunde);
});

app.Run();
record NewKunde(int Id, string Navn, string Email, bool Erhverv, bool Privat);


public class Kunder {
    public int Id { get; set; }
    public string Navn { get; set; }
    public string Email { get; set; }
    public bool Erhverv { get; set; }
    public bool Privat { get; set; }
}

public class KunderList {
    public int Id { get; set; }
    public string Navn { get; set; }
    public string Email { get; set; }
    public bool Erhverv { get; set; }
    public bool Privat { get; set; }
}