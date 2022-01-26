using DevFreela.API.Models;
using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    /// <summary>
    /// Essa é uma Action, que é uma classe contida dentro do controle,
    /// que é uma interface implementada pelas respostas padrão do HTTP,
    /// como Ok, Not Found, etc
    /// </summary>
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        // api/projects?query=net core
        [HttpGet]
        public IActionResult Get(string query)
        {
            // buscar todos ou filtrar

            var projects = _projectService.GetAll(query);
            return Ok(projects);
        }

        // api/projects/3
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var project = _projectService.GetById(id);

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewProjectInputModel createProject)
        {
            if (createProject.Title.Length > 50)
            {
                return BadRequest();
            }

            var id = _projectService.Create(createProject);
            
            return CreatedAtAction(nameof(GetById), new { id = id }, createProject);
        }

        // api/projects/2
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectInputModel updateProject)
        {
            if (updateProject.Description.Length < 5)
            {
                return BadRequest();
            }

            _projectService.Update(updateProject);

            return NoContent();
        }

        // api/projects/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _projectService.Delete(id);

            return NoContent();
        }

        [HttpPost("{id}/comments")]
        public IActionResult PostComments([FromBody] CreateCommentInputModel createComment)
        {
            _projectService.CreateComment(createComment);

            return NoContent();
        }

        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            _projectService.Start(id);

            return NoContent();
        }

        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            _projectService.Finish(id);

            return NoContent();
        }
    }
}