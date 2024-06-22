using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models;

[Table("Access")]
public class Access
{
    
    [Required]
    public int IdUser { get; set; }
    [Required]
    public int IdProject { get; set; }
    
    [ForeignKey("IdUser")]
    public virtual User User { get; set; }
    
    [ForeignKey("IdProject")]
    public virtual Project Project { get; set; }
    
}