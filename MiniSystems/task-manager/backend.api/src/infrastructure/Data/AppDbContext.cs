using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.api.src.Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace backend.api.src.infrastructure.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<TaskItem> taskItems {get; set;}
    }
}