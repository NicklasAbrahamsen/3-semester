namespace Model
{
    public class Board
    {
        public Board()
        {
        }

        public List<Todo> Todoes { get; set; } = new List<Todo>();
        public int BoardId { get; set; }
        
    }
}