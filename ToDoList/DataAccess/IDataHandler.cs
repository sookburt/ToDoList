using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
  public interface IDataHandler
  {

    List<ToDoItemDbModel> GetTasks();

    ToDoItemDbModel GetTaskById(int id);

  }
}
