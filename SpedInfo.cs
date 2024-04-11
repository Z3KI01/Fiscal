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
    public partial class SpedInfo : Form
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

        public SpedInfo()
        {
            InitializeComponent();

            dataInicioSped.ValueChanged += dataInicioSped_ValueChanged;
            InicializardataFimSped();

        }

        private void btnGravarDC_Click(object sender, EventArgs e)
        {
            Registro0000 registro0000 = new Registro0000();
            registro0000.spedinfo = this;

            DateTime dataInicio = dataInicioSped.Value;
            DateTime dataFim = dataFimSped.Value;
            
            registro0000.spedBlocos(dataInicio, dataFim);
        }
        private void dataInicioSped_ValueChanged(object sender, EventArgs e)
        {
            InicializardataFimSped();
        }

        private void InicializardataFimSped()
        {
            DateTime selectedDate = dataInicioSped.Value;

            DateTime lastDayOfMonth = new DateTime(selectedDate.Year, selectedDate.Month, DateTime.DaysInMonth(selectedDate.Year, selectedDate.Month));

            dataFimSped.Value = lastDayOfMonth;
        }

        private void SpedInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
