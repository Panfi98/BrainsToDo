using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using BrainsToDo.Models;
using Task = BrainsToDo.Models.Task;

namespace BrainsToDo.Data
{
  public class DataContext : DbContext
  {
    private string _connectionString;
    
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
      var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
      _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseNpgsql(_connectionString);
      optionsBuilder.LogTo(message => Debug.WriteLine(message));
    }
    
    public DbSet<User> User { get; set; }
    public DbSet<Task> Task { get; set; }
    public DbSet<Company> Company { get; set; }
    public DbSet<Contact> Contact { get; set; }
    public DbSet<CoverLetter> CoverLetter { get; set; }
    public DbSet<Education> Education { get; set; }
    public DbSet<Experience> Experience { get; set; }
    public DbSet<Job> Job { get; set; }
    public DbSet<JobApplication> JobApplication { get; set; }
    public DbSet<JobMatch> JobMatch { get; set; }
    public DbSet<JobSkill> JobSkill { get; set; }
    public DbSet<Person> Person { get; set; }
    public DbSet<Project> Project { get; set; }
    public DbSet<Reference> Reference { get; set; }
    public DbSet<Resume> Resume { get; set; }
    public DbSet<ResumeTemplate> ResumeTemplate { get; set; }
    public DbSet<Skill> Skill { get; set; }
    public DbSet<UserSkill> UserSkill { get; set; }
    public DbSet<Сertification> Сertification { get; set; }

  }  
}

