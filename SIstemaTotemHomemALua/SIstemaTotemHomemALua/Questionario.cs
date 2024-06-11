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
    public partial class Questionario : Form
    {
        public Questionario()
        {
            InitializeComponent();
            Estatico.QUESTIONARIOUOTAUSUARIO = 0;

            Estatico.TEMPACERTOSQUEST1 = 0;
            Estatico.TEMPACERTOSQUEST2 = 0;
            Estatico.TEMPACERTOSQUEST3 = 0;
            Estatico.TEMPACERTOSQUEST4 = 0;
            Estatico.TEMPACERTOSQUEST5 = 0;

            Estatico.TEMPERROSQUEST1 = 0;
            Estatico.TEMPERROSQUEST2 = 0;
            Estatico.TEMPERROSQUEST3 = 0;
            Estatico.TEMPERROSQUEST4 = 0;
            Estatico.TEMPERROSQUEST5 = 0;

            Estatico.TEMPRESPOSTAQUEST1 = "";
            Estatico.TEMPRESPOSTAQUEST2 = "";
            Estatico.TEMPRESPOSTAQUEST3 = "";
            Estatico.TEMPRESPOSTAQUEST4 = "";
            Estatico.TEMPRESPOSTAQUEST5 = "";

            ProximaPergunta(1);
        }

        public string mensagemForm1 = "";
        int respostaSelecionada = 0;
        int idPergunta = 1;
        string alternativaEscolhida = "";

        private void pbxBotaoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ProximaPergunta(int idPergunta)
        {

            switch (idPergunta)
            {
                case 1:
                    respostaSelecionada = 0;

                    pcbAlternativaA.ImageLocation = "Imagens/Botões/BotaoA.png";
                    pcbAlternativaB.ImageLocation = "Imagens/Botões/BotaoB.png";
                    pcbAlternativaC.ImageLocation = "Imagens/Botões/BotaoC.png";
                    pcbAlternativaD.ImageLocation = "Imagens/Botões/BotaoD.png";

                    lblPergunta.Text = "1 - Em que ano aconteceu a missão\nApollo 11?";
                    lblAlternativaA.Text = "A) 1959";
                    lblAlternativaB.Text = "B) 1974";
                    lblAlternativaC.Text = "C) 1965";
                    lblAlternativaD.Text = "D) 1969";

                    lblMensagem.Visible = false;
                    lblMensagem.Text = "";
                    break;

                case 2:
                    respostaSelecionada = 0;

                    pcbAlternativaA.ImageLocation = "Imagens/Botões/BotaoA.png";
                    pcbAlternativaB.ImageLocation = "Imagens/Botões/BotaoB.png";
                    pcbAlternativaC.ImageLocation = "Imagens/Botões/BotaoC.png";
                    pcbAlternativaD.ImageLocation = "Imagens/Botões/BotaoD.png";

                    lblPergunta.Text = "2 - Como é chamado o veículo de lançamento\nque aparece no quadro\n“Programa Sa-turno Apollo”?";
                    lblAlternativaA.Text = "A) Apollo 11";
                    lblAlternativaB.Text = "B) Foguete Espacial";
                    lblAlternativaC.Text = "C) Saturn V";
                    lblAlternativaD.Text = "D) Starship";

                    lblMensagem.Visible = false;
                    lblMensagem.Text = "";
                    break;

                case 3:
                    respostaSelecionada = 0;

                    pcbAlternativaA.ImageLocation = "Imagens/Botões/BotaoA.png";
                    pcbAlternativaB.ImageLocation = "Imagens/Botões/BotaoB.png";
                    pcbAlternativaC.ImageLocation = "Imagens/Botões/BotaoC.png";
                    pcbAlternativaD.ImageLocation = "Imagens/Botões/BotaoD.png";

                    lblPergunta.Text = "3 - Quem foi o piloto do modulo lunar\nda missão de pouso lunar Apollo 11?";
                    lblAlternativaA.Text = "A) Edwin E. Aldrin Jr.";
                    lblAlternativaB.Text = "B) Neil Armstrong";
                    lblAlternativaC.Text = "C) Elton John";
                    lblAlternativaD.Text = "D) Michael Collins";

                    lblMensagem.Visible = false;
                    lblMensagem.Text = "";
                    break;

                case 4:
                    respostaSelecionada = 0;

                    pcbAlternativaA.ImageLocation = "Imagens/Botões/BotaoA.png";
                    pcbAlternativaB.ImageLocation = "Imagens/Botões/BotaoB.png";
                    pcbAlternativaC.ImageLocation = "Imagens/Botões/BotaoC.png";
                    pcbAlternativaD.ImageLocation = "Imagens/Botões/BotaoD.png";

                    lblPergunta.Text = "4 - O que é EASEP?";
                    lblAlternativaA.Text = "A) Early Apollo Satisfying Experimentation Pocket";
                    lblAlternativaB.Text = "B) Early Apollo Scientific Experiments Package";
                    lblAlternativaC.Text = "C) Eletronic Art Sports Equestrian Paintball";
                    lblAlternativaD.Text = "D) Earth Air Salt Earn Pearls";

                    lblMensagem.Visible = false;
                    lblMensagem.Text = "";
                    break;

                case 5:
                    respostaSelecionada = 0;

                    pcbAlternativaA.ImageLocation = "Imagens/Botões/BotaoA.png";
                    pcbAlternativaB.ImageLocation = "Imagens/Botões/BotaoB.png";
                    pcbAlternativaC.ImageLocation = "Imagens/Botões/BotaoC.png";
                    pcbAlternativaD.ImageLocation = "Imagens/Botões/BotaoD.png";

                    lblPergunta.Text = "5 - Quem renunciou o programa\nespacial da Nasa? ";
                    lblAlternativaA.Text = "A) Neil Armstrong";
                    lblAlternativaB.Text = "B) Michael Jordan";
                    lblAlternativaC.Text = "C) Michael Collins";
                    lblAlternativaD.Text = "D) Edwin E. Aldrin Jr.";

                    lblMensagem.Visible = false;
                    lblMensagem.Text = "";
                    break;

                case 6:
                    tmrTempoAusencia.Enabled = false;
                    CadastroUsuario cadUsuario = new CadastroUsuario();
                    cadUsuario.ShowDialog();
                    if (cadUsuario.mensagemForm1.Equals("Armazenar"))
                    {
                        mensagemForm1 = cadUsuario.mensagemForm1;
                    }
                    this.Close();
                    break;

                default:
                    this.Close();
                    break;
            }

        }

        private void pcbAlternativaA_Click(object sender, EventArgs e)
        {
            ResetTimer();
            respostaSelecionada = 1;    //Feito para não ocorrer um clique duplo
            alternativaEscolhida = lblAlternativaA.Text;
            pcbAlternativaA.ImageLocation = "Imagens/Botões/BotaoACheck.png";
            pcbAlternativaB.ImageLocation = "Imagens/Botões/BotaoB.png";
            pcbAlternativaC.ImageLocation = "Imagens/Botões/BotaoC.png";
            pcbAlternativaD.ImageLocation = "Imagens/Botões/BotaoD.png";
        }

        private void lblAlternativaA_Click(object sender, EventArgs e)
        {
            ResetTimer();
            respostaSelecionada = 1;    //Feito para não ocorrer um clique duplo
            alternativaEscolhida = lblAlternativaA.Text;
            pcbAlternativaA.ImageLocation = "Imagens/Botões/BotaoACheck.png";
            pcbAlternativaB.ImageLocation = "Imagens/Botões/BotaoB.png";
            pcbAlternativaC.ImageLocation = "Imagens/Botões/BotaoC.png";
            pcbAlternativaD.ImageLocation = "Imagens/Botões/BotaoD.png";
        }

        private void pcbAlternativaB_Click(object sender, EventArgs e)
        {
            ResetTimer();
            respostaSelecionada = 1;    //Feito para não ocorrer um clique duplo
            alternativaEscolhida = lblAlternativaB.Text;
            pcbAlternativaA.ImageLocation = "Imagens/Botões/BotaoA.png";
            pcbAlternativaB.ImageLocation = "Imagens/Botões/BotaoBCheck.png";
            pcbAlternativaC.ImageLocation = "Imagens/Botões/BotaoC.png";
            pcbAlternativaD.ImageLocation = "Imagens/Botões/BotaoD.png";
        }

        private void lblAlternativaB_Click(object sender, EventArgs e)
        {
            ResetTimer();
            respostaSelecionada = 1;    //Feito para não ocorrer um clique duplo
            alternativaEscolhida = lblAlternativaB.Text;
            pcbAlternativaA.ImageLocation = "Imagens/Botões/BotaoA.png";
            pcbAlternativaB.ImageLocation = "Imagens/Botões/BotaoBCheck.png";
            pcbAlternativaC.ImageLocation = "Imagens/Botões/BotaoC.png";
            pcbAlternativaD.ImageLocation = "Imagens/Botões/BotaoD.png";
        }

        private void pcbAlternativaC_Click(object sender, EventArgs e)
        {
            ResetTimer();
            respostaSelecionada = 1;    //Feito para não ocorrer um clique duplo
            alternativaEscolhida = lblAlternativaC.Text;
            pcbAlternativaA.ImageLocation = "Imagens/Botões/BotaoA.png";
            pcbAlternativaB.ImageLocation = "Imagens/Botões/BotaoB.png";
            pcbAlternativaC.ImageLocation = "Imagens/Botões/BotaoCCheck.png";
            pcbAlternativaD.ImageLocation = "Imagens/Botões/BotaoD.png";
        }

        private void lblAlternativaC_Click(object sender, EventArgs e)
        {
            ResetTimer();
            respostaSelecionada = 1;    //Feito para não ocorrer um clique duplo
            alternativaEscolhida = lblAlternativaC.Text;
            pcbAlternativaA.ImageLocation = "Imagens/Botões/BotaoA.png";
            pcbAlternativaB.ImageLocation = "Imagens/Botões/BotaoB.png";
            pcbAlternativaC.ImageLocation = "Imagens/Botões/BotaoCCheck.png";
            pcbAlternativaD.ImageLocation = "Imagens/Botões/BotaoD.png";
        }
        private void pcbAlternativaD_Click(object sender, EventArgs e)
        {
            ResetTimer();
            respostaSelecionada = 1;    //Feito para não ocorrer um clique duplo
            alternativaEscolhida = lblAlternativaD.Text;
            pcbAlternativaA.ImageLocation = "Imagens/Botões/BotaoA.png";
            pcbAlternativaB.ImageLocation = "Imagens/Botões/BotaoB.png";
            pcbAlternativaC.ImageLocation = "Imagens/Botões/BotaoC.png";
            pcbAlternativaD.ImageLocation = "Imagens/Botões/BotaoDCheck.png";
        }

        private void lblAlternativaD_Click(object sender, EventArgs e)
        {
            ResetTimer();
            respostaSelecionada = 1;    //Feito para não ocorrer um clique duplo
            alternativaEscolhida = lblAlternativaD.Text;
            pcbAlternativaA.ImageLocation = "Imagens/Botões/BotaoA.png";
            pcbAlternativaB.ImageLocation = "Imagens/Botões/BotaoB.png";
            pcbAlternativaC.ImageLocation = "Imagens/Botões/BotaoC.png";
            pcbAlternativaD.ImageLocation = "Imagens/Botões/BotaoDCheck.png";
        }

        private void pbxBotaoContinuar_Click(object sender, EventArgs e)
        {
            ResetTimer();
            if (!respostaSelecionada.Equals(0))
            {
                Controle controle = new Controle();
                controle.ValidarResposta(idPergunta, alternativaEscolhida);
                idPergunta += 1;
                ProximaPergunta(idPergunta);
            }
            else
            {
                lblMensagem.Visible = true;
                lblMensagem.Text = "Selecione uma resposta!";
            }
        }


        public void ResetTimer()
        {
            tmrTempoAusencia.Enabled = false;
            tmrTempoAusencia.Enabled = true;
        }

        private void tmrTempoAusencia_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Questionario_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }


        

        

        

        
    }
}
