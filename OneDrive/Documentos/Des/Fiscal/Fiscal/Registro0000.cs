using Fiscal.Classe;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Fiscal
{
    public class Registro0000
    {
        public SpedInfo spedinfo;

        public void spedBlocos(DateTime dataInicio, DateTime dataFim)
        {
            using (var context = new ConexaoBD.SgTable())
            {
                IQueryable<Emitente> emit = context.emitente;
                IQueryable<dadostContabilista> contabilista = context.contabilista;
                IQueryable<Fornecedores> fornecedores = context.fornecedor;
                IQueryable<Estoque> estoque = context.produto;
                IQueryable<VendaNfe> vendaNFe = context.vendaNfe;
                IQueryable<Cliente> clientes = context.clientes;

                IQueryable<Compra> compras = context.compra.Where(compra => compra.DATARECEBIMENTO >= dataInicio && compra.DATARECEBIMENTO <= dataFim).Distinct();

                var DadosVendaNFce = context.vendaNfce.Where(vendaNfce => vendaNfce.DATAEMISSAO >= dataInicio && vendaNfce.DATAEMISSAO <= dataFim).Distinct();

                var DadosVendaNF = context.vendaNfe.Where(vendnfe => vendnfe.DataEmissao >= dataInicio && vendnfe.DataEmissao <= dataFim).Distinct();

                var DadosEmit = emit.AsQueryable().First();
                var DadosCont = contabilista.AsQueryable().First();

                //Remove a mascara do CNPJ e do telefone
                string CNPJSemMascara = DadosEmit.CNPJ.Replace(".", "").Replace("/", "").Replace("-", "");
                string TelefoneSemMascara = DadosEmit.TELEFONE.Replace("(", "").Replace(")", "").Replace(" ", "");

                string Registro0000 = "";

                // Registro 0000
                Registro0000 += "|0000|" + spedinfo.txtLayout.Text + "|" + "0|" + "01012000|" + "01012030|" + DadosEmit.RAZAOSOCIAL + "|";
                Registro0000 += CNPJSemMascara + "|" + DadosEmit.CPF + "|" + DadosEmit.UF + "|" + DadosEmit.IE + "|";
                Registro0000 += DadosEmit.CODCIDADEIBGE + "|" + DadosEmit.IM + "|" + DadosEmit.SUFRAMA + "|";

                // Verifica RdButton Perfis (A, B e C)
                if (spedinfo.rdPerfilA.Checked)
                {
                    Registro0000 += "A|";
                }
                else if (spedinfo.rdPerfilB.Checked)
                {
                    Registro0000 += "B|";
                }
                else if (spedinfo.rdPerfilC.Checked)
                {
                    Registro0000 += "C|";
                }

                // Verificar RdButton Atividade
                if (spedinfo.rdOutros.Checked)
                {
                    Registro0000 += "0|\n";
                }
                else if (spedinfo.rdIndustria.Checked)
                {
                    Registro0000 += "1|\n";
                }

                Registro0000 += "|0001|0|\n";

                // Registro 0005
                Registro0000 += "|0005|" + DadosEmit.NOMEFANTASIA + "|" + DadosEmit.CEP + "|" + DadosEmit.ENDERECO + "|";
                Registro0000 += DadosEmit.NUMERO + "|" + DadosEmit.COMPLEMENTO + "|" + DadosEmit.BAIRRO + "|";
                Registro0000 += TelefoneSemMascara + "|" + DadosEmit.FAX + "|" + DadosEmit.EMAIL + "|\n";

                // Registro 0100
                Registro0000 += "|0100|" + DadosCont.NOME + "|" + DadosCont.CPF + "|" + DadosCont.CRC + "|" + DadosCont.CNPJ;
                Registro0000 += DadosCont.CEP + "|" + DadosCont.ENDERECO + "|" + DadosCont.NUMERO + "|" + DadosCont.COMPLEMENTO;
                Registro0000 += DadosCont.BAIRRO + "|" + DadosCont.TELEFONE + "|" + DadosCont.FAX + "|" + DadosCont.EMAIL + "|" + DadosCont.CODMUNCIPIO + "|\n";

                // Conjunto para armazenar registros já escritos
                HashSet<string> registrosEscritos = new HashSet<string>();

                // Registro 0150 fornecedores
                var comprasFornecedores = compras.Join(fornecedores, compra => compra.CODFORNECEDOR, fornecedor => fornecedor.CONTROLE, (compra, fornecedor) => new
                {
                    compra.DATAEMISSAO,
                    fornecedor.CONTROLE,
                    fornecedor.RAZAOSOCIAL,
                    fornecedor.CODIGOPAIS,
                    fornecedor.CNPJ,
                    fornecedor.CPF,
                    fornecedor.IE,
                    fornecedor.CODIGOCIDADEIBGE,
                    fornecedor.SUFRAMA,
                    fornecedor.ENDERECO,
                    fornecedor.NUMERO,
                    fornecedor.COMPLEMENTO,
                    fornecedor.BAIRRO,
                    compra.CONFIRMADA
                });

                foreach (var forn in comprasFornecedores)
                {
                    string registro = "|0150|" + forn.CONTROLE + "|" + forn.RAZAOSOCIAL + "|" + forn.CODIGOPAIS + "|" + forn.CNPJ + "|" + forn.IE + "|" + forn.CODIGOCIDADEIBGE + "|" + forn.ENDERECO + "|" + forn.NUMERO + "|"
                        + forn.COMPLEMENTO + "|" + forn.BAIRRO + "|\n";

                    // Verifica se o registro já foi escrito
                    if (!registrosEscritos.Contains(registro))
                    {
                        Registro0000 += registro;
                        registrosEscritos.Add(registro);
                    }
                }

                var SelectClieNF = DadosVendaNF.Join(clientes, dadosVendaNF => dadosVendaNF.CodCliente, cliente => cliente.CONTROLE, (dadosVendaNF, cliente) => new
                {
                    dadosVendaNF.DataEmissao,
                    cliente.CONTROLE,
                    cliente.CLIENTE,
                    cliente.CODIGOPAIS,
                    cliente.CNPJ,
                    cliente.CPF,
                    cliente.IE,
                    cliente.CODIGOCIDADEIBGE,
                    cliente.SUFRAMA,
                    cliente.ENDERECO,
                    cliente.NUMERO,
                    cliente.COMPLEMENTO,
                    cliente.BAIRRO,
                    dadosVendaNF.StatusEnvio
                });

                foreach (var vendanf in DadosVendaNF)
                {
                    var cliente = context.clientes.Where(c => c.CONTROLE == vendanf.CodCliente).FirstOrDefault();
                    if (cliente != null && cliente.CNPJ != null)
                    {
                        string registro0150 = "|0150|" + cliente.CONTROLE + "|" + cliente.CLIENTE + "|";
                        registro0150 += cliente.CODIGOPAIS + "|" + cliente.CNPJ + "|" + cliente.IE + "|";
                        registro0150 += cliente.CODIGOCIDADEIBGE + "|" + cliente.ENDERECO + "|" + cliente.NUMERO + "|";
                        registro0150 += cliente.COMPLEMENTO + "|" + cliente.BAIRRO + "|\n";

                        // Verifica se o registro já foi escrito
                        if (!registrosEscritos.Contains(registro0150))
                        {
                            Registro0000 += registro0150;
                            registrosEscritos.Add(registro0150);
                        }
                    }
                }

                var selectNfce = DadosVendaNFce.Join(clientes, vendaNfce => vendaNfce.CODCLIENTE, Cliente => Cliente.CONTROLE, (vendaNfce, Cliente) => new
                {
                    vendaNfce.CONTROLE,
                    Cliente.CLIENTE,
                    Cliente.CODIGOPAIS,
                    Cliente.CNPJ,
                    Cliente.CPF,
                    Cliente.IE,
                    Cliente.CODIGOCIDADEIBGE,
                    Cliente.SUFRAMA,
                    Cliente.ENDERECO,
                    Cliente.NUMERO,
                    Cliente.COMPLEMENTO,
                    Cliente.BAIRRO,
                    vendaNfce.STATUSENVIO
                });

                foreach (var vendanfc in DadosVendaNFce)
                {
                    var cliente = context.clientes.Where(c => c.CONTROLE == vendanfc.CODCLIENTE).FirstOrDefault();
                    if (cliente != null && cliente.CNPJ != null)
                    {
                        string registro0150 = "|0150|" + cliente.CONTROLE + "|" + cliente.CLIENTE;
                        registro0150 += "|" + cliente.CODIGOPAIS + "|" + cliente.CNPJ + "|" + cliente.IE + "|";
                        registro0150 += cliente.CODIGOCIDADEIBGE + "|" + cliente.ENDERECO + "|" + cliente.NUMERO + "|";
                        registro0150 += cliente.COMPLEMENTO + "|" + cliente.BAIRRO + "|\n";

                        // Verifica se o registro já foi escrito
                        if (!registrosEscritos.Contains(registro0150))
                        {
                            Registro0000 += registro0150;
                            registrosEscritos.Add(registro0150);
                        }
                    }
                }

                // Registro 0200
                foreach (var DadosEstoque in estoque)
                {
                    string registro = "|0200|" + DadosEstoque.Controle + "|" + DadosEstoque.Produto + "|" + DadosEstoque.CodBarras + "||" + DadosEstoque.Unidade + "|";
                    registro += DadosEstoque.CodAplicacaoProduto + "|" + DadosEstoque.NCM + "||" + "||" + "||" + DadosEstoque.AliquotaIcmsEcf + "|" + DadosEstoque.Cest + "|\n";

                    // Verifica se o registro já foi escrito
                    if (!registrosEscritos.Contains(registro))
                    {
                        Registro0000 += registro;
                        registrosEscritos.Add(registro);
                    }
                }

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "(*.txt)|.txt";
                saveFileDialog1.Title = "Geração de Sped";
                saveFileDialog1.FileName = "SPED " + dataInicio.ToString("MM-yyyy"); // Adicionando o mês e ano ao nome do arquivo
                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string caminhoArquivo = saveFileDialog1.FileName;
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(caminhoArquivo))
                        {
                            sw.Write(Registro0000);
                        }

                        MessageBox.Show("Geração de Sped concluída!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        spedinfo.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao gerar o arquivo SPED:" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
