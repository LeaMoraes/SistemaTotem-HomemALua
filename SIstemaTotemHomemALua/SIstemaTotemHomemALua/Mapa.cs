using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIstemaTotemHomemALua
{
    public partial class Mapa : Form
    {
        public Mapa()
        {
            InitializeComponent();
        }

        private void pbxBotaoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrTempoAusencia_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ResetTimer()
        {
            tmrTempoAusencia.Enabled = false;
            tmrTempoAusencia.Enabled = true;
        }

        private void pcbMapa_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void Mapa_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

    }
}
