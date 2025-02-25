﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Entities;

namespace TodoApp.Application.Interfaces
{
    public interface IToDoListRepository
    {
        Task<IEnumerable<ToDoList>> GetAllListsAsync();
        Task<IEnumerable<ToDoList>> GetListsByUserIdAsync(int userId);
        Task<ToDoList> GetListByIdAsync(int id);
        Task AddListAsync(ToDoList list);
        Task UpdateListAsync(ToDoList list);
        Task DeleteListAsync(int id);
    }
}
