using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Models;
using WebApplication1.ResponseModel;

namespace WebApplication1.Services;

public class ProjectService : IProjectService
{
    private readonly ApbdContext _dbContext;

    public ProjectService(ApbdContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ProjectResponse> ShowProject(int IdProject)
    {
        var ProjectRaw = await _dbContext.Projects.Where(p => p.IdProject == IdProject).FirstAsync();
        var TasksRaw = await _dbContext.Tasks.Where(t => t.IdProject == IdProject).ToListAsync();

        var TasksReady = new List<TaskResponse>();
        
        foreach (var task in TasksRaw)
        {
            var TaskReady = new TaskResponse()
            {
                IdTask = task.IdTask,
                Name = task.Name,
                Description = task.Description,
                CreatedAt = task.CreatedAt,
                IdProject = task.IdProject,
                IdReporter = task.IdReporter,
                IdAssignee = task.IdAssignee,
                Reporter = await MapReporter(task.IdReporter),
                Assignee = await MapAssignee(task.IdAssignee)

            };
            TasksReady.Add(TaskReady);
        }

        return new ProjectResponse()
        {
            Tasks = TasksReady
        };
    }

    private async Task<ReporterResponse> MapReporter(int IdUser)
    {
        var User = await _dbContext.Users.Where(u => u.IdUser == IdUser).FirstAsync();

        return new ReporterResponse()
        {
            FirstName = User.FirstName,
            LastName = User.LastName
        };
    }

    private async Task<AssigneeResponse> MapAssignee(int IdUser)
    {
        var Assignee = await _dbContext.Users.Where(u => u.IdUser == IdUser).FirstAsync();

        return new AssigneeResponse()
        {
            FirstName = Assignee.FirstName,
            LastName = Assignee.LastName
        };
    }

    public Task<ICollection<ProjectResponse>> ShowAllProjects()
    {
        throw new NotImplementedException();
    }
}