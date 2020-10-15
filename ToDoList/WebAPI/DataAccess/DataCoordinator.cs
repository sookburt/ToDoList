using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.ViewModels;

namespace WebAPI.DataAccess
{
  public class DataCoordinator
  {
    private IDataHandler _data;

    public DataCoordinator(IDataHandler data)
    {
      _data = data;
    }

    public List<ToDoItemViewModel> GetAllTasks()
    {
      List<ToDoItemDbModel> dbList = _data.GetTasks();

      return GetAllViewModels(dbList);
    }

    public ToDoItemViewModel GetTaskById(int id)
    {
      ToDoItemDbModel item = _data.GetTaskById(id);
      return ConvertModelToViewModel(item);
    }



    #region private methods

      private ToDoItemViewModel ConvertModelToViewModel(ToDoItemDbModel item)
      {
        ToDoItemViewModel viewModel = new ToDoItemViewModel()
        {
          Id = item.Id,
          Name = item.Name,
          IsDone = item.IsDone
        };

        return viewModel;

      }
      
      // to reduce risk of overposting.
      private ToDoItemDbModel ConvertViewModelToModel(ToDoItemViewModel item)
      {
        ToDoItemDbModel model = new ToDoItemDbModel()
        {
          Id = item.Id,
          Name = item.Name,
          IsDone = item.IsDone
        };

        return model;

      }

    private List<ToDoItemViewModel> GetAllViewModels(List<ToDoItemDbModel> items)
      {
        List<ToDoItemViewModel> viewModels = new List<ToDoItemViewModel>();
        foreach (var item in items)
        {
          viewModels.Add(ConvertModelToViewModel(item));
        }
        return viewModels;
      }

    #endregion

  }
}
