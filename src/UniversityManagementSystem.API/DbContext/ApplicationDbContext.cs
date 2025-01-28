using Microsoft.EntityFrameworkCore;
using UniversityManagementSystem.API.Models;

namespace UniversityManagementSystem.API.DbContext;

public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Department> Departments { get; set; }
}