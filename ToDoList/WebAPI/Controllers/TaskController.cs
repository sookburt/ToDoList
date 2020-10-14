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
    // GET api/task
    [HttpGet]
    public ActionResult<IEnumerable<ToDoItem>> Get()
    {
      var data = new DataCoordinator();
      List<ToDoItem> tasks = data.GetAllTasks();
      return tasks;
    }

    // GET api/task/5
    [HttpGet("{id}")]
    public ActionResult<ToDoItem> Get(int id)
    {
      var data = new DataCoordinator();
      ToDoItem item = data.GetTaskById(id);

      if(item == null)
      {
        return NotFound();
      }
      
      return item;
    }

    // POST api/task
    [HttpPost]
    public void Post([FromBody] ToDoItem item)
    {

    }

    // PUT api/task/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] ToDoItem item)
    {
    }

    // DELETE api/task/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
