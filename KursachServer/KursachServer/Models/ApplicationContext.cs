using KursachServer.Models.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursachServer.Models
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext()
		{
			this.Database.EnsureCreated();
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS01;Initial Catalog=kursachdatabase;Trusted_connection=True");
		}

		public virtual DbSet<Service> Services { get; set; }
		public virtual DbSet<Country> Countries { get; set; }
		public  virtual DbSet<Ticket> Tickets { get; set; }
		public virtual DbSet<TicketType> TicketTypes { get; set; }
		public virtual DbSet<City> Cities { get; set; }
		public virtual DbSet<Street> Streets { get; set; }
		public virtual DbSet<House> Houses { get; set; }
		public virtual DbSet<FLat> Flats { get; set; }
		public virtual DbSet<Customer> Customers { get; set; }
	}
}
