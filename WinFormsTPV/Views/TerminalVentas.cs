using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsTPV.Models;

namespace WinFormsTPV.Views
{
    public partial class TerminalVentas : Form
    {
        System.Windows.Forms.Timer timerFechaHora;

        public TerminalVentas(Usuario usuario)
        {
            InitializeComponent();
            timerFechaHora = new System.Windows.Forms.Timer();
            timerFechaHora.Interval = 1000;
            timerFechaHora.Tick += TimerFechaHora_Tick;
            timerFechaHora.Start();
            btnUsuario.Text = usuario.Alias;
            if (usuario.EsAdmin)
            {
                btnAdministrar.Visible = true;
            }
            else
            {
                tlpAdmin.SetColumnSpan(btnFecha, 2);
            }
        }

        private void TimerFechaHora_Tick(object? sender, EventArgs e)
        {
            btnFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
