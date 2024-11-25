using AgendaApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp.Data.Mappings
{
    public class TarefaMap : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("TAREFA");

            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id)
                .HasColumnName("ID");

            builder.Property(t => t.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(t => t.Data)
                .HasColumnName("DATA")
                .HasColumnType("date")
                .IsRequired();

            builder.Property(t => t.Hora)
                .HasColumnType("time")
                .IsRequired();

            builder.Property(t => t.Prioridade)
                .HasColumnName("PRIORIDADE")
                .IsRequired();

            builder.Property(t => t.CategoriaId)
                .HasColumnName("CATEGORIAID")
                .IsRequired();

            builder.HasOne(t => t.Categoria)
                .WithMany(c => c.Tarefas)
                .HasForeignKey(t => t.CategoriaId);

        }
    }
}
