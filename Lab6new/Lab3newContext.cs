using System;
using System.Collections.Generic;
using Lab6new.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Lab6new;

public partial class Lab3newContext : DbContext
{
    public Lab3newContext()
    {
    }

    public Lab3newContext(DbContextOptions<Lab3newContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Act> Acts { get; set; }

    public virtual DbSet<Animal> Animals { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<Cost> Costs { get; set; }

    public virtual DbSet<Locality> Localities { get; set; }

    public virtual DbSet<Organisation> Organisations { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<District> Districts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=lab3new;Username=postgres;Password=6776");
    } 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Act>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Act_pkey");

            entity.ToTable("Act");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnimalId).HasColumnName("animal_id");
            entity.Property(e => e.ContractId).HasColumnName("contract_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.LocalityId).HasColumnName("locality_id");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(255)
                .HasColumnName("serial_number");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Animal).WithMany(p => p.Acts)
                .HasForeignKey(d => d.AnimalId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_act_animal");

            entity.HasOne(d => d.Contract).WithMany(p => p.Acts)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_act_contract");

            entity.HasOne(d => d.Locality).WithMany(p => p.Acts)
                .HasForeignKey(d => d.LocalityId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_act_locality");

            entity.HasOne(d => d.User).WithMany(p => p.Acts)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_act_user");
        });

        modelBuilder.Entity<Animal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Animal_pkey");

            entity.ToTable("Animal");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BirthYear).HasColumnName("birth_year");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.ChipNumber)
                .HasMaxLength(255)
                .HasColumnName("chip_number");
            entity.Property(e => e.LocalityId).HasColumnName("locality_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Photo)
                .HasMaxLength(255)
                .HasColumnName("photo");
            entity.Property(e => e.RegistrationNumber)
                .HasMaxLength(255)
                .HasColumnName("registration_number");
            entity.Property(e => e.Sex).HasColumnName("sex");
            entity.Property(e => e.SpecialSigns)
                .HasMaxLength(255)
                .HasColumnName("special_signs");

            entity.HasOne(d => d.Locality).WithMany(p => p.Animals)
                .HasForeignKey(d => d.LocalityId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_animal_locality");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Contract_pkey");

            entity.ToTable("Contract");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.Number)
                .HasMaxLength(255)
                .HasColumnName("number");
            entity.Property(e => e.OrderOrganisationId).HasColumnName("order_organisation_id");
            entity.Property(e => e.PerformOrganisationId).HasColumnName("perform_organisation_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");

            entity.HasOne(d => d.OrderOrganisation).WithMany(p => p.ContractOrderOrganisations)
                .HasForeignKey(d => d.OrderOrganisationId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_contract_organisation_order");

            entity.HasOne(d => d.PerformOrganisation).WithMany(p => p.ContractPerformOrganisations)
                .HasForeignKey(d => d.PerformOrganisationId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_contract_organisation_perform");
        });
        modelBuilder.Entity<Cost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Cost_pkey");

            entity.ToTable("Cost");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContractId).HasColumnName("contract_id");
            entity.Property(e => e.Cost1).HasColumnName("cost");
            entity.Property(e => e.LocalityId).HasColumnName("locality_id");

            entity.HasOne(d => d.Contract).WithMany(p => p.Costs)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_cost_contract");

            entity.HasOne(d => d.Locality).WithMany(p => p.Costs)
                .HasForeignKey(d => d.LocalityId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_cost_locality");
        });

        modelBuilder.Entity<Locality>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Locality_pkey");

            entity.ToTable("Locality");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Locality1)
                .HasMaxLength(255)
                .HasColumnName("locality");

            entity.Property(e => e.DistrictId).HasColumnName("district_id");

            entity.HasOne(d => d.District).WithMany(p => p.Localities)
                .HasForeignKey(d => d.DistrictId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_locality_district");
        });

        modelBuilder.Entity<District>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("District_pkey");

            entity.ToTable("District");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.District1)
                .HasMaxLength(255)
                .HasColumnName("district");
        });

        modelBuilder.Entity<Organisation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Organisation_pkey");

            entity.ToTable("Organisation");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.Entity).HasColumnName("entity");
            entity.Property(e => e.FullName)
                .HasMaxLength(255)
                .HasColumnName("full_name");
            entity.Property(e => e.Inn)
                .HasMaxLength(255)
                .HasColumnName("inn");
            entity.Property(e => e.Kpp)
                .HasMaxLength(255)
                .HasColumnName("kpp");
            entity.Property(e => e.LocalityId).HasColumnName("locality_id");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");

            entity.HasOne(d => d.Locality).WithMany(p => p.Organisations)
                .HasForeignKey(d => d.LocalityId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_organisation_locality");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("User_pkey");

            entity.ToTable("User");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("last_name");
            entity.Property(e => e.Login)
                .HasMaxLength(255)
                .HasColumnName("login");
            entity.Property(e => e.OrganisationId).HasColumnName("organisation_id");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(255)
                .HasColumnName("patronymic");
            entity.Property(e => e.Role)
                .HasMaxLength(255)
                .HasColumnName("role");

            entity.HasOne(d => d.Organisation).WithMany(p => p.Users)
                .HasForeignKey(d => d.OrganisationId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_user_organisation");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
