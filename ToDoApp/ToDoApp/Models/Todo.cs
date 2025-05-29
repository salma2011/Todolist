using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsFinish { get; set; }
    }
}
