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
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
            Estatico.NOMEUSUARIO = "";
            Estatico.IDADEUSUARIO = 0;
            lblMensagem.Visible = false;
            shiftOpcao = 1;
            AtualizarTeclas(shiftOpcao);

            //Para não começar com os dois teclados ativos
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

            pcbNumpad0.Visible = false;
            pcbNumpad1.Visible = false;
            pcbNumpad2.Visible = false;
            pcbNumpad3.Visible = false;
            pcbNumpad4.Visible = false;
            pcbNumpad5.Visible = false;
            pcbNumpad6.Visible = false;
            pcbNumpad7.Visible = false;
            pcbNumpad8.Visible = false;
            pcbNumpad9.Visible = false;
            pcbNumpadBackspace.Visible = false;

        }

        public string mensagemForm1 = "";
        int shiftOpcao = 1;

        private void pbxBotaoContinuar_Click(object sender, EventArgs e)
        {
            ResetTimer();
            Controle controle = new Controle();
            controle.ArmazenarNomeIdade(txbNome.Text, txbIdade.Text);
            if (!controle.Mensagem.Equals(""))
            {
                lblMensagem.Visible = true;
                lblMensagem.Text = controle.Mensagem;
            }
            else
            {
                tmrTempoAusencia.Enabled = false;
                AvaliacaoMuseu avaMuseu = new AvaliacaoMuseu();
                avaMuseu.ShowDialog();
                if (avaMuseu.mensagemForm1.Equals("Armazenar"))
                {
                    mensagemForm1 = avaMuseu.mensagemForm1;
                }
                this.Close();
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

        private void txbIdade_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void lblIdade_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void CadastroUsuario_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        #endregion

        private void txbNome_Enter(object sender, EventArgs e)
        {
            lblNome.Location = new Point(12, 95);
            txbNome.Location = new Point(12, 153);
            txbNome.Size = new Size(597, 54);

            lblMensagem.Location = new Point(550, 210);

            lblIdade.Location = new Point(741, 95);
            txbIdade.Location = new Point(741, 153);
            txbIdade.Size = new Size(597, 54);

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

        }

        private void txbNome_Leave(object sender, EventArgs e)
        {
            
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

        }

        private void txbIdade_Enter(object sender, EventArgs e)
        {
            lblNome.Location = new Point(12, 95);
            txbNome.Location = new Point(12, 153);
            txbNome.Size = new Size(597, 54);

            lblMensagem.Location = new Point(550, 210);

            lblIdade.Location = new Point(741, 95);
            txbIdade.Location = new Point(741, 153);
            txbIdade.Size = new Size(597, 54);

            pcbNumpad0.Visible = true;
            pcbNumpad1.Visible = true;
            pcbNumpad2.Visible = true;
            pcbNumpad3.Visible = true;
            pcbNumpad4.Visible = true;
            pcbNumpad5.Visible = true;
            pcbNumpad6.Visible = true;
            pcbNumpad7.Visible = true;
            pcbNumpad8.Visible = true;
            pcbNumpad9.Visible = true;
            pcbNumpadBackspace.Visible = true;

        }

        private void txbIdade_Leave(object sender, EventArgs e)
        {
            
            pcbNumpad0.Visible = false;
            pcbNumpad1.Visible = false;
            pcbNumpad2.Visible = false;
            pcbNumpad3.Visible = false;
            pcbNumpad4.Visible = false;
            pcbNumpad5.Visible = false;
            pcbNumpad6.Visible = false;
            pcbNumpad7.Visible = false;
            pcbNumpad8.Visible = false;
            pcbNumpad9.Visible = false;
            pcbNumpadBackspace.Visible = false;

        }

        #region Teclados

        #region Keyboard

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
            if (txbNome.Text.Length > 0)
            {
                txbNome.Text = txbNome.Text.Substring(0, txbNome.Text.Length - 1);
            }
        }

        private void pcbKeyA_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(27);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(1);
                        break;
                }
            }
        }

        private void pcbKeyB_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(28);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(2);
                        break;
                }
            }
        }

        private void pcbKeyC_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(29);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(3);
                        break;
                }
            }
        }

        private void pcbKeyD_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(30);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(4);
                        break;
                }
            }
        }

        private void pcbKeyE_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(31);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(5);
                        break;
                }
            }
        }

        private void pcbKeyF_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(32);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(6);
                        break;
                }
            }
        }

        private void pcbKeyG_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(33);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(7);
                        break;
                }
            }
        }

        private void pcbKeyH_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(34);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(8);
                        break;
                }
            }
        }

        private void pcbKeyI_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(35);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(9);
                        break;
                }
            }
        }

        private void pcbKeyJ_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(36);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(10);
                        break;
                }
            }
        }

        private void pcbKeyK_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(37);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(11);
                        break;
                }
            }
        }

        private void pcbKeyL_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(38);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(12);
                        break;
                }
            }
        }

        private void pcbKeyM_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(39);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(13);
                        break;
                }
            }
        }

        private void pcbKeyN_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(40);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(14);
                        break;
                }
            }
        }

        private void pcbKeyO_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(41);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(15);
                        break;
                }
            }
        }

        private void pcbKeyP_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(42);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(16);
                        break;
                }
            }
        }

        private void pcbKeyQ_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(43);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(17);
                        break;
                }
            }
        }

        private void pcbKeyR_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(44);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(18);
                        break;
                }
            }
        }

        private void pcbKeyS_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(45);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(19);
                        break;
                }
            }
        }

        private void pcbKeyT_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(46);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(20);
                        break;
                }
            }
        }

        private void pcbKeyU_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(47);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(21);
                        break;
                }
            }
        }

        private void pcbKeyV_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(48);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(22);
                        break;
                }
            }
        }

        private void pcbKeyW_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(49);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(23);
                        break;
                }
            }
        }

        private void pcbKeyX_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(50);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(24);
                        break;
                }
            }
        }

        private void pcbKeyY_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(51);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(25);
                        break;
                }
            }
        }

        private void pcbKeyZ_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(52);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(26);
                        break;
                }
            }
        }

        private void pcbKeyÇ_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                switch (shiftOpcao)
                {
                    case 0:
                        txbNome.Text += controle.Teclado(57);
                        break;

                    case 1:
                        txbNome.Text += controle.Teclado(56);
                        break;
                }
            }
        }

        private void pcbKeyComma_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                txbNome.Text += controle.Teclado(53);
            }
        }

        private void pcbKeyDot_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                txbNome.Text += controle.Teclado(54);
            }
        }

        private void pcbKeySpace_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbNome.Text.Length < txbNome.MaxLength)
            {
                Controle controle = new Controle();
                txbNome.Text += controle.Teclado(55);
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

        #region Numpad
        private void pcbNumpad1_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbIdade.Text.Length < txbIdade.MaxLength)
            {
                Controle controle = new Controle();
                txbIdade.Text += controle.Teclado(58);
            }
        }

        private void pcbNumpad2_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbIdade.Text.Length < txbIdade.MaxLength)
            {
                Controle controle = new Controle();
                txbIdade.Text += controle.Teclado(59);
            }
        }

        private void pcbNumpad3_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbIdade.Text.Length < txbIdade.MaxLength)
            {
                Controle controle = new Controle();
                txbIdade.Text += controle.Teclado(60);
            }
        }

        private void pcbNumpad4_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbIdade.Text.Length < txbIdade.MaxLength)
            {
                Controle controle = new Controle();
                txbIdade.Text += controle.Teclado(61);
            }
        }

        private void pcbNumpad5_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbIdade.Text.Length < txbIdade.MaxLength)
            {
                Controle controle = new Controle();
                txbIdade.Text += controle.Teclado(62);
            }
        }

        private void pcbNumpad6_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbIdade.Text.Length < txbIdade.MaxLength)
            {
                Controle controle = new Controle();
                txbIdade.Text += controle.Teclado(63);
            }
        }

        private void pcbNumpad7_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbIdade.Text.Length < txbIdade.MaxLength)
            {
                Controle controle = new Controle();
                txbIdade.Text += controle.Teclado(64);
            }
        }

        private void pcbNumpad8_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbIdade.Text.Length < txbIdade.MaxLength)
            {
                Controle controle = new Controle();
                txbIdade.Text += controle.Teclado(65);
            }
        }

        private void pcbNumpad9_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbIdade.Text.Length < txbIdade.MaxLength)
            {
                Controle controle = new Controle();
                txbIdade.Text += controle.Teclado(66);
            }
        }

        private void pcbNumpad0_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbIdade.Text.Length < txbIdade.MaxLength)
            {
                Controle controle = new Controle();
                txbIdade.Text += controle.Teclado(67);
            }
        }

        private void pcbNumpadBackspace_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (txbIdade.Text.Length > 0)
            {
                txbIdade.Text = txbIdade.Text.Substring(0, txbIdade.Text.Length - 1);
            }
        }
        #endregion

        #endregion


        
    }
}
