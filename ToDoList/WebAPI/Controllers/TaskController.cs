using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DataAccess;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TaskController : ControllerBase
  {
    private DataCoordinator _data;

    public TaskController(DataCoordinator data)
    {
      _data = data;
    }
    
    
    [HttpGet] // GET api/task
    public ActionResult<IEnumerable<ToDoItemViewModel>> Get()
    {
      List<ToDoItemViewModel> tasks = _data.GetAllTasks();
      return tasks;
    }

    
    [HttpGet("{id}")] // GET api/task/5
    public ActionResult<ToDoItemViewModel> Get(int id)
    {
      ToDoItemViewModel item = _data.GetTaskById(id);

      if(item == null)
      {
        return NotFound();
      }
      
      return item;
    }

    
    [HttpPost] // POST api/task
    public void Post([FromBody] ToDoItemViewModel item)
    {

    }

    
    [HttpPut("{id}")] // PUT api/task/5
    public void Put(int id, [FromBody] ToDoItemViewModel item)
    {
    }

    
    [HttpDelete("{id}")] // DELETE api/task/5
    public void Delete(int id)
    {
    }
  }
}
