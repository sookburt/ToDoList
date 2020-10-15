using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
  public class InMemoryDatabase : IDataHandler
  {

    public List<ToDoItemDbModel> ToDoList { get; set; }

    public InMemoryDatabase()
    {
      ToDoList = new List<ToDoItemDbModel> {
        new ToDoItemDbModel { Id = 1, Name = "Task 1", IsDone = false },
        new ToDoItemDbModel { Id = 2, Name = "Task 2", IsDone = false }
      };
    }

    public List<ToDoItemDbModel> GetTasks()
    {
      return ToDoList;
    }

    public ToDoItemDbModel GetTaskById(int id)
    {
      Dictionary<int, ToDoItemDbModel> d = ToDoList.ToDictionary(x => x.Id, x => x);

      bool exists = d.TryGetValue(id, out ToDoItemDbModel item);

      if(exists)
      {
        return item;
      }

      return null;
    }
  }
}
