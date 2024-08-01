using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlazorApp2.Models;

namespace BlazorApp2.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<BlazorApp2.Models.Semesters> Semesters { get; set; } = default!;
        public DbSet<BlazorApp2.Models.Departments> Departments { get; set; } = default!;
        public DbSet<BlazorApp2.Models.Majors> Majors { get; set; } = default!;
    }
}
