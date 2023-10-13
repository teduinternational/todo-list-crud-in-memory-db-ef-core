using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Api.Data
{
    [Table("Todos")]
    public class Todo
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public required string Title { get; set; }

        [Required]        
        public Priority Priority { get; set; }
        public DateTime? Deadline { get; set; }
        public Status Status { get; set; } = Status.Todo;

        [MaxLength(100)]
        public string? Assignee { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }

        [Required]
        public Guid AnonymousId { get; set; }
    }
    public enum Status
    {
        Todo,
        InProgress,
        Done,
        Canceled
    }
    public enum Priority
    {
        Low,
        Medium,
        High,
        Urgent
    }
}
