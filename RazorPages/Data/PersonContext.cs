using Microsoft.EntityFrameworkCore;

public class PersonContext : DbContext
{
    public PersonContext(DbContextOptions options) : base(options) { }
    public DbSet<PersonModel> Persons { get; set; }
}