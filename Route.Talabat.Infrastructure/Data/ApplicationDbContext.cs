﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Route.Talabat.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Route.Talabat.Infrastructure.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }



		/// protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		/// 	=> optionsBuilder.UseSqlServer("connectionString");

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}


		public DbSet<Product> Products { get; set; }

		public DbSet<ProductBrand> Brands { get; set; }

		public DbSet<ProductCategory> Categories { get; set; }

	}
}