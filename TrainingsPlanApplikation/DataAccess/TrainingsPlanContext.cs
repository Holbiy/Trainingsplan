using TrainingsPlanApplikation.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace TrainingsPlanApplikation.DataAccess
{
	public class TrainingsPlanContext : DbContext
	{
		public TrainingsPlanContext(DbContextOptions<TrainingsPlanContext> options) : base(options)
		{
		}
		
		public DbSet<TrainingPlan> TrainingPlans { get; set; }
		public DbSet<Exercise> Exercises { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<TrainingPlan>().ToTable("TrainingsPlan");
			modelBuilder.Entity<Exercise>().ToTable("Exercise");
		}
	}
}