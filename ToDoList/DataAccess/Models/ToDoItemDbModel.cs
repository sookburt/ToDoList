using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
  public class ToDoItemDbModel
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsDone { get; set; }

  }
}
