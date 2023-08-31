﻿using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EFCore.Config
{
    public class RoleConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            _ = builder.HasData(
                new Rol
                {
                    Id = 1,
                    Name = "User",
                    NormalizedName = "USER"
                },
                new Rol
                {
                    Id = 2,
                    Name = "Editor",
                    NormalizedName = "EDITOR"
                },
                new Rol
                {
                    Id = 3,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }
            );
        }
    }
}

