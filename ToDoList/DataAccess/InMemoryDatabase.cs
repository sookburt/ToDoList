using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
  public class InMemoryDatabase
  {

    public List<ToDoItem> ToDoList { get; set; }

    public InMemoryDatabase()
    {
      ToDoList = new List<ToDoItem> {
        new ToDoItem { Id = 1, Name = "Task 1", IsDone = false },
        new ToDoItem { Id = 2, Name = "Task 2", IsDone = false }
      };
    }

    public List<ToDoItem> GetTasks()
    {
      return ToDoList;
    }

    public ToDoItem GetTaskById(int id)
    {
      Dictionary<int, ToDoItem> d = ToDoList.ToDictionary(x => x.Id, x => x);

      bool exists = d.TryGetValue(id, out ToDoItem item);

      if(exists)
      {
        return item;
      }

      return null;
    }
  }
}
