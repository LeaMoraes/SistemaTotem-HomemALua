using SIstemaTotemHomemALua.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIstemaTotemHomemALua
{
    public partial class Relatorio : Form
    {

        List<Usuarios> usuarios = new List<Usuarios>();

        public Relatorio(string caminhoArquivo)
        {
            InitializeComponent();
            if (File.Exists(caminhoArquivo))
            {
                JsonControle jsonControle = new JsonControle();
                usuarios = jsonControle.DeserializarLista(caminhoArquivo);
                dgvRelatorio.DataSource = usuarios;      

                dgvRelatorio.Columns["Posicao"].Visible = false;
                dgvRelatorio.Columns["QuestionarioNota"].Visible = false;

            }
            else
            {
                lblMensagem.Visible = true;
                lblMensagem.Text = "Arquivo não encontrado";
            }
            AtualizarInformacoes();
        }

        public string mensagemForm1 = "";
        private string caminhoDiretorio = @"C:\LIT\BancoDeDados";

        private void pbxBotaoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbMostrarBancoDeDados_Click(object sender, EventArgs e)
        {

            if (Directory.Exists(caminhoDiretorio))
            {
                Process.Start("explorer.exe", caminhoDiretorio);
            }
            else
            {
                lblMensagem.Visible = true;
                lblMensagem.Text = "Diretorio não existe";
            }

        }

        private void pcbFecharSistema_Click(object sender, EventArgs e)
        {
            mensagemForm1 = "FinalizarSistema";
            this.Close();
        }

        private void pcbRelatorioPerguntas_Click(object sender, EventArgs e)
        {
            RelatorioPerguntas relPerguntas = new RelatorioPerguntas();
            relPerguntas.ShowDialog();
        }

        public void AtualizarInformacoes()
        {
            if (!Estatico.SOMATOTALQUALIDADEOBRAS.Equals(0) && !Estatico.NUMEROAVALIACOESQUALIDADEOBRAS.Equals(0))
            {
                lblQualidadeObrasMedia.Text = Math.Round(((double)Estatico.SOMATOTALQUALIDADEOBRAS / Estatico.NUMEROAVALIACOESQUALIDADEOBRAS), 1).ToString();
            }
            else
            {
                lblQualidadeObrasMedia.Text = "0.0";
            }

            if(!Estatico.SOMATOTALVISITAMUSEU.Equals(0) && !Estatico.NUMEROAVALIACOESVISITAMUSEU.Equals(0))
            {
                lblExperienciaVisitaMedia.Text = Math.Round(((double)Estatico.SOMATOTALVISITAMUSEU / Estatico.NUMEROAVALIACOESVISITAMUSEU), 1).ToString();
            }
            else
            {
                lblExperienciaVisitaMedia.Text = "0.0";
            }

            if (!Estatico.SOMATOTALRECOMENDACAO.Equals(0) && !Estatico.NUMEROAVALIACOESRECOMENDACAO.Equals(0))
            {
                lblRecomendacaoMedia.Text = Math.Round(((double)Estatico.SOMATOTALRECOMENDACAO / Estatico.NUMEROAVALIACOESRECOMENDACAO), 1).ToString();
            }
            else
            {
                lblRecomendacaoMedia.Text = "0.0";
            }

        }
    }
}
