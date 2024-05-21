using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DiplomWork.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=EFModel")
        {
        }

        public virtual DbSet<Administrator> Administrator { get; set; }
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Exercise> Exercise { get; set; }
        public virtual DbSet<ExerciseType> ExerciseType { get; set; }
        public virtual DbSet<Passport> Passport { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<Timetable> Timetable { get; set; }
        public virtual DbSet<Trainer> Trainer { get; set; }
        public virtual DbSet<TypeOfActivity> TypeOfActivity { get; set; }
        public virtual DbSet<Workout> Workout { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>()
                .HasMany(e => e.Timetable)
                .WithRequired(e => e.Administrator)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Application)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExerciseType>()
                .HasMany(e => e.Exercise)
                .WithRequired(e => e.ExerciseType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Passport>()
                .HasMany(e => e.Client)
                .WithRequired(e => e.Passport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trainer>()
                .HasMany(e => e.Application)
                .WithRequired(e => e.Trainer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trainer>()
                .HasMany(e => e.Timetable)
                .WithRequired(e => e.Trainer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeOfActivity>()
                .HasMany(e => e.Application)
                .WithRequired(e => e.TypeOfActivity)
                .WillCascadeOnDelete(false);
        }
    }
}
