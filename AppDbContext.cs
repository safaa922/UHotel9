﻿using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UHotel9.Tables;
using BCryptNet = BCrypt.Net.BCrypt;

namespace UHotel9
{
    public class ApplicationDbContext : DbContext
    {
        private FormStack formStack = new FormStack();
        private void ShowNewForm()
        {
            // Show the new form and push it onto the stack
            var newForm = new AnotherForm(formStack);
            formStack.Push(newForm);
            newForm.Show();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
           .Property(ue => ue.Password)
           .IsRequired();

            base.OnModelCreating(modelBuilder);

           // modelBuilder.Entity<Guest>()
           //.Property(e => e.phone)
           //.IsRequired()
           // .HasColumnType("nvarchar(150)")
           // .HasCheckConstraint("CK_YourEntity_NumericColumn", "[phone] LIKE '%[^0-9]%'");



            // modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Entity<Employee>()
            //    .Property(e => e.employeeAge)
            //    .IsRequired()
            //    .HasCheckConstraint("CheckConstraint", "employeeAge >= 0");


            // Other configuratiEons...

            // modelBuilder.Entity<Employee>()
            //.Property(e => e.employeeAge)
            //.IsRequired()
            //.HasAnnotation(CheckConstraint, employeeAge >= 0);
            // modelBuilder.Entity<Room>().ToTable("Rooms");

        }

      

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=UHotel2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Guest> Guests { get; set; }
       public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }


    }
}



