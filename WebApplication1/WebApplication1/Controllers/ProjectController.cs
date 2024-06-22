using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/task")]
public class ProjectController : ControllerBase
{
    private readonly IProjectService _projectService;

    [HttpGet("{projectId:int}")]
    public async Task<IActionResult> ShowProject([FromQuery] int? projectId)
    {
        var IdProject = (int)projectId;
        
        if (projectId != null)
        {
            return Ok(_projectService.ShowProject(IdProject));
        }

        
        return Ok(_projectService.ShowAllProjects());

    }
}