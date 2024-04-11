using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal
{
    public class VendaNfe
    {
        [DisplayName("CONTROLE")]
        public int? Controle { get; set; }

        [DisplayName("DATAEMISSAO")]
        public DateTime? DataEmissao { get; set; }

        [DisplayName("STATUSDEENVIO")]
        public string StatusEnvio { get; set; }

        [DisplayName("CODCLIENTE")]
        public int? CodCliente { get; set; }

        [DisplayName("CODFORNECEDOR")]
        public int? CodFornecedor { get; set; }
    }

    public class VendaNfeEntityTypeConfiguration : IEntityTypeConfiguration<VendaNfe>
    {
        public void Configure(EntityTypeBuilder<VendaNfe> builder)
        {
            builder.ToTable("TVENDANFE");

            builder.HasKey(e => e.Controle);

            builder.Property(e => e.Controle).HasColumnName("CONTROLE");

            builder.Property(e => e.DataEmissao).HasColumnName("DATAEMISSAO");

            builder.Property(e => e.StatusEnvio).HasColumnName("STATUSDEENVIO");

            builder.Property(e => e.CodCliente).HasColumnName("CODCLIENTE");

            builder.Property(e => e.CodFornecedor).HasColumnName("CODFORNECEDOR");
        }
    }
}
