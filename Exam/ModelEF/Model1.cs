using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Exam.ModelEF
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ClientBuffet> ClientBuffet { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<ClientsRooms> ClientsRooms { get; set; }
        public virtual DbSet<ConditionsRoom> ConditionsRoom { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<RoomType> RoomType { get; set; }
        public virtual DbSet<TypeBuffetAccess> TypeBuffetAccess { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>()
                .HasMany(e => e.ClientBuffet)
                .WithOptional(e => e.Clients)
                .HasForeignKey(e => e.IDClient);

            modelBuilder.Entity<Clients>()
                .HasMany(e => e.ClientsRooms)
                .WithOptional(e => e.Clients)
                .HasForeignKey(e => e.IDClient);

            modelBuilder.Entity<ConditionsRoom>()
                .HasMany(e => e.ClientsRooms)
                .WithOptional(e => e.ConditionsRoom)
                .HasForeignKey(e => e.IDConditionsRoom);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.Workers)
                .WithOptional(e => e.Roles)
                .HasForeignKey(e => e.IDRole);

            modelBuilder.Entity<Rooms>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Rooms>()
                .HasMany(e => e.ClientsRooms)
                .WithOptional(e => e.Rooms)
                .HasForeignKey(e => e.IDRoom);

            modelBuilder.Entity<RoomType>()
                .HasMany(e => e.Rooms)
                .WithOptional(e => e.RoomType)
                .HasForeignKey(e => e.IDTypeRoom);

            modelBuilder.Entity<TypeBuffetAccess>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TypeBuffetAccess>()
                .HasMany(e => e.ClientBuffet)
                .WithOptional(e => e.TypeBuffetAccess)
                .HasForeignKey(e => e.IDTypeBuffetAccess);

            modelBuilder.Entity<Workers>()
                .HasMany(e => e.Clients)
                .WithOptional(e => e.Workers)
                .HasForeignKey(e => e.IDWorkers);

            modelBuilder.Entity<Workers>()
                .HasMany(e => e.ClientsRooms)
                .WithOptional(e => e.Workers)
                .HasForeignKey(e => e.IDWorkers);
        }
    }
}
