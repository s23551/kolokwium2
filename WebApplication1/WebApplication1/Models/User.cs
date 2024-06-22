using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("User")]
public class User
{
    [Key]
    public int IdUser { get; set; }

    [Required]
    [MaxLength(200)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(200)]
    public string LastName { get; set; }
    
    public virtual ICollection<Access> Accesses { get; set; }
    public virtual ICollection<Project> Projects { get; set; }
    public virtual ICollection<Task> TaskReported { get; set; }
    public virtual ICollection<Task> TaskAssigned { get; set; }
}