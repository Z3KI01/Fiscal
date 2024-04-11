using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal
{
    public class VendaNfce
    {
        [DisplayName("CONTROLE")]
        public int? CONTROLE { get; set; }

        [DisplayName("DATAEHORACADASTRO")]
        public DateTime? DATAEHORACADASTRO { get; set; }

        [DisplayName("DATAEMISSAO")]
        public DateTime? DATAEMISSAO { get; set; }

        [DisplayName("NUMERONFCCE")]
        public string NUMERONFCCE { get; set; }

        [DisplayName("NUMEROSAT")]
        public string NUMEROSAT { get; set; }

        [DisplayName("TIPOAMBIENTE")]
        public string TIPOAMBIENTE { get; set; }

        [DisplayName("CHAVENFCE")]
        public string CHAVENFCE { get; set; }

        [DisplayName("PROTOCOLO")]
        public string PROTOCOLO { get; set; }

        [DisplayName("PROTOCOLOCANCELAMENTO")]
        public string PROTOCOLOCANCELAMENTO { get; set; }

        [DisplayName("CODIGOSTATUS")]
        public int? CODIGOSTATUS { get; set; }

        [DisplayName("STATUSENVIO")]
        public string STATUSENVIO { get; set; }

        [DisplayName("INUTILIZADA")]
        public string INUTILIZADA { get; set; }

        [DisplayName("CODCLIENTE")]
        public int? CODCLIENTE { get; set; }

        [DisplayName("CLIENTE")]
        public string CLIENTE { get; set; }

        [DisplayName("CODFUNCIONARIO")]
        public int? CODFUNCIONARIO { get; set; }

        [DisplayName("FUNCIONARIO")]
        public string FUNCIONARIO { get; set; }

        [DisplayName("CODCENTROCUSTO")]
        public int? CODCENTROCUSTO { get; set; }

        [DisplayName("CENTROCUSTO")]
        public string CENTROCUSTO { get; set; }

        [DisplayName("VALORPRODUTO")]
        public decimal? VALORPRODUTO { get; set; }

        [DisplayName("PERCACRESCIMO")]
        public decimal? PERCACRESCIMO { get; set; }

        [DisplayName("VALORACRESCIMO")]
        public decimal? VALORACRESCIMO { get; set; }

        [DisplayName("PERCDESCONTO")]
        public decimal? PERCDESCONTO { get; set; }

        [DisplayName("VALORDESCONTO")]
        public decimal? VALORDESCONTO { get; set; }

        [DisplayName("VALORDESCONTOITEM")]
        public decimal? VALORDESCONTOITEM { get; set; }

        [DisplayName("VALORBCICMS")]
        public decimal? VALORBCICMS { get; set; }

        [DisplayName("VALORICMS")]
        public decimal? VALORICMS { get; set; }

        [DisplayName("VALORBCST")]
        public decimal? VALORBCST { get; set; }

        [DisplayName("VALORST")]
        public decimal? VALORST { get; set; }

        [DisplayName("VALORPIS")]
        public decimal? VALORPIS { get; set; }

        [DisplayName("VALORCOFINS")]
        public decimal? VALORCOFINS { get; set; }

        [DisplayName("VALORSEGURO")]
        public decimal? VALORSEGURO { get; set; }

        [DisplayName("VALOROUTROS")]
        public decimal? VALOROUTROS { get; set; }

        [DisplayName("VALOROUTROSITEM")]
        public decimal? VALOROUTROSITEM { get; set; }

        [DisplayName("VALORBCSERVICO")]
        public decimal? VALORBCSERVICO { get; set; }

        [DisplayName("VALORISS")]
        public decimal? VALORISS { get; set; }

        [DisplayName("VALORSERVICO")]
        public decimal? VALORSERVICO { get; set; }

        [DisplayName("VALORTOTALNFCE")]
        public decimal? VALORTOTALNFCE { get; set; }

        [DisplayName("NATUREZAOPERACAO")]
        public string NATUREZAOPERACAO { get; set; }

        [DisplayName("MODELO")]
        public string MODELO { get; set; }

        [DisplayName("SERIE")]
        public string SERIE { get; set; }

        [DisplayName("DATASAIDAENTRADA")]
        public DateTime? DATASAIDAENTRADA { get; set; }

        [DisplayName("HORASAIDAENTRADA")]
        public DateTime? HORASAIDAENTRADA { get; set; }

        [DisplayName("TIPOEMISSAO")]
        public string TIPOEMISSAO { get; set; }

        [DisplayName("FONECLIENTE")]
        public string FONECLIENTE { get; set; }

        [DisplayName("CEPCLIENTE")]
        public string CEPCLIENTE { get; set; }

        [DisplayName("ENDERECOCLIENTE")]
        public string ENDERECOCLIENTE { get; set; }

        [DisplayName("COMPLEMENTOCLIENTE")]
        public string COMPLEMENTOCLIENTE { get; set; }

        [DisplayName("UFCLIENTE")]
        public string UFCLIENTE { get; set; }

        [DisplayName("CIDADECLIENTE")]
        public string CIDADECLIENTE { get; set; }

        [DisplayName("CODCIDADEIBGECLIENTE")]
        public string CODCIDADEIBGECLIENTE { get; set; }

        [DisplayName("CPFCLIENTE")]
        public string CPFCLIENTE { get; set; }

        [DisplayName("CNPJCLIENTE")]
        public string CNPJCLIENTE { get; set; }

        [DisplayName("IMCLIENTE")]
        public string IMCLIENTE { get; set; }

        [DisplayName("CNAECLIENTE")]
        public string CNAECLIENTE { get; set; }

        [DisplayName("NUMEROCLIENTE")]
        public string NUMEROCLIENTE { get; set; }

        [DisplayName("BAIRROCLIENTE")]
        public string BAIRROCLIENTE { get; set; }

        [DisplayName("JUSTIFICATIVACANCELAMENTO")]
        public string JUSTIFICATIVACANCELAMENTO { get; set; }

        [DisplayName("DATAEHORACANCELAMENTO")]
        public DateTime? DATAEHORACANCELAMENTO { get; set; }

        [DisplayName("EMAIL")]
        public string EMAIL { get; set; }

        [DisplayName("CODCOMANDA")]
        public int? CODCOMANDA { get; set; }

        [DisplayName("CODDAV")]
        public int? CODDAV { get; set; }

        [DisplayName("CODPREVENDA")]
        public int? CODPREVENDA { get; set; }

        [DisplayName("NUMERODAV")]
        public string NUMERODAV { get; set; }

        [DisplayName("VALORTROCO")]
        public decimal? VALORTROCO { get; set; }

        [DisplayName("CODOS")]
        public int? CODOS { get; set; }

        [DisplayName("JAFATURADO")]
        public string JAFATURADO { get; set; }

        [DisplayName("SAT")]
        public string SAT { get; set; }

        [DisplayName("INFORMACAOADICIONAL")]
        public string INFORMACAOADICIONAL { get; set; }

        [DisplayName("IDENTIFICACAO")]
        public string IDENTIFICACAO { get; set; }

        [DisplayName("CODOPERADOR")]
        public int? CODOPERADOR { get; set; }

        [DisplayName("OPERADOR")]
        public string OPERADOR { get; set; }

        [DisplayName("MD5J1")]
        public string MD5J1 { get; set; }

        [DisplayName("INDICADOR")]
        public string INDICADOR { get; set; }

        [DisplayName("CHAVEANTERIORCONTINGENCIA")]
        public string CHAVEANTERIORCONTINGENCIA { get; set; }

        [DisplayName("IDPAGAMENTOVFP")]
        public string IDPAGAMENTOVFP { get; set; }

        [DisplayName("IDRESPOSTAFISCAL")]
        public string IDRESPOSTAFISCAL { get; set; }

        [DisplayName("VERIFICADO")]
        public string VERIFICADO { get; set; }

        [DisplayName("CNF")]
        public string CNF { get; set; }

        [DisplayName("STATUSCONTINGENCIA")]
        public string STATUSCONTINGENCIA { get; set; }

        [DisplayName("SINCRONIZADO")]
        public string SINCRONIZADO { get; set; }

        [DisplayName("CODNOTAMANUAL")]
        public int? CODNOTAMANUAL { get; set; }

        [DisplayName("IDESTRANGEIRO")]
        public string IDESTRANGEIRO { get; set; }
    }

    public class VendaNfceEntityTypeConfiguration : IEntityTypeConfiguration<VendaNfce>
    {
        public void Configure(EntityTypeBuilder<VendaNfce> builder)
        {
            builder.ToTable("TVENDANFCE");

            builder.HasKey(e => e.CONTROLE);

            builder.Property(e => e.CONTROLE).HasColumnName("CONTROLE");

            builder.Property(e => e.DATAEHORACADASTRO).HasColumnName("DATAEHORACADASTRO");

            builder.Property(e => e.DATAEMISSAO).HasColumnName("DATAEMISSAO");

            builder.Property(e => e.NUMERONFCCE).HasColumnName("NUMERONFCCE");

            builder.Property(e => e.NUMEROSAT).HasColumnName("NUMEROSAT");

            builder.Property(e => e.TIPOAMBIENTE).HasColumnName("TIPOAMBIENTE");

            builder.Property(e => e.CHAVENFCE).HasColumnName("CHAVENFCE");

            builder.Property(e => e.PROTOCOLO).HasColumnName("PROTOCOLO");

            builder.Property(e => e.PROTOCOLOCANCELAMENTO).HasColumnName("PROTOCOLOCANCELAMENTO");

            builder.Property(e => e.CODIGOSTATUS).HasColumnName("CODIGOSTATUS");

            builder.Property(e => e.STATUSENVIO).HasColumnName("STATUSENVIO");

            builder.Property(e => e.INUTILIZADA).HasColumnName("INUTILIZADA");

            builder.Property(e => e.CODCLIENTE).HasColumnName("CODCLIENTE");

            builder.Property(e => e.CLIENTE).HasColumnName("CLIENTE");

            builder.Property(e => e.CODFUNCIONARIO).HasColumnName("CODFUNCIONARIO");

            builder.Property(e => e.FUNCIONARIO).HasColumnName("FUNCIONARIO");

            builder.Property(e => e.CODCENTROCUSTO).HasColumnName("CODCENTROCUSTO");

            builder.Property(e => e.CENTROCUSTO).HasColumnName("CENTROCUSTO");

            builder.Property(e => e.VALORPRODUTO).HasColumnName("VALORPRODUTO");

            builder.Property(e => e.PERCACRESCIMO).HasColumnName("PERCACRESCIMO");

            builder.Property(e => e.VALORACRESCIMO).HasColumnName("VALORACRESCIMO");

            builder.Property(e => e.PERCDESCONTO).HasColumnName("PERCDESCONTO");

            builder.Property(e => e.VALORDESCONTO).HasColumnName("VALORDESCONTO");

            builder.Property(e => e.VALORDESCONTOITEM).HasColumnName("VALORDESCONTOITEM");

            builder.Property(e => e.VALORBCICMS).HasColumnName("VALORBCICMS");

            builder.Property(e => e.VALORICMS).HasColumnName("VALORICMS");

            builder.Property(e => e.VALORBCST).HasColumnName("VALORBCST");

            builder.Property(e => e.VALORST).HasColumnName("VALORST");

            builder.Property(e => e.VALORPIS).HasColumnName("VALORPIS");

            builder.Property(e => e.VALORCOFINS).HasColumnName("VALORCOFINS");

            builder.Property(e => e.VALORSEGURO).HasColumnName("VALORSEGURO");

            builder.Property(e => e.VALOROUTROS).HasColumnName("VALOROUTROS");

            builder.Property(e => e.VALOROUTROSITEM).HasColumnName("VALOROUTROSITEM");

            builder.Property(e => e.VALORBCSERVICO).HasColumnName("VALORBCSERVICO");

            builder.Property(e => e.VALORISS).HasColumnName("VALORISS");

            builder.Property(e => e.VALORSERVICO).HasColumnName("VALORSERVICO");

            builder.Property(e => e.VALORTOTALNFCE).HasColumnName("VALORTOTALNFCE");

            builder.Property(e => e.NATUREZAOPERACAO).HasColumnName("NATUREZAOPERACAO");

            builder.Property(e => e.MODELO).HasColumnName("MODELO");

            builder.Property(e => e.SERIE).HasColumnName("SERIE");

            builder.Property(e => e.DATASAIDAENTRADA).HasColumnName("DATASAIDAENTRADA");

            builder.Property(e => e.HORASAIDAENTRADA).HasColumnName("HORASAIDAENTRADA");

            builder.Property(e => e.TIPOEMISSAO).HasColumnName("TIPOEMISSAO");

            builder.Property(e => e.FONECLIENTE).HasColumnName("FONECLIENTE");

            builder.Property(e => e.CEPCLIENTE).HasColumnName("CEPCLIENTE");

            builder.Property(e => e.ENDERECOCLIENTE).HasColumnName("ENDERECOCLIENTE");

            builder.Property(e => e.COMPLEMENTOCLIENTE).HasColumnName("COMPLEMENTOCLIENTE");

            builder.Property(e => e.UFCLIENTE).HasColumnName("UFCLIENTE");

            builder.Property(e => e.CIDADECLIENTE).HasColumnName("CIDADECLIENTE");

            builder.Property(e => e.CODCIDADEIBGECLIENTE).HasColumnName("CODCIDADEIBGECLIENTE");

            builder.Property(e => e.CPFCLIENTE).HasColumnName("CPFCLIENTE");

            builder.Property(e => e.CNPJCLIENTE).HasColumnName("CNPJCLIENTE");

            builder.Property(e => e.IMCLIENTE).HasColumnName("IMCLIENTE");

            builder.Property(e => e.CNAECLIENTE).HasColumnName("CNAECLIENTE");

            builder.Property(e => e.NUMEROCLIENTE).HasColumnName("NUMEROCLIENTE");

            builder.Property(e => e.BAIRROCLIENTE).HasColumnName("BAIRROCLIENTE");

            builder.Property(e => e.JUSTIFICATIVACANCELAMENTO).HasColumnName("JUSTIFICATIVACANCELAMENTO");

            builder.Property(e => e.DATAEHORACANCELAMENTO).HasColumnName("DATAEHORACANCELAMENTO");

            builder.Property(e => e.EMAIL).HasColumnName("EMAIL");

            builder.Property(e => e.CODCOMANDA).HasColumnName("CODCOMANDA");

            builder.Property(e => e.CODDAV).HasColumnName("CODDAV");

            builder.Property(e => e.CODPREVENDA).HasColumnName("CODPREVENDA");

            builder.Property(e => e.NUMERODAV).HasColumnName("NUMERODAV");

            builder.Property(e => e.VALORTROCO).HasColumnName("VALORTROCO");

            builder.Property(e => e.CODOS).HasColumnName("CODOS");

            builder.Property(e => e.JAFATURADO).HasColumnName("JAFATURADO");

            builder.Property(e => e.SAT).HasColumnName("SAT");

            builder.Property(e => e.INFORMACAOADICIONAL).HasColumnName("INFORMACAOADICIONAL");

            builder.Property(e => e.IDENTIFICACAO).HasColumnName("IDENTIFICACAO");

            builder.Property(e => e.CODOPERADOR).HasColumnName("CODOPERADOR");

            builder.Property(e => e.OPERADOR).HasColumnName("OPERADOR");

            builder.Property(e => e.MD5J1).HasColumnName("MD5J1");

            builder.Property(e => e.INDICADOR).HasColumnName("INDICADOR");

            builder.Property(e => e.CHAVEANTERIORCONTINGENCIA).HasColumnName("CHAVEANTERIORCONTINGENCIA");

            builder.Property(e => e.IDPAGAMENTOVFP).HasColumnName("IDPAGAMENTOVFP");

            builder.Property(e => e.IDRESPOSTAFISCAL).HasColumnName("IDRESPOSTAFISCAL");

            builder.Property(e => e.VERIFICADO).HasColumnName("VERIFICADO");

            builder.Property(e => e.CNF).HasColumnName("CNF");

            builder.Property(e => e.STATUSCONTINGENCIA).HasColumnName("STATUSCONTINGENCIA");

            builder.Property(e => e.SINCRONIZADO).HasColumnName("SINCRONIZADO");

            builder.Property(e => e.CODNOTAMANUAL).HasColumnName("CODNOTAMANUAL");

            builder.Property(e => e.IDESTRANGEIRO).HasColumnName("IDESTRANGEIRO");
        }
    }
}
