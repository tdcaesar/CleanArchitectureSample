﻿using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations;
internal sealed class RoleConfiguration : IEntityTypeConfiguration<RoleData>
{
    public void Configure(EntityTypeBuilder<RoleData> builder)
    {
        builder
            .HasKey(t => t.Id);
        builder
            .HasData(new RoleData
            {
                Id = Guid.Parse("00000004-0000-0000-0000-000000000001"),
                Name = "Reader",
                Description = "Read only general user role"
            },
            new RoleData
            {
                Id = Guid.Parse("00000004-0000-0000-0000-000000000002"),
                Name = "Author",
                Description = "Read/Write priviledged user role"
            },
            new RoleData
            {
                Id = Guid.Parse("00000004-0000-0000-0000-000000000003"),
                Name = "Admin",
                Description = "Administrator role"
            });
    }
}
