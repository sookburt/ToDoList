using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.ViewModels
{
  public class ToDoItemViewModel
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsDone { get; set; }

  }
}
