using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using R3AL.Data.Entities;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace R3AL.Data
{
    public interface IContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }

        ChangeTracker GetChangeTracker();

        DbConnection GetDbConnection();

        void Migrate();

        Task SaveAsync(CancellationToken cancellationToken = default);
    }
}