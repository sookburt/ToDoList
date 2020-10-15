using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DataAccess;

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
    public ActionResult<IEnumerable<ToDoItem>> Get()
    {
      List<ToDoItem> tasks = _data.GetAllTasks();
      return tasks;
    }

    
    [HttpGet("{id}")] // GET api/task/5
    public ActionResult<ToDoItem> Get(int id)
    {
      ToDoItem item = _data.GetTaskById(id);

      if(item == null)
      {
        return NotFound();
      }
      
      return item;
    }

    
    [HttpPost] // POST api/task
    public void Post([FromBody] ToDoItem item)
    {

    }

    
    [HttpPut("{id}")] // PUT api/task/5
    public void Put(int id, [FromBody] ToDoItem item)
    {
    }

    
    [HttpDelete("{id}")] // DELETE api/task/5
    public void Delete(int id)
    {
    }
  }
}
