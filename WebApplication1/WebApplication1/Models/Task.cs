using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("Task")]
public class Task
{
    [Key]
    public int IdTask { get; set; }

    [Required]
    [MaxLength(200)]
    public string Name { get; set; }

    [Required]
    [MaxLength(1000)]
    public string Description { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

    [Required]
    public int IdProject { get; set; }
    
    [Required]
    public int IdReporter { get; set; }
    
    [Required]
    public int IdAssignee { get; set; }
    
    [ForeignKey("IdProject")]
    public virtual Project Project { get; set; }
    
    [ForeignKey("IdReporter")]
    public virtual User Reporter { get; set; }
    
    [ForeignKey("IdAssignee")]
    public virtual User Assignee { get; set; }
    
}