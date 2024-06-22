using WebApplication1.ResponseModel;

namespace WebApplication1.Services;

public interface IProjectService
{
    Task<ProjectResponse> ShowProject(int IdProject);
    Task<ICollection<ProjectResponse>> ShowAllProjects();
}