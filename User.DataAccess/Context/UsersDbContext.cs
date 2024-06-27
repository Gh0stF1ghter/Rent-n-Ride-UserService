using Microsoft.EntityFrameworkCore;
using User.DataAccess.Entities;

namespace User.DataAccess.Context;

public class UsersDbContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
{
    public DbSet<UserEntity> Clients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        DataGenerator.Init();

        modelBuilder.Entity<UserEntity>().HasData(DataGenerator.Clients);
    }
}