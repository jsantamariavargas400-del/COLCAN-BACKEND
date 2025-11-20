using Dto.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    public class ColcanContex : DbContext
    {

        public ColcanContex(DbContextOptions<ColcanContex> options) : base(options)
        {

        }

        public virtual DbSet<ResultSp> ResultSp { get; set;}
        public virtual DbSet<Response> Response { get; set;}
        public virtual DbSet<MaestroModel> MaestroModel { get; set;}
      




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ResultSp>().HasNoKey();
            modelBuilder.Entity<Response>().HasNoKey();
            modelBuilder.Entity<MaestroModel>().HasNoKey();



            base.OnModelCreating(modelBuilder);
        }

    }
}
