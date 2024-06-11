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
    public partial class Agradecimento : Form
    {
        public Agradecimento()
        {
            InitializeComponent();
        }

        private void Agradecimento_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrFecharJanela_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
