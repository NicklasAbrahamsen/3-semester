namespace Model
{
    public class Todo
    {
        public Todo(string name, string category, User user)

        {
            this.Name = name;
            this.Category = category;
            this.User = user;


        }
        public Todo()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public User User { get; set; }
    }
}