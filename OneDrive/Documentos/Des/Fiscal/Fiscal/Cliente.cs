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
    public class Cliente
    {
        [DisplayName("CONTROLE")]
        public int? CONTROLE { get; set; }

        [DisplayName("CLIENTE")]
        public string CLIENTE { get; set; }

        [DisplayName("ENDERECO")]
        public string ENDERECO { get; set; }

        [DisplayName("COMPLEMENTO")]
        public string COMPLEMENTO { get; set; }

        [DisplayName("BAIRRO")]
        public string BAIRRO { get; set; }

        [DisplayName("CODCIDADE")]
        public int? CODCIDADE { get; set; }

        [DisplayName("CIDADE")]
        public string CIDADE { get; set; }

        [DisplayName("UF")]
        public string UF { get; set; }

        [DisplayName("PAIS")]
        public string PAIS { get; set; }

        [DisplayName("CEP")]
        public string CEP { get; set; }

        [DisplayName("NATURALIDADE")]
        public string NATURALIDADE { get; set; }

        [DisplayName("TIPOCLIENTE")]
        public string TIPOCLIENTE { get; set; }

        [DisplayName("RG")]
        public string RG { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }

        [DisplayName("IE")]
        public string IE { get; set; }

        [DisplayName("IM")]
        public string IM { get; set; }

        [DisplayName("DATANASCIMENTO")]
        public DateTime? DATANASCIMENTO { get; set; }

        [DisplayName("DATAHORACADASTRO")]
        public DateTime? DATAHORACADASTRO { get; set; }

        [DisplayName("PAI")]
        public string PAI { get; set; }

        [DisplayName("MAE")]
        public string MAE { get; set; }

        [DisplayName("TELEFONE")]
        public string TELEFONE { get; set; }

        [DisplayName("CELULAR")]
        public string CELULAR { get; set; }

        [DisplayName("EMAIL")]
        public string EMAIL { get; set; }

        [DisplayName("ESTADOCIVIL")]
        public string ESTADOCIVIL { get; set; }

        [DisplayName("ATIVO")]
        public string ATIVO { get; set; }

        [DisplayName("FANTASIA")]
        public string FANTASIA { get; set; }

        [DisplayName("LIMITECREDITO")]
        public decimal? LIMITECREDITO { get; set; }

        [DisplayName("NOMECONJUGE")]
        public string NOMECONJUGE { get; set; }

        [DisplayName("DATAULTIMAVENDA")]
        public DateTime? DATAULTIMAVENDA { get; set; }

        [DisplayName("DIASSEMCOMPRAR")]
        public int? DIASSEMCOMPRAR { get; set; }

        [DisplayName("CODCONVENIO")]
        public int? CODCONVENIO { get; set; }

        [DisplayName("CONVENIO")]
        public string CONVENIO { get; set; }

        [DisplayName("PROFISSAO")]
        public string PROFISSAO { get; set; }

        [DisplayName("EMPRESAQUETRABALHA")]
        public string EMPRESAQUETRABALHA { get; set; }

        [DisplayName("FONETRABALHO")]
        public string FONETRABALHO { get; set; }

        [DisplayName("RENDAMENSAL")]
        public decimal? RENDAMENSAL { get; set; }

        [DisplayName("TOTALVENDIDO")]
        public decimal? TOTALVENDIDO { get; set; }

        [DisplayName("NACIONALIDADE")]
        public string NACIONALIDADE { get; set; }

        [DisplayName("NUMERO")]
        public string NUMERO { get; set; }

        [DisplayName("CODCONSULTASPC")]
        public int? CODCONSULTASPC { get; set; }

        [DisplayName("SEXO")]
        public string SEXO { get; set; }

        [DisplayName("CODIGOCIDADEIBGE")]
        public int? CODIGOCIDADEIBGE { get; set; }

        [DisplayName("CODEMITENTE")]
        public int? CODEMITENTE { get; set; }

        [DisplayName("NOMECONTATOJURIDICA")]
        public string NOMECONTATOJURIDICA { get; set; }

        [DisplayName("EMAIL2")]
        public string EMAIL2 { get; set; }

        [DisplayName("STATUS")]
        public string STATUS { get; set; }

        [DisplayName("MD5L")]
        public string MD5L { get; set; }

        [DisplayName("SERIAL")]
        public string SERIAL { get; set; }

        [DisplayName("CODGRUPO")]
        public int? CODGRUPO { get; set; }

        [DisplayName("GRUPO")]
        public string GRUPO { get; set; }

        [DisplayName("TRIBUTACAO")]
        public string TRIBUTACAO { get; set; }

        [DisplayName("CAMPO1")]
        public string CAMPO1 { get; set; }

        [DisplayName("CAMPO2")]
        public string CAMPO2 { get; set; }

        [DisplayName("CAMPO3")]
        public string CAMPO3 { get; set; }

        [DisplayName("CAMPO4")]
        public string CAMPO4 { get; set; }

        [DisplayName("CAMPO5")]
        public string CAMPO5 { get; set; }

        [DisplayName("CAMPO6")]
        public string CAMPO6 { get; set; }

        [DisplayName("CAMPO7")]
        public string CAMPO7 { get; set; }

        [DisplayName("CAMPO8")]
        public string CAMPO8 { get; set; }

        [DisplayName("CAMPO9")]
        public string CAMPO9 { get; set; }

        [DisplayName("CAMPO10")]
        public string CAMPO10 { get; set; }

        [DisplayName("ISSMUNICIPIO")]
        public string ISSMUNICIPIO { get; set; }

        [DisplayName("SITE")]
        public string SITE { get; set; }

        [DisplayName("CODIGOPAIS")]
        public int? CODIGOPAIS { get; set; }

        [DisplayName("CSOSN")]
        public string CSOSN { get; set; }

        [DisplayName("PERCICMSPROPRIOST")]
        public decimal? PERCICMSPROPRIOST { get; set; }

        [DisplayName("PERCMVAORIGINAL")]
        public decimal? PERCMVAORIGINAL { get; set; }

        [DisplayName("PERCICMSSTINTERNA")]
        public decimal? PERCICMSSTINTERNA { get; set; }

        [DisplayName("PERCREDUCAOBCST")]
        public decimal? PERCREDUCAOBCST { get; set; }

        [DisplayName("DESCRICAOCSOSN")]
        public string DESCRICAOCSOSN { get; set; }

        [DisplayName("CODIGOCSTORIGEM")]
        public string CODIGOCSTORIGEM { get; set; }

        [DisplayName("ORIGEM")]
        public string ORIGEM { get; set; }

        [DisplayName("POSSUIICMSST")]
        public string POSSUIICMSST { get; set; }

        [DisplayName("ISENTO")]
        public string ISENTO { get; set; }

        [DisplayName("TRIBUTADO")]
        public string TRIBUTADO { get; set; }

        [DisplayName("MENSAGEMFISCAL")]
        public string MENSAGEMFISCAL { get; set; }

        [DisplayName("CODTABELAPRECO")]
        public int? CODTABELAPRECO { get; set; }

        [DisplayName("TABELAPRECO")]
        public string TABELAPRECO { get; set; }

        [DisplayName("CODVENDEDOR")]
        public int? CODVENDEDOR { get; set; }

        [DisplayName("VENDEDOR")]
        public string VENDEDOR { get; set; }

        [DisplayName("CODPARCELAPREDEFINIDA")]
        public int? CODPARCELAPREDEFINIDA { get; set; }

        [DisplayName("PARCELAPREDEFINIDA")]
        public string PARCELAPREDEFINIDA { get; set; }

        [DisplayName("CODTRANSPORTADORA")]
        public int? CODTRANSPORTADORA { get; set; }

        [DisplayName("TRANSPORTADORA")]
        public string TRANSPORTADORA { get; set; }

        [DisplayName("VALORFRETE")]
        public decimal? VALORFRETE { get; set; }

        [DisplayName("MD5O")]
        public string MD5O { get; set; }

        [DisplayName("SUFRAMA")]
        public string SUFRAMA { get; set; }

        [DisplayName("PERCFCP")]
        public decimal? PERCFCP { get; set; }

        [DisplayName("PERCREDUCAOBC")]
        public decimal? PERCREDUCAOBC { get; set; }

        [DisplayName("CSTCSOSNAPLICAR")]
        public string CSTCSOSNAPLICAR { get; set; }

        [DisplayName("SINCRONIZADO")]
        public string SINCRONIZADO { get; set; }

        [DisplayName("UTILIZARCASHBACK")]
        public string UTILIZARCASHBACK { get; set; }
    }
    public class ClienteEntityTypeConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("TCLIENTE");

            builder.HasKey(e => e.CONTROLE);

            builder.Property(e => e.CONTROLE).HasColumnName("CONTROLE");

            builder.Property(e => e.CLIENTE).HasColumnName("CLIENTE");

            builder.Property(e => e.ENDERECO).HasColumnName("ENDERECO");

            builder.Property(e => e.COMPLEMENTO).HasColumnName("COMPLEMENTO");

            builder.Property(e => e.BAIRRO).HasColumnName("BAIRRO");

            builder.Property(e => e.CODCIDADE).HasColumnName("CODCIDADE");

            builder.Property(e => e.CIDADE).HasColumnName("CIDADE");

            builder.Property(e => e.UF).HasColumnName("UF");

            builder.Property(e => e.PAIS).HasColumnName("PAIS");

            builder.Property(e => e.CEP).HasColumnName("CEP");

            builder.Property(e => e.NATURALIDADE).HasColumnName("NATURALIDADE");

            builder.Property(e => e.TIPOCLIENTE).HasColumnName("TIPOCLIENTE");

            builder.Property(e => e.RG).HasColumnName("RG");

            builder.Property(e => e.CPF).HasColumnName("CPF");

            builder.Property(e => e.CNPJ).HasColumnName("CNPJ");

            builder.Property(e => e.IE).HasColumnName("IE");

            builder.Property(e => e.IM).HasColumnName("IM");

            builder.Property(e => e.DATANASCIMENTO).HasColumnName("DATANASCIMENTO");

            builder.Property(e => e.DATAHORACADASTRO).HasColumnName("DATAHORACADASTRO");

            builder.Property(e => e.PAI).HasColumnName("PAI");

            builder.Property(e => e.MAE).HasColumnName("MAE");

            builder.Property(e => e.TELEFONE).HasColumnName("TELEFONE");

            builder.Property(e => e.CELULAR).HasColumnName("CELULAR");

            builder.Property(e => e.EMAIL).HasColumnName("EMAIL");

            builder.Property(e => e.ESTADOCIVIL).HasColumnName("ESTADOCIVIL");

            builder.Property(e => e.ATIVO).HasColumnName("ATIVO");

            builder.Property(e => e.FANTASIA).HasColumnName("FANTASIA");

            builder.Property(e => e.LIMITECREDITO).HasColumnName("LIMITECREDITO");

            builder.Property(e => e.NOMECONJUGE).HasColumnName("NOMECONJUGE");

            builder.Property(e => e.DATAULTIMAVENDA).HasColumnName("DATAULTIMAVENDA");

            builder.Property(e => e.DIASSEMCOMPRAR).HasColumnName("DIASSEMCOMPRAR");

            builder.Property(e => e.CODCONVENIO).HasColumnName("CODCONVENIO");

            builder.Property(e => e.CONVENIO).HasColumnName("CONVENIO");

            builder.Property(e => e.PROFISSAO).HasColumnName("PROFISSAO");

            builder.Property(e => e.EMPRESAQUETRABALHA).HasColumnName("EMPRESAQUETRABALHA");

            builder.Property(e => e.FONETRABALHO).HasColumnName("FONETRABALHO");

            builder.Property(e => e.RENDAMENSAL).HasColumnName("RENDAMENSAL");

            builder.Property(e => e.TOTALVENDIDO).HasColumnName("TOTALVENDIDO");

            builder.Property(e => e.NACIONALIDADE).HasColumnName("NACIONALIDADE");

            builder.Property(e => e.NUMERO).HasColumnName("NUMERO");

            builder.Property(e => e.CODCONSULTASPC).HasColumnName("CODCONSULTASPC");

            builder.Property(e => e.SEXO).HasColumnName("SEXO");

            builder.Property(e => e.CODIGOCIDADEIBGE).HasColumnName("CODIGOCIDADEIBGE");

            builder.Property(e => e.CODEMITENTE).HasColumnName("CODEMITENTE");

            builder.Property(e => e.NOMECONTATOJURIDICA).HasColumnName("NOMECONTATOJURIDICA");

            builder.Property(e => e.EMAIL2).HasColumnName("EMAIL2");

            builder.Property(e => e.STATUS).HasColumnName("STATUS");

            builder.Property(e => e.MD5L).HasColumnName("MD5L");

            builder.Property(e => e.SERIAL).HasColumnName("SERIAL");

            builder.Property(e => e.CODGRUPO).HasColumnName("CODGRUPO");

            builder.Property(e => e.GRUPO).HasColumnName("GRUPO");

            builder.Property(e => e.TRIBUTACAO).HasColumnName("TRIBUTACAO");

            builder.Property(e => e.CAMPO1).HasColumnName("CAMPO1");

            builder.Property(e => e.CAMPO2).HasColumnName("CAMPO2");

            builder.Property(e => e.CAMPO3).HasColumnName("CAMPO3");

            builder.Property(e => e.CAMPO4).HasColumnName("CAMPO4");

            builder.Property(e => e.CAMPO5).HasColumnName("CAMPO5");

            builder.Property(e => e.CAMPO6).HasColumnName("CAMPO6");

            builder.Property(e => e.CAMPO7).HasColumnName("CAMPO7");

            builder.Property(e => e.CAMPO8).HasColumnName("CAMPO8");

            builder.Property(e => e.CAMPO9).HasColumnName("CAMPO9");

            builder.Property(e => e.CAMPO10).HasColumnName("CAMPO10");

            builder.Property(e => e.ISSMUNICIPIO).HasColumnName("ISSMUNICIPIO");

            builder.Property(e => e.SITE).HasColumnName("SITE");

            builder.Property(e => e.CODIGOPAIS).HasColumnName("CODIGOPAIS");

            builder.Property(e => e.CSOSN).HasColumnName("CSOSN");

            builder.Property(e => e.PERCICMSPROPRIOST).HasColumnName("PERCICMSPROPRIOST");

            builder.Property(e => e.PERCMVAORIGINAL).HasColumnName("PERCMVAORIGINAL");

            builder.Property(e => e.PERCICMSSTINTERNA).HasColumnName("PERCICMSSTINTERNA");

            builder.Property(e => e.PERCREDUCAOBCST).HasColumnName("PERCREDUCAOBCST");

            builder.Property(e => e.DESCRICAOCSOSN).HasColumnName("DESCRICAOCSOSN");

            builder.Property(e => e.CODIGOCSTORIGEM).HasColumnName("CODIGOCSTORIGEM");

            builder.Property(e => e.ORIGEM).HasColumnName("ORIGEM");

            builder.Property(e => e.POSSUIICMSST).HasColumnName("POSSUIICMSST");

            builder.Property(e => e.ISENTO).HasColumnName("ISENTO");

            builder.Property(e => e.TRIBUTADO).HasColumnName("TRIBUTADO");

            builder.Property(e => e.MENSAGEMFISCAL).HasColumnName("MENSAGEMFISCAL");

            builder.Property(e => e.CODTABELAPRECO).HasColumnName("CODTABELAPRECO");

            builder.Property(e => e.TABELAPRECO).HasColumnName("TABELAPRECO");

            builder.Property(e => e.CODVENDEDOR).HasColumnName("CODVENDEDOR");

            builder.Property(e => e.VENDEDOR).HasColumnName("VENDEDOR");

            builder.Property(e => e.CODPARCELAPREDEFINIDA).HasColumnName("CODPARCELAPREDEFINIDA");

            builder.Property(e => e.PARCELAPREDEFINIDA).HasColumnName("PARCELAPREDEFINIDA");

            builder.Property(e => e.CODTRANSPORTADORA).HasColumnName("CODTRANSPORTADORA");

            builder.Property(e => e.TRANSPORTADORA).HasColumnName("TRANSPORTADORA");

            builder.Property(e => e.VALORFRETE).HasColumnName("VALORFRETE");

            builder.Property(e => e.MD5O).HasColumnName("MD5O");

            builder.Property(e => e.SUFRAMA).HasColumnName("SUFRAMA");

            builder.Property(e => e.PERCFCP).HasColumnName("PERCFCP");

            builder.Property(e => e.PERCREDUCAOBC).HasColumnName("PERCREDUCAOBC");

            builder.Property(e => e.CSTCSOSNAPLICAR).HasColumnName("CSTCSOSNAPLICAR");

            builder.Property(e => e.SINCRONIZADO).HasColumnName("SINCRONIZADO");

            builder.Property(e => e.UTILIZARCASHBACK).HasColumnName("UTILIZARCASHBACK");
        }
    }
}
