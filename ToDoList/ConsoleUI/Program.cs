using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
  class Program
  {
    static void Main(string[] args)
    {
      foreach (var task in GetTasks())
      {
        Console.WriteLine(task.Name);
      }
    }

    private static List<ToDoItemDbModel> GetTasks()
    {
      InMemoryDatabase data = new InMemoryDatabase();
      return data.GetTasks();
    }
  }
}
