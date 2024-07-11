using Microsoft.EntityFrameworkCore;
using User.DataAccess.Entities;

namespace User.DataAccess.Context;

public class UsersDbContext : DbContext
{
    public UsersDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) =>
        Database.Migrate();

    public DbSet<UserEntity> Clients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        DataGenerator.Init();

        modelBuilder.Entity<UserEntity>().HasData(DataGenerator.Clients);
    }
}