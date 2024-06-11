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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SIstemaTotemHomemALua
{
    public partial class AvaliacaoMuseu : Form
    {
        public AvaliacaoMuseu()
        {
            InitializeComponent();
            notaAvaliacao = 0;
            perguntaId = 1;
            shiftOpcao = 1;
            txbComentario.Text = "";
            AvancarPergunta();
            AtualizarTeclas(shiftOpcao);
        }

        public string mensagemForm1 = "";
        int perguntaId = 1;
        int notaQualidadeObras = 0;
        int notaVisitaMuseu = 0;
        int notaRecomendacao = 0;
        int notaAvaliacao = 0;
        int shiftOpcao = 1;

        #region Luas Cliques
        private void pcbLua1_Click(object sender, EventArgs e)
        {
            ResetTimer();
            AtualizarNotas(1);

            notaAvaliacao = 1;
        }

        private void pcbLua2_Click(object sender, EventArgs e)
        {
            ResetTimer();
            AtualizarNotas(2);

            notaAvaliacao = 2;
        }

        private void pcbLua3_Click(object sender, EventArgs e)
        {
            ResetTimer();
            AtualizarNotas(3);

            notaAvaliacao = 3;
        }

        private void pcbLua4_Click(object sender, EventArgs e)
        {
            ResetTimer();
            AtualizarNotas(4);

            notaAvaliacao = 4;
        }

        private void pcbLua5_Click(object sender, EventArgs e)
        {
            ResetTimer();
            AtualizarNotas(5);

            notaAvaliacao = 5;
        }
        #endregion

        public void AtualizarNotas(int NotaImagem)
        {
            switch (NotaImagem)
            {
                case 0:
                    pcbLua1.ImageLocation = "Imagens/Botões/BotaoAvaliacaoDES.png";
                    pcbLua2.ImageLocation = "Imagens/Botões/BotaoAvaliacaoDES.png";
                    pcbLua3.ImageLocation = "Imagens/Botões/BotaoAvaliacaoDES.png";
                    pcbLua4.ImageLocation = "Imagens/Botões/BotaoAvaliacaoDES.png";
                    pcbLua5.ImageLocation = "Imagens/Botões/BotaoAvaliacaoDES.png";
                    break;

                case 1:
                    pcbLua1.ImageLocation = "Imagens/Botões/BotaoAvaliacaoATI.png";

                    pcbLua2.ImageLocation = "Imagens/Botões/BotaoAvaliacaoDES.png";
                    pcbLua3.ImageLocation = "Imagens/Botões/BotaoAvaliacaoDES.png";
                    pcbLua4.ImageLocation = "Imagens/Botões/BotaoAvaliacaoDES.png";
                    pcbLua5.ImageLocation = "Imagens/Botões/BotaoAvaliacaoDES.png";
                    break;

                case 2:
                    pcbLua1.ImageLocation = "Imagens/Botões/BotaoAvaliacaoATI.png";
                    pcbLua2.ImageLocation = "Imagens/Botões/BotaoAvaliacaoATI.png";

                    pcbLua3.ImageLocation = "Imagens/Botões/BotaoAvaliacaoDES.png";
                    pcbLua4.ImageLocation = "Imagens/Botões/BotaoAvaliacaoDES.png";
                    pcbLua5.ImageLocation = "Imagens/Botões/BotaoAvaliacaoDES.png";
                    break;

                case 3:
                    pcbLua1.ImageLocation = "Imagens/Botões/BotaoAvaliacaoATI.png";
                    pcbLua2.ImageLocation = "Imagens/Botões/BotaoAvaliacaoATI.png";
                    pcbLua3.ImageLocation = "Imagens/Botões/BotaoAvaliacaoATI.png";

                    pcbLua4.ImageLocation = "Imagens/Botões/BotaoAvaliacaoDES.png";
                    pcbLua5.ImageLocation = "Imagens/Botões/BotaoAvaliacaoDES.png";
                    break;

                case 4:
                    pcbLua1.ImageLocation = "Imagens/Botões/BotaoAvaliacaoATI.png";
                    pcbLua2.ImageLocation = "Imagens/Botões/BotaoAvaliacaoATI.png";
                    pcbLua3.ImageLocation = "Imagens/Botões/BotaoAvaliacaoATI.png";
                    pcbLua4.ImageLocation = "Imagens/Botões/BotaoAvaliacaoATI.png";

                    pcbLua5.ImageLocation = "Imagens/Botões/BotaoAvaliacaoDES.png";
                    break;

                case 5:
                    pcbLua1.ImageLocation = "Imagens/Botões/BotaoAvaliacaoATI.png";
                    pcbLua2.ImageLocation = "Imagens/Botões/BotaoAvaliacaoATI.png";
                    pcbLua3.ImageLocation = "Imagens/Botões/BotaoAvaliacaoATI.png";
                    pcbLua4.ImageLocation = "Imagens/Botões/BotaoAvaliacaoATI.png";
                    pcbLua5.ImageLocation = "Imagens/Botões/BotaoAvaliacaoATI.png";
                    break;

                default:
                    NotaImagem = 0;
                    AtualizarNotas(NotaImagem);
                    break;
            }
        }

        private void AvancarPergunta()
        {
            switch (perguntaId)
            {
                case 1:
                    notaAvaliacao = 0;
                    lblPergunta.Text = "Como você classificaria a qualidade das\nobras de arte representadas no museu?";
                    AtualizarNotas(0);

                    txbComentario.Visible = false;
                    pcbLua1.Visible = true;
                    pcbLua2.Visible = true;
                    pcbLua3.Visible = true;
                    pcbLua4.Visible = true;
                    pcbLua5.Visible = true;

                    lblMensagem.Visible = false;
                    lblMensagem.Text = "";

                    pcbKeyA.Visible = false;
                    pcbKeyB.Visible = false;
                    pcbKeyC.Visible = false;
                    pcbKeyD.Visible = false;
                    pcbKeyE.Visible = false;
                    pcbKeyF.Visible = false;
                    pcbKeyG.Visible = false;
                    pcbKeyH.Visible = false;
                    pcbKeyI.Visible = false;
                    pcbKeyJ.Visible = false;
                    pcbKeyK.Visible = false;
                    pcbKeyL.Visible = false;
                    pcbKeyM.Visible = false;
                    pcbKeyN.Visible = false;
                    pcbKeyO.Visible = false;
                    pcbKeyP.Visible = false;
                    pcbKeyQ.Visible = false;
                    pcbKeyR.Visible = false;
                    pcbKeyS.Visible = false;
                    pcbKeyT.Visible = false;
                    pcbKeyU.Visible = false;
                    pcbKeyV.Visible = false;
                    pcbKeyW.Visible = false;
                    pcbKeyX.Visible = false;
                    pcbKeyY.Visible = false;
                    pcbKeyZ.Visible = false;
                    pcbKeyÇ.Visible = false;
                    pcbKeyShift.Visible = false;
                    pcbKeySpace.Visible = false;
                    pcbKeyBackspace.Visible = false;
                    pcbKeyComma.Visible = false;
                    pcbKeyDot.Visible = false;
                    break;

                case 2:
                    notaAvaliacao = 0;
                    lblPergunta.Text = "Como você avaliaria sua experiência\ndurante a visita ao museu?";
                    AtualizarNotas(0);

                    txbComentario.Visible = false;
                    pcbLua1.Visible = true;
                    pcbLua2.Visible = true;
                    pcbLua3.Visible = true;
                    pcbLua4.Visible = true;
                    pcbLua5.Visible = true;

                    lblMensagem.Visible = false;
                    lblMensagem.Text = "";

                    pcbKeyA.Visible = false;
                    pcbKeyB.Visible = false;
                    pcbKeyC.Visible = false;
                    pcbKeyD.Visible = false;
                    pcbKeyE.Visible = false;
                    pcbKeyF.Visible = false;
                    pcbKeyG.Visible = false;
                    pcbKeyH.Visible = false;
                    pcbKeyI.Visible = false;
                    pcbKeyJ.Visible = false;
                    pcbKeyK.Visible = false;
                    pcbKeyL.Visible = false;
                    pcbKeyM.Visible = false;
                    pcbKeyN.Visible = false;
                    pcbKeyO.Visible = false;
                    pcbKeyP.Visible = false;
                    pcbKeyQ.Visible = false;
                    pcbKeyR.Visible = false;
                    pcbKeyS.Visible = false;
                    pcbKeyT.Visible = false;
                    pcbKeyU.Visible = false;
                    pcbKeyV.Visible = false;
                    pcbKeyW.Visible = false;
                    pcbKeyX.Visible = false;
                    pcbKeyY.Visible = false;
                    pcbKeyZ.Visible = false;
                    pcbKeyÇ.Visible = false;
                    pcbKeyShift.Visible = false;
                    pcbKeySpace.Visible = false;
                    pcbKeyBackspace.Visible = false;
                    pcbKeyComma.Visible = false;
                    pcbKeyDot.Visible = false;
                    break;

                case 3:
                    notaAvaliacao = 0;
                    lblPergunta.Text = "Em uma escala de 1 a 5, o quanto você\nrecomendaria esta visita a um\nparente ou amigo?";
                    AtualizarNotas(0);

                    txbComentario.Visible = false;
                    pcbLua1.Visible = true;
                    pcbLua2.Visible = true;
                    pcbLua3.Visible = true;
                    pcbLua4.Visible = true;
                    pcbLua5.Visible = true;

                    lblMensagem.Visible = false;
                    lblMensagem.Text = "";

                    pcbKeyA.Visible = false;
                    pcbKeyB.Visible = false;
                    pcbKeyC.Visible = false;
                    pcbKeyD.Visible = false;
                    pcbKeyE.Visible = false;
                    pcbKeyF.Visible = false;
                    pcbKeyG.Visible = false;
                    pcbKeyH.Visible = false;
                    pcbKeyI.Visible = false;
                    pcbKeyJ.Visible = false;
                    pcbKeyK.Visible = false;
                    pcbKeyL.Visible = false;
                    pcbKeyM.Visible = false;
                    pcbKeyN.Visible = false;
                    pcbKeyO.Visible = false;
                    pcbKeyP.Visible = false;
                    pcbKeyQ.Visible = false;
                    pcbKeyR.Visible = false;
                    pcbKeyS.Visible = false;
                    pcbKeyT.Visible = false;
                    pcbKeyU.Visible = false;
                    pcbKeyV.Visible = false;
                    pcbKeyW.Visible = false;
                    pcbKeyX.Visible = false;
                    pcbKeyY.Visible = false;
                    pcbKeyZ.Visible = false;
                    pcbKeyÇ.Visible = false;
                    pcbKeyShift.Visible = false;
                    pcbKeySpace.Visible = false;
                    pcbKeyBackspace.Visible = false;
                    pcbKeyComma.Visible = false;
                    pcbKeyDot.Visible = false;
                    break;

                case 4:
                    notaAvaliacao = 1;
                    lblPergunta.Text = "Sua opinião é importante para nós.\nDeixe seu comentário! (Opcional)";
                    AtualizarNotas(0);

                    txbComentario.Visible = true;
                    pcbLua1.Visible = false;
                    pcbLua2.Visible = false;
                    pcbLua3.Visible = false;
                    pcbLua4.Visible = false;
                    pcbLua5.Visible = false;

                    lblMensagem.Visible = false;
                    lblMensagem.Text = "";

                    pcbKeyA.Visible = true;
                    pcbKeyB.Visible = true;
                    pcbKeyC.Visible = true;
                    pcbKeyD.Visible = true;
                    pcbKeyE.Visible = true;
                    pcbKeyF.Visible = true;
                    pcbKeyG.Visible = true;
                    pcbKeyH.Visible = true;
                    pcbKeyI.Visible = true;
                    pcbKeyJ.Visible = true;
                    pcbKeyK.Visible = true;
                    pcbKeyL.Visible = true;
                    pcbKeyM.Visible = true;
                    pcbKeyN.Visible = true;
                    pcbKeyO.Visible = true;
                    pcbKeyP.Visible = true;
                    pcbKeyQ.Visible = true;
                    pcbKeyR.Visible = true;
                    pcbKeyS.Visible = true;
                    pcbKeyT.Visible = true;
                    pcbKeyU.Visible = true;
                    pcbKeyV.Visible = true;
                    pcbKeyW.Visible = true;
                    pcbKeyX.Visible = true;
                    pcbKeyY.Visible = true;
                    pcbKeyZ.Visible = true;
                    pcbKeyÇ.Visible = true;
                    pcbKeyShift.Visible = true;
                    pcbKeySpace.Visible = true;
                    pcbKeyBackspace.Visible = true;
                    pcbKeyComma.Visible = true;
                    pcbKeyDot.Visible = true;
                    break;

                case 5:
                    tmrTempoAusencia.Enabled = false;
                    Controle controle = new Controle();
                    controle.ConcluirCadastro(notaQualidadeObras, notaVisitaMuseu, notaRecomendacao, txbComentario.Text);
                    if (controle.MensagemForm1.Equals("Armazenar"))
                    {
                        mensagemForm1 = controle.MensagemForm1;
                    }
                    this.Close();
                    break;

                default:
                    perguntaId = 1;
                    AvancarPergunta();
                    break;

            }
        }

        private void pbxBotaoContinuar_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (notaAvaliacao.Equals(0))
            {
                lblMensagem.Visible = true;
                lblMensagem.Text = "Nota não foi atribuida";
            }
            else
            {
                switch (perguntaId)
                {
                    case 1:
                        notaQualidadeObras = notaAvaliacao;
                        break;

                    case 2:
                        notaVisitaMuseu = notaAvaliacao;
                        break;

                    case 3:
                        notaRecomendacao = notaAvaliacao;
                        break;
                }
                perguntaId++;
                AvancarPergunta();
            }
        }

        #region Reset Timer Ausencia
        public void ResetTimer()
        {
            tmrTempoAusencia.Enabled = false;
            tmrTempoAusencia.Enabled = true;
        }

        private void tmrTempoAusencia_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbComentario_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void AvaliacaoMuseu_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void lblSubtitulo_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }
        #endregion




        #region Teclado

        public void AtualizarTeclas(int shiftOpcao)
        {
            switch (shiftOpcao)
            {
                case 0:
                    pcbKeyA.ImageLocation = "Imagens/Teclas/Minusculo/a.png";
                    pcbKeyB.ImageLocation = "Imagens/Teclas/Minusculo/b.png";
                    pcbKeyC.ImageLocation = "Imagens/Teclas/Minusculo/c.png";
                    pcbKeyD.ImageLocation = "Imagens/Teclas/Minusculo/d.png";
                    pcbKeyE.ImageLocation = "Imagens/Teclas/Minusculo/e.png";
                    pcbKeyF.ImageLocation = "Imagens/Teclas/Minusculo/f.png";
                    pcbKeyG.ImageLocation = "Imagens/Teclas/Minusculo/g.png";
                    pcbKeyH.ImageLocation = "Imagens/Teclas/Minusculo/h.png";
                    pcbKeyI.ImageLocation = "Imagens/Teclas/Minusculo/i.png";
                    pcbKeyJ.ImageLocation = "Imagens/Teclas/Minusculo/j.png";
                    pcbKeyK.ImageLocation = "Imagens/Teclas/Minusculo/k.png";
                    pcbKeyL.ImageLocation = "Imagens/Teclas/Minusculo/l.png";
                    pcbKeyM.ImageLocation = "Imagens/Teclas/Minusculo/m.png";
                    pcbKeyN.ImageLocation = "Imagens/Teclas/Minusculo/n.png";
                    pcbKeyO.ImageLocation = "Imagens/Teclas/Minusculo/o.png";
                    pcbKeyP.ImageLocation = "Imagens/Teclas/Minusculo/p.png";
                    pcbKeyQ.ImageLocation = "Imagens/Teclas/Minusculo/q.png";
                    pcbKeyR.ImageLocation = "Imagens/Teclas/Minusculo/r.png";
                    pcbKeyS.ImageLocation = "Imagens/Teclas/Minusculo/s.png";
                    pcbKeyT.ImageLocation = "Imagens/Teclas/Minusculo/t.png";
                    pcbKeyU.ImageLocation = "Imagens/Teclas/Minusculo/u.png";
                    pcbKeyV.ImageLocation = "Imagens/Teclas/Minusculo/v.png";
                    pcbKeyW.ImageLocation = "Imagens/Teclas/Minusculo/w.png";
                    pcbKeyX.ImageLocation = "Imagens/Teclas/Minusculo/x.png";
                    pcbKeyY.ImageLocation = "Imagens/Teclas/Minusculo/y.png";
                    pcbKeyZ.ImageLocation = "Imagens/Teclas/Minusculo/z.png";
                    pcbKeyÇ.ImageLocation = "Imagens/Teclas/Minusculo/ç.png";
                    pcbKeyShift.ImageLocation = "Imagens/Teclas/ShiftDesligado.png";
                    break;

                case 1:
                    pcbKeyA.ImageLocation = "Imagens/Teclas/Maiusculas/A.png";
                    pcbKeyB.ImageLocation = "Imagens/Teclas/Maiusculas/B.png";
                    pcbKeyC.ImageLocation = "Imagens/Teclas/Maiusculas/C.png";
                    pcbKeyD.ImageLocation = "Imagens/Teclas/Maiusculas/D.png";
                    pcbKeyE.ImageLocation = "Imagens/Teclas/Maiusculas/E.png";
                    pcbKeyF.ImageLocation = "Imagens/Teclas/Maiusculas/F.png";
                    pcbKeyG.ImageLocation = "Imagens/Teclas/Maiusculas/G.png";
                    pcbKeyH.ImageLocation = "Imagens/Teclas/Maiusculas/H.png";
                    pcbKeyI.ImageLocation = "Imagens/Teclas/Maiusculas/I.png";
                    pcbKeyJ.ImageLocation = "Imagens/Teclas/Maiusculas/J.png";
                    pcbKeyK.ImageLocation = "Imagens/Teclas/Maiusculas/K.png";
                    pcbKeyL.ImageLocation = "Imagens/Teclas/Maiusculas/L.png";
                    pcbKeyM.ImageLocation = "Imagens/Teclas/Maiusculas/M.png";
                    pcbKeyN.ImageLocation = "Imagens/Teclas/Maiusculas/N.png";
                    pcbKeyO.ImageLocation = "Imagens/Teclas/Maiusculas/O.png";
                    pcbKeyP.ImageLocation = "Imagens/Teclas/Maiusculas/P.png";
                    pcbKeyQ.ImageLocation = "Imagens/Teclas/Maiusculas/Q.png";
                    pcbKeyR.ImageLocation = "Imagens/Teclas/Maiusculas/R.png";
                    pcbKeyS.ImageLocation = "Imagens/Teclas/Maiusculas/S.png";
                    pcbKeyT.ImageLocation = "Imagens/Teclas/Maiusculas/T.png";
                    pcbKeyU.ImageLocation = "Imagens/Teclas/Maiusculas/U.png";
                    pcbKeyV.ImageLocation = "Imagens/Teclas/Maiusculas/V.png";
                    pcbKeyW.ImageLocation = "Imagens/Teclas/Maiusculas/W.png";
                    pcbKeyX.ImageLocation = "Imagens/Teclas/Maiusculas/X.png";
                    pcbKeyY.ImageLocation = "Imagens/Teclas/Maiusculas/Y.png";
                    pcbKeyZ.ImageLocation = "Imagens/Teclas/Maiusculas/Z.png";
                    pcbKeyÇ.ImageLocation = "Imagens/Teclas/Maiusculas/Ç.png";
                    pcbKeyShift.ImageLocation = "Imagens/Teclas/ShiftAtivo.png";
                    break;

            }
        }

        private void pcbKeyBackspace_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length > 0)
            {
                txbComentario.Text = txbComentario.Text.Substring(0, txbComentario.Text.Length - 1);
            }
        }

        private void pcbKeyA_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(27);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(1);
                        break;
                }
            }
        }

        private void pcbKeyB_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(28);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(2);
                        break;
                }
            }
        }

        private void pcbKeyC_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(29);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(3);
                        break;
                }
            }
        }

        private void pcbKeyD_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(30);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(4);
                        break;
                }
            }
        }

        private void pcbKeyE_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(31);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(5);
                        break;
                }
            }
        }

        private void pcbKeyF_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(32);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(6);
                        break;
                }
            }
        }

        private void pcbKeyG_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(33);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(7);
                        break;
                }
            }
        }

        private void pcbKeyH_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(34);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(8);
                        break;
                }
            }
        }

        private void pcbKeyI_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(35);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(9);
                        break;
                }
            }
        }

        private void pcbKeyJ_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(36);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(10);
                        break;
                }
            }
        }

        private void pcbKeyK_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(37);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(11);
                        break;
                }
            }
        }

        private void pcbKeyL_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(38);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(12);
                        break;
                }
            }
        }

        private void pcbKeyM_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(39);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(13);
                        break;
                }
            }
        }

        private void pcbKeyN_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(40);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(14);
                        break;
                }
            }
        }

        private void pcbKeyO_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(41);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(15);
                        break;
                }
            }
        }

        private void pcbKeyP_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(42);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(16);
                        break;
                }
            }
        }

        private void pcbKeyQ_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(43);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(17);
                        break;
                }
            }
        }

        private void pcbKeyR_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(44);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(18);
                        break;
                }
            }
        }

        private void pcbKeyS_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(45);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(19);
                        break;
                }
            }
        }

        private void pcbKeyT_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(46);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(20);
                        break;
                }
            }
        }

        private void pcbKeyU_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(47);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(21);
                        break;
                }
            }
        }

        private void pcbKeyV_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(48);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(22);
                        break;
                }
            }
        }

        private void pcbKeyW_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(49);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(23);
                        break;
                }
            }
        }

        private void pcbKeyX_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(50);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(24);
                        break;
                }
            }
        }

        private void pcbKeyY_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(51);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(25);
                        break;
                }
            }
        }

        private void pcbKeyZ_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(52);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(26);
                        break;
                }
            }
        }

        private void pcbKeyÇ_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbComentario.Text += controle.Teclado(57);
                        break;

                    case 1:
                        txbComentario.Text += controle.Teclado(56);
                        break;
                }
            }
        }

        private void pcbKeyComma_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                txbComentario.Text += controle.Teclado(53);
            }
        }

        private void pcbKeyDot_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                txbComentario.Text += controle.Teclado(54);
            }
        }

        private void pcbKeySpace_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbComentario.Text.Length < txbComentario.MaxLength)
            {
                Controle controle = new Controle();
                txbComentario.Text += controle.Teclado(55);
            }
        }

        private void pcbKeyShift_Click(object sender, EventArgs e)
        {
            ResetTimer();
            switch (shiftOpcao) 
            {
                case 0:
                    shiftOpcao = 1;
                    break;

                case 1:
                    shiftOpcao = 0;
                    break;

                default:
                    shiftOpcao = 1;
                    break;
            }
            AtualizarTeclas(shiftOpcao);
        }
        #endregion
    }
}
