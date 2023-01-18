var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


TaskData[] todoes = new TaskData[8];

    todoes [0] = new TaskData {Id = 0, Text = "Bejer", Done = true};
    todoes [1] = new TaskData {Id = 1, Text = "Arbejde", Done = false};
    todoes [2] = new TaskData {Id = 2, Text = "Fester", Done = true};
    todoes [3] = new TaskData {Id = 3, Text = "Damer", Done = true};

// grunden til der står null er fordi det er en hurtigere måde at lave et array på hvor man kan tilføje data

app.MapGet("/api/tasks", () => todoes);

/*/
app.MapGet("/api/tasks/{id}", (int id) =>
{
    var todoEn = todoes.Where(t => t.Id == id);
    return todoEn;
});
/*/


app.MapGet("/api/tasks/{index}", (int index) => todoes[index]);

app.MapPut("/api/tasks/{id}", (NewTodo data, int id) =>
{
    var todoEn = todoes.Where(t => t.Id == id).First();
    todoEn.Text = data.Text;
    return todoEn;
}
);

//app.MapDelete("/api/tasks/{index}", (int index) => todoes[index]);

app.MapDelete("api/tasks/{id}", (int id) => 
{
var todoEn = todoes.Where(t => t.Id ==id).First(); 
todoEn = null; 

});


// så de nye id'er starter fra 3
int NytId = 3; 
app.MapPost("/api/tasks/", (NewTodo data) => 
{
    NytId ++;
 todoes [NytId] = new TaskData {Id = NytId, Text = data.Text, Done = data.Done}; 
});

app.Run();
record NewTodo(int Id, string Text, bool Done);

public class TaskData
{
    public int Id { get; set; }
    public string Text { get; set; }
    public bool Done { get; set; }
}