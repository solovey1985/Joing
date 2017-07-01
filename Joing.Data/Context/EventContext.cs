using System.Data.Entity;
using Joing.Core;

namespace Joing.Data.Context
{
    public class EventContext : JoingContext<EventContext>
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Location> Locations { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Event>().HasKey(t => t.Id);
            modelBuilder.Entity<Event>().Ignore(t => t.DbState);
            modelBuilder.Entity<Event>().HasMany(t => t.Conditions)
                                        .WithRequired(x => x.Event)
                                        .WillCascadeOnDelete(false);
            modelBuilder.Entity<Event>().HasOptional(p => p.Place);

            modelBuilder.Entity<Location>().HasKey(l => l.Id).Ignore(t => t.DbState);




            modelBuilder.Entity<Condition>().Ignore(p => p.DbState);
            modelBuilder.Entity<Condition>().HasRequired(c => c.Event);

            modelBuilder.HasDefaultSchema("Events");

            base.OnModelCreating(modelBuilder);

        }
    }
}
