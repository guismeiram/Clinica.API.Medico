using DevIO.Bussines.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Mappings
{
    public class ClinicaMapping : IEntityTypeConfiguration<Clinica>
    {
        public void Configure(EntityTypeBuilder<Clinica> builder)
        {
            builder.HasKey(prop => prop.Id);

            builder.Property(c => c.NomeClinica)
                .IsRequired()
                .HasColumnType("varchar(200)");

            

        }
    }
}
