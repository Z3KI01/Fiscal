using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiscal
{
    public partial class Fiscal : Form
    {
        // Muda a cor da barra superior do fiscal
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwn, int attr, int[] attrValue, int attriSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
            {
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
            }
        }

        //Arredonda os botões
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidhtEllipse,
                int nHeightEllipse
            );
        public Fiscal()
        {
            InitializeComponent();
        }
        //Arrendonda os botões
        private void Fiscal_Load(object sender, EventArgs e)
        {
            btnSintegra.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSintegra.Width, btnSintegra.Height, 7, 7));
            btnSped.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSped.Width, btnSped.Height, 7, 7));
            btnSpedCont.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSpedCont.Width, btnSpedCont.Height, 7, 7));
            btnLivro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLivro.Width, btnLivro.Height, 7, 7));
            BtnConfiguracoes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnConfiguracoes.Width, BtnConfiguracoes.Height, 7, 7));
            BtnContabilista.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnContabilista.Width, BtnContabilista.Height, 7, 7));
            BtnSair.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnSair.Width, BtnSair.Height, 7, 7));
        }
        private void BtnContabilista_Click(object sender, EventArgs e)
        {
            dadosContabilista dadosContabilista = new dadosContabilista();

            dadosContabilista.ShowDialog();
        }

        private void BtnSintegra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Está funcionalidade se encontra em desenvolvimento...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSpedCont_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Está funcionalidade se encontra em desenvolvimento...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnLivro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Está funcionalidade se encontra em desenvolvimento...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BtnConfiguracoes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Está funcionalidade se encontra em desenvolvimento...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSped_Click(object sender, EventArgs e)
        {
            SpedInfo spedinfo = new SpedInfo();
            spedinfo.ShowDialog();
        }
        private void btnSintegra_MouseEnter(object sender, EventArgs e)
        {
            btnSintegra.BackgroundImage = Properties.Resources.sintegraE;
        }

        private void btnSintegra_MouseLeave(object sender, EventArgs e)
        {
            btnSintegra.BackgroundImage = Properties.Resources.sintegraC;
        }

        private void btnSped_MouseEnter(object sender, EventArgs e)
        {
            btnSped.BackgroundImage = Properties.Resources.spedE;
        }

        private void btnSped_MouseLeave(object sender, EventArgs e)
        {
            btnSped.BackgroundImage = Properties.Resources.spedC;
        }

        private void btnSpedCont_MouseEnter(object sender, EventArgs e)
        {
            btnSpedCont.BackgroundImage = Properties.Resources.sped_contribuicoesE;
        }

        private void btnSpedCont_MouseLeave(object sender, EventArgs e)
        {
            btnSpedCont.BackgroundImage = Properties.Resources.sped_contribuicoesC;
        }

        private void btnLivro_MouseEnter(object sender, EventArgs e)
        {
            btnLivro.BackgroundImage = Properties.Resources.lcdprE;
        }

        private void btnLivro_MouseLeave(object sender, EventArgs e)
        {
            btnLivro.BackgroundImage = Properties.Resources.lcdprE;
        }
    }
}

