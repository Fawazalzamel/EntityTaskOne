using Microsoft.EntityFrameworkCore;

namespace EntityTaskOne.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blog { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data source=blogging.db");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Blog[] blogs = [new Blog() { 
            Id = 1,Name = "yousef", Url= "www.google.com"
            }];

            modelBuilder.Entity<Blog>().HasData(blogs);

        }


    }


}
