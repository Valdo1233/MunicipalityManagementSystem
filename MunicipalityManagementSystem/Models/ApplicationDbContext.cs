﻿using Microsoft.EntityFrameworkCore;
using MunicipalityManagementSystem.Models;

namespace MunicipalityManagementSystem.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}
