using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCData; 

public class ForumContext :DbContext
{
    public DbSet<Forum> Forums { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<SubForum> SubForums { get; set; }
    public DbSet<Post> Posts { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlite(
            @"Data Source =C:\Users\Bruger\RiderProjects\DNP1-Assignment1-master\WebApi\Forums.db");
    }
}