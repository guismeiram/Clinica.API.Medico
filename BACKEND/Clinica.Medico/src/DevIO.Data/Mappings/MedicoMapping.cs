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
    public class MedicoMapping : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Idade)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(c => c.Crm)
                .HasColumnType("varchar(250)");

            //1 : N Medico : Especialidades
            builder.HasMany(e => e.MedicoEspecialidades)
                .WithOne(m => m.Medico)
                .HasForeignKey(m => m.MedicoId);

            builder.Property(c => c.Telefone)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Ddd)
                .IsRequired()
                .HasColumnType("varchar(200)");

            //1 : 1 Medico : Consulta
            builder.HasOne(e => e.Consultas)
                .WithOne(m => m.Medico);

            builder.ToTable("Medico");
        }
    }
}
