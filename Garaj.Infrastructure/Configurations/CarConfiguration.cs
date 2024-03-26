using Garaj.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaj.Infrastructure.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description)
                .HasMaxLength(120)
                .IsRequired(false);

            builder.Property(x => x.Model)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(x => x.Brand)
                .HasMaxLength(30)
                .IsRequired();
            builder.HasData(new Car()
            {
                Model = "Damas",
                Brand="Chevrolet",
                Description = "Zo'r buxanka",
                Price=60000
            });
        }
    }
}
