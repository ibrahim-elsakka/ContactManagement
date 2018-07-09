﻿using System.Data.Entity.Migrations;
using ContactManagement.Data.Entity;

namespace ContactManagement.Data.Migrations
{
	internal sealed class Configuration: DbMigrationsConfiguration<ContactManagementContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
		}

		protected override void Seed(ContactManagementContext context)
		{

			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data.

			//base.Seed(context);
		}
	}
}
