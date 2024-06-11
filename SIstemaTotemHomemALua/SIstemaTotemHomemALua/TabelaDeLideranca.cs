using SIstemaTotemHomemALua.Modelos;
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

    public partial class TabelaDeLideranca : Form
    {

        List<Usuarios> usuarios = new List<Usuarios>();

        public TabelaDeLideranca(string caminhoArquivo)
        {
            InitializeComponent();

            JsonControle jsonControle = new JsonControle();
            usuarios = jsonControle.DeserializarLista(caminhoArquivo);
            usuarios = usuarios.OrderByDescending(u => u.QuestionarioNota).ToList();
            int posicao = 1;
            foreach (var usuario in usuarios)
            {
                usuario.Posicao = posicao;
                posicao++;
            }

            dgvTabelaLideranca.DataSource = null;
            dgvTabelaLideranca.DataSource = usuarios;

            dgvTabelaLideranca.Columns["QuestionarioNota"].HeaderText = "Nota";

            dgvTabelaLideranca.Columns["Idade"].Visible = false;
            dgvTabelaLideranca.Columns["Comentario"].Visible = false;

            

        }

        private void pbxBotaoContinuar_Click(object sender, EventArgs e)
        {
            tmrTempoAusencia.Enabled = false;
            Agradecimento agr = new Agradecimento();
            agr.ShowDialog();
            this.Close();
        }



        #region Reset Timer Ausencia
        private void tmrTempoAusencia_Tick(object sender, EventArgs e)
        {
            Agradecimento agr = new Agradecimento();
            agr.ShowDialog();
            this.Close();
        }

        public void ResetTimer()
        {
            tmrTempoAusencia.Enabled = false;
            tmrTempoAusencia.Enabled = true;
        }

        private void TabelaDeLideranca_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void lblRelatorio_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void dgvRelatorio_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }
        #endregion
    }
}
