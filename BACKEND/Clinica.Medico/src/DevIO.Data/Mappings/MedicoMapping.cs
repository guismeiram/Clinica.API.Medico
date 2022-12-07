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

            

            builder.Property(c => c.Telefone)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Ddd)
                .IsRequired()
                .HasColumnType("varchar(200)");

            //1 : 1 Medico : Clinica
            builder.HasOne(e => e.Clinicas)
                .WithOne(m => m.Medicos);

            //1 : N Medico : Consulta
            builder.HasMany(c => c.Consultas)
               .WithOne(p => p.Medicos)
               .HasForeignKey(p => p.MedicoId);

            builder.ToTable("Medico");
        }
    }
}
