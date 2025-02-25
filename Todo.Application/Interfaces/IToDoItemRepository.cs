using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Entities;

namespace TodoApp.Application.Interfaces
{
    public interface IToDoItemRepository
    {
        Task<IEnumerable<ToDoItem>> GetAllItemsAsync();
        Task<IEnumerable<ToDoItem>> GetItemsByListIdAsync(int toDoListId);
        Task<ToDoItem> GetItemByIdAsync(int id);
        Task AddItemAsync(ToDoItem item);
        Task UpdateItemAsync(ToDoItem item);
        Task DeleteItemAsync(int id);
    }
}