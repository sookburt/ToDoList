using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI.DataAccess
{
  public class DataCoordinator
  {
    // TODO: create inMemoryDatabase private variable for interface (create interface) and inject in new constructor

    public List<ToDoItem> GetAllTasks()
    {
      InMemoryDatabase data = new InMemoryDatabase(); // use dependency injection to get this.
      return data.GetTasks(); // TODO: convert to view model
    }

    public ToDoItem GetTaskById(int id)
    {
      InMemoryDatabase data = new InMemoryDatabase(); // use dependency injection to get this.
      return data.GetTaskById(id); // TODO: convert to view model
    }
  }
}
