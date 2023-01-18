// TodoTask.cs
namespace Model
{
    public class TodoTask
    {
        public TodoTask(string text, int område, bool done, string user,string catagory) {
            this.Text = text;
            this.Område = område;
            this.Done = done;
            this.User = user;
            this.Catagory = catagory;
        }
        public long TodoTaskId { get; set; }
        public string? Text { get; set; }

        public string User { get; set; }
          public string Catagory { get; set; }

        public int Område { get; set; }
        public bool Done { get; set; }
    }
}