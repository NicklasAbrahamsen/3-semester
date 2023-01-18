var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


KundeData[] kunder = new KundeData[8];

    kunder [0] = new KundeData {Id = 0, Name = "Nicklas", Email = "Hejsa@0", Erhverv = true };
    kunder [1] = new KundeData {Id = 1, Name = "Maty", Email = "Hejsa@1", Erhverv = true };
    kunder [2] = new KundeData {Id = 2, Name = "Michael", Email = "Hejsa@2", Erhverv = true};
    kunder [3] = new KundeData {Id = 3, Name = "Mathias", Email = "Hejsa@3", Erhverv = true};

// grunden til der står null er fordi det er en hurtigere måde at lave et array på hvor man kan tilføje data

app.MapGet("/api/kunde", () => kunder);

/*/
app.MapGet("/api/kunde/{id}", (int id) =>
{
    var kundEn = kunder.Where(t => t.Id == id);
    return kundEn;
});
/*/


app.MapGet("/api/kunde/{index}", (int index) => kunder[index]);

app.MapPut("/api/kunde/{id}", (NewKunde data, int id) =>
{
    var kundEn = kunder.Where(t => t.Id == id).First();
    kundEn.Name = data.Name;
    kundEn.Email = data.Email;
    return kundEn;
}
);

//app.MapDelete("/api/kunde/{index}", (int index) => kunder[index]);

app.MapDelete("api/kunde/{id}", (int id) => 
{
var kundEn = kunder.Where(t => t.Id ==id).First(); 
kundEn = null; 

});


// så de nye id'er starter fra 3
int NytId = 3; 
app.MapPost("/api/kunde/", (NewKunde data) => 
{
    NytId ++;
 kunder [NytId] = new KundeData {Id = NytId, Name = data.Name, Email = data.Email, Erhverv = data.Erhverv, Privat = data.Privat}; 
});

app.Run();
record NewKunde(int Id, string Name, string Email, bool Erhverv, bool Privat);

public class KundeData
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public bool Erhverv { get; set; }
    public bool Privat { get; set; }
}