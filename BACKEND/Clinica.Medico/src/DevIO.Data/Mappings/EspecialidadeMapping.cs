using DevIO.Bussines.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Mappings
{
    public class EspecialidadeMapping : IEntityTypeConfiguration<Especialidade>
    {
        public void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            builder.HasKey(prop => prop.Id);

            //1 : N Especialidade : Medicos
            builder.HasMany(e => e.EspecialidadeMedicos)
                .WithOne(m => m.Especialidade)
                .HasForeignKey(m => m.EspecialidadeId);

            
        }
    }
}
