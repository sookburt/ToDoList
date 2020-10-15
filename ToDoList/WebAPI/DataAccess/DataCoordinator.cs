using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAPI.DataAccess
{
  public class DataCoordinator
  {
    private IDataHandler _data;

    public DataCoordinator(IDataHandler data)
    {
      _data = data;
    }

    public List<ToDoItem> GetAllTasks()
    {
      return _data.GetTasks(); // TODO: convert to view model
    }

    public ToDoItem GetTaskById(int id)
    {
      return _data.GetTaskById(id); // TODO: convert to view model
    }
  }
}
