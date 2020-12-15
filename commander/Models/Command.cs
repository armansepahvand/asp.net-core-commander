namespace Commander.Models
{
    //create a model for our commands
    public class Command
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }
        public string Platform { get; set; }

    }
}