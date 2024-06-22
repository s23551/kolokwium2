using WebApplication1.Models;

namespace WebApplication1.ResponseModel;

public class TaskResponse
{
    public int IdTask { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public int IdProject { get; set; }
    public int IdReporter { get; set; }
    public ReporterResponse Reporter { get; set; }
    public int IdAssignee { get; set; }
    public AssigneeResponse Assignee { get; set; }
    
}