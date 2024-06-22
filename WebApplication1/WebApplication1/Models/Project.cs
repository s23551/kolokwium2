using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("Project")]
public class Project
{
    [Key]
    public int IdProject { get; set; }
    
    [Required]
    [MaxLength(200)]
    public string Name { get; set; }

    [Required]
    public int  IdDefaultAssignee { get; set; }

    [Required]
    [ForeignKey("IdDefaultAssignee")]
    public virtual User DefaultAssignee { get; set; }

    public ICollection<Access> Accesses;
    public ICollection<Task> Tasks;
}