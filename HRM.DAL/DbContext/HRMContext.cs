﻿using HRM.DAL.EF;
using HRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HRM.DAL.DbContext
{
    public class HRMContext:System.Data.Entity.DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new UserMap());

            modelBuilder.Entity<User>()
               .HasMany<Team>(t => t.Team)
               .WithMany(u => u.User)
               .Map(tu =>
                        {
                            tu.MapLeftKey("UserId");
                            tu.MapRightKey("TeamId");
                            tu.ToTable("UserTeam");

                        });
                



        }
    }
}
