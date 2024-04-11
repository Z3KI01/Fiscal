using Fiscal.Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiscal
{
    public partial class dadosContabilista : Form
    {
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwn, int attr, int[] attrValue, int attriSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
            {
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
            }
        }
        public dadosContabilista()
        {
            InitializeComponent();
        }

        private void dadosContabilista_Load(object sender, EventArgs e)
        {
            using ( var dc = new ConexaoBD.SgTable())
            {
                var dados = dc.contabilista.FirstOrDefault();

                txtContador.Text = dados.NOME;
                txtCNPJDC.Text = dados.CNPJ;
                txtCRC.Text = dados.CRC;
                txtCPFDC.Text = dados.CPF;
                txtCEPCD.Text = dados.CEP;
                txtEnderecoDC.Text = dados.ENDERECO;
                txtNumeroDC.Text = dados.NUMERO;
                txtComplementoDC.Text = dados.COMPLEMENTO;
                txtBairroDC.Text = dados.BAIRRO;
                txtTelefoneDC.Text = dados.TELEFONE;
                txtFaxDC.Text = dados.FAX;
                txtEmailDC.Text = dados.EMAIL;
                txtCodMunIBGEDC.Text = dados.CODMUNCIPIO.ToString();
                txtCodContaAnalitica.Text = dados.CODCONTAANALITICA.ToString();
            }
        }

        private void btnGravarDC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
