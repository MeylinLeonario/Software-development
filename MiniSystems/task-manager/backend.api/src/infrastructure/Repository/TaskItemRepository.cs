using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.api.src.Domain.Models;
using backend.api.src.infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace backend.api.src.infrastructure.Repository
{
    public class TaskItemRepository : ITaskItemRepository
    {
        private readonly AppDbContext _context;
        public TaskItemRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task Create(TaskItem taskItem)
        {
            await _context.taskItems.AddAsync(taskItem);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(TaskItem taskItem)
        {
            _context.taskItems.Remove(taskItem);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(TaskItem taskItem)
        {
            _context.taskItems.Update(taskItem);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TaskItem>> List()
        {
            return await _context.taskItems.ToListAsync();
        }

        public async Task Review(TaskItem taskItem)
        {
            await _context.taskItems
                .FirstOrDefaultAsync(x => x.id == taskItem.id);
            await _context.SaveChangesAsync();
        }
    }
}