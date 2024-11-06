using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models.Models
{
    public class ToDoTask
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        [Required]
        public bool IsCompleted { get; set; } = false;

        // reference
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
