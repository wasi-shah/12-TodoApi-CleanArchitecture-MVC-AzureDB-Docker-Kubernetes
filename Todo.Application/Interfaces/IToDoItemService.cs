using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Entities;

namespace TodoApp.Application.Interfaces
{
    public interface IToDoItemService
    {
        Task<IEnumerable<ToDoItem>> GetAllItemsAsync();
        Task<ToDoItem> GetItemByIdAsync(int id);
        Task AddItemAsync(ToDoItem item);
        Task UpdateItemAsync(ToDoItem item);
        Task DeleteItemAsync(int id);
    }

}