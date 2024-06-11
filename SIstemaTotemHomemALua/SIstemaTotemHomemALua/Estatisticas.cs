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
    public partial class Estatisticas : Form
    {
        public Estatisticas()
        {
            InitializeComponent();
            AtualizarEstatisticas();
            pagina = 1;
            ProximaPagina();
        }

        public void AtualizarEstatisticas()
        {
            //Jogou as respostas do usuario no Forms
            lblRespostaUsuario1.Text = Estatico.TEMPRESPOSTAQUEST1;
            lblRespostaUsuario2.Text = Estatico.TEMPRESPOSTAQUEST2;
            lblRespostaUsuario3.Text = Estatico.TEMPRESPOSTAQUEST3;
            lblRespostaUsuario4.Text = Estatico.TEMPRESPOSTAQUEST4;
            lblRespostaUsuario5.Text = Estatico.TEMPRESPOSTAQUEST5;

            lblTotalAcertos.Text = "Total De Acertos: " + Estatico.TOTALACERTOS;
            lblTotalErros.Text = "Total De Erros: " + Estatico.TOTALERROS;

            VerificarRespostas();

            AtualizarEstatisticaGlobal();
        }

        public string pergunta1 = "Acertou";
        public string pergunta2 = "Acertou";
        public string pergunta3 = "Acertou";
        public string pergunta4 = "Acertou";
        public string pergunta5 = "Acertou";
        public int pagina = 1;

        public void VerificarRespostas()
        {
            if (lblRespostaUsuario1.Text != lblRespostaCerta1.Text)
            {
                lblRespostaUsuario1.ForeColor = Color.IndianRed;
                lblRespostaUsuario1.Font = new Font(lblRespostaUsuario1.Font, FontStyle.Strikeout);
                lblRespostaCerta1.Visible = true;
                pergunta1 = "Errou";
            }

            if (lblRespostaUsuario2.Text != lblRespostaCerta2.Text)
            {
                lblRespostaUsuario2.ForeColor = Color.IndianRed;
                lblRespostaUsuario2.Font = new Font(lblRespostaUsuario2.Font, FontStyle.Strikeout);
                lblRespostaCerta2.Visible = true;
                pergunta2 = "Errou";
            }

            if (lblRespostaUsuario3.Text != lblRespostaCerta3.Text)
            {
                lblRespostaUsuario3.ForeColor = Color.IndianRed;
                lblRespostaUsuario3.Font = new Font(lblRespostaUsuario3.Font, FontStyle.Strikeout);
                lblRespostaCerta3.Visible = true;
                pergunta3 = "Errou";
            }

            if (lblRespostaUsuario4.Text != lblRespostaCerta4.Text)
            {
                lblRespostaUsuario4.ForeColor = Color.IndianRed;
                lblRespostaUsuario4.Font = new Font(lblRespostaUsuario4.Font, FontStyle.Strikeout);
                lblRespostaCerta4.Visible = true;
                pergunta4 = "Errou";
            }

            if (lblRespostaUsuario5.Text != lblRespostaCerta5.Text)
            {
                lblRespostaUsuario5.ForeColor = Color.IndianRed;
                lblRespostaUsuario5.Font = new Font(lblRespostaUsuario5.Font, FontStyle.Strikeout);
                lblRespostaCerta5.Visible = true;
                pergunta5 = "Errou";
            }
        }

        public void AtualizarEstatisticaGlobal()
        {

            Random random = new Random();


            switch (pergunta1)
            {
                case "Acertou":

                    int i = random.Next(1, 4);

                    switch (i)
                    {
                        case 1:
                            lblTotalPessoasQuestao1.Text = Estatico.ACERTOSQUEST1 + " Pessoa(s) acertaram esta questão, você esta é uma delas";
                            break;

                        case 2:
                            lblTotalPessoasQuestao1.Text = "Você esta entre " + Estatico.ACERTOSQUEST1 + " das pessoa(s) que acertaram essa pergunta";
                            break;

                        case 3:
                            double porcentagem = Math.Round((double)Estatico.ACERTOSQUEST1 / Estatico.TOTALRESPOSTASQUEST1 * 100, 1);
                            lblTotalPessoasQuestao1.Text = "Você esta entre os " + porcentagem + "% que acertaram esta pergunta";
                            break;

                        default:
                            MessageBox.Show("Sem frase\nNumeração: " + i);
                            break;
                    }

                    break;

                case "Errou":

                    int ii = random.Next(1, 4);

                    switch (ii)
                    {
                        case 1:
                            lblTotalPessoasQuestao1.Text = Estatico.ERROSQUEST1 + " Pessoa(s) erraram esta questão";
                            break;

                        case 2:
                            lblTotalPessoasQuestao1.Text = "Não se preocupe, " + Estatico.ERROSQUEST1 + " pessoa(s) tambem erraram";
                            break;

                        case 3:
                            double porcentagem = Math.Round((double)Estatico.ERROSQUEST1 / Estatico.TOTALRESPOSTASQUEST1 * 100, 1);
                            lblTotalPessoasQuestao1.Text = porcentagem + "% das pessoas que passaram por esta pergunta, erraram";
                            break;

                        default:
                            MessageBox.Show("Sem frase\nNumeração: " + ii);
                            break;
                    }

                    break;

            }

            switch (pergunta2)
            {
                case "Acertou":

                    int i = random.Next(1, 4);

                    switch (i)
                    {
                        case 1:
                            lblTotalPessoasQuestao2.Text = Estatico.ACERTOSQUEST2 + " Pessoa(s) acertaram esta questão, você esta é uma delas";
                            break;

                        case 2:
                            lblTotalPessoasQuestao2.Text = "Você esta entre " + Estatico.ACERTOSQUEST2 + " das pessoa(s) que acertaram essa pergunta";
                            break;

                        case 3:
                            double porcentagem = Math.Round((double)Estatico.ACERTOSQUEST2 / Estatico.TOTALRESPOSTASQUEST2 * 100, 1);
                            lblTotalPessoasQuestao2.Text = "Você esta entre os " + porcentagem + "% que acertaram esta pergunta";
                            break;

                        default:
                            MessageBox.Show("Sem frase\nNumeração: " + i);
                            break;
                    }

                    break;

                case "Errou":

                    int ii = random.Next(1, 4);

                    switch (ii)
                    {
                        case 1:
                            lblTotalPessoasQuestao2.Text = Estatico.ERROSQUEST2 + " Pessoa(s) erraram esta questão";
                            break;

                        case 2:
                            lblTotalPessoasQuestao2.Text = "Não se preocupe, " + Estatico.ERROSQUEST2 + " pessoa(s) tambem erraram";
                            break;

                        case 3:
                            double porcentagem = Math.Round((double)Estatico.ERROSQUEST2 / Estatico.TOTALRESPOSTASQUEST2 * 100, 1);
                            lblTotalPessoasQuestao2.Text = porcentagem + "% das pessoas que passaram por esta pergunta, erraram";
                            break;

                        default:
                            MessageBox.Show("Sem frase\nNumeração: " + ii);
                            break;
                    }

                    break;

            }

            switch (pergunta3)
            {
                case "Acertou":

                    int i = random.Next(1, 4);

                    switch (i)
                    {
                        case 1:
                            lblTotalPessoasQuestao3.Text = Estatico.ACERTOSQUEST3 + " Pessoa(s) acertaram esta questão, você esta é uma delas";
                            break;

                        case 2:
                            lblTotalPessoasQuestao3.Text = "Você esta entre " + Estatico.ACERTOSQUEST3 + " das pessoa(s) que acertaram essa pergunta";
                            break;

                        case 3:
                            double porcentagem = Math.Round((double)Estatico.ACERTOSQUEST3 / Estatico.TOTALRESPOSTASQUEST3 * 100, 1);
                            lblTotalPessoasQuestao3.Text = "Você esta entre os " + porcentagem + "% que acertaram esta pergunta";
                            break;

                        default:
                            MessageBox.Show("Sem frase\nNumeração: " + i);
                            break;
                    }

                    break;

                case "Errou":

                    int ii = random.Next(1, 4);

                    switch (ii)
                    {
                        case 1:
                            lblTotalPessoasQuestao3.Text = Estatico.ERROSQUEST3 + " Pessoa(s) erraram esta questão";
                            break;

                        case 2:
                            lblTotalPessoasQuestao3.Text = "Não se preocupe, " + Estatico.ERROSQUEST3 + " pessoa(s) tambem erraram";
                            break;

                        case 3:
                            double porcentagem = Math.Round((double)Estatico.ERROSQUEST3 / Estatico.TOTALRESPOSTASQUEST3 * 100, 1);
                            lblTotalPessoasQuestao3.Text = porcentagem + "% das pessoas que passaram por esta pergunta, erraram";
                            break;

                        default:
                            MessageBox.Show("Sem frase\nNumeração: " + ii);
                            break;
                    }

                    break;

            }

            switch (pergunta4)
            {
                case "Acertou":

                    int i = random.Next(1, 4);

                    switch (i)
                    {
                        case 1:
                            lblTotalPessoasQuestao4.Text = Estatico.ACERTOSQUEST4 + " Pessoa(s) acertaram esta questão, você esta é uma delas";
                            break;

                        case 2:
                            lblTotalPessoasQuestao4.Text = "Você esta entre " + Estatico.ACERTOSQUEST4 + " das pessoa(s) que acertaram essa pergunta";
                            break;

                        case 3:
                            double porcentagem = Math.Round((double)Estatico.ACERTOSQUEST4 / Estatico.TOTALRESPOSTASQUEST4 * 100, 1);
                            lblTotalPessoasQuestao4.Text = "Você esta entre os " + porcentagem + "% que acertaram esta pergunta";
                            break;

                        default:
                            MessageBox.Show("Sem frase\nNumeração: " + i);
                            break;
                    }

                    break;

                case "Errou":

                    int ii = random.Next(1, 4);

                    switch (ii)
                    {
                        case 1:
                            lblTotalPessoasQuestao4.Text = Estatico.ERROSQUEST4 + " Pessoa(s) erraram esta questão";
                            break;

                        case 2:
                            lblTotalPessoasQuestao4.Text = "Não se preocupe, " + Estatico.ERROSQUEST4 + " pessoa(s) tambem erraram";
                            break;

                        case 3:
                            double porcentagem = Math.Round((double)Estatico.ERROSQUEST4 / Estatico.TOTALRESPOSTASQUEST4 * 100, 1);
                            lblTotalPessoasQuestao4.Text = porcentagem + "% das pessoas que passaram por esta pergunta, erraram";
                            break;

                        default:
                            MessageBox.Show("Sem frase\nNumeração: " + ii);
                            break;
                    }

                    break;

            }

            switch (pergunta5)
            {
                case "Acertou":

                    int i = random.Next(1, 4);

                    switch (i)
                    {
                        case 1:
                            lblTotalPessoasQuestao5.Text = Estatico.ACERTOSQUEST5 + " Pessoa(s) acertaram esta questão, você esta é uma delas";
                            break;

                        case 2:
                            lblTotalPessoasQuestao5.Text = "Você esta entre " + Estatico.ACERTOSQUEST5 + " das pessoa(s) que acertaram essa pergunta";
                            break;

                        case 3:
                            double porcentagem = Math.Round((double)Estatico.ACERTOSQUEST5 / Estatico.TOTALRESPOSTASQUEST5 * 100, 1);
                            lblTotalPessoasQuestao5.Text = "Você esta entre os " + porcentagem + "% que acertaram esta pergunta";
                            break;

                        default:
                            MessageBox.Show("Sem frase\nNumeração: " + i);
                            break;
                    }

                    break;

                case "Errou":

                    int ii = random.Next(1, 4);

                    switch (ii)
                    {
                        case 1:
                            lblTotalPessoasQuestao5.Text = Estatico.ERROSQUEST5 + " Pessoa(s) erraram esta questão";
                            break;

                        case 2:
                            lblTotalPessoasQuestao5.Text = "Não se preocupe, " + Estatico.ERROSQUEST5 + " pessoa(s) tambem erraram";
                            break;

                        case 3:
                            double porcentagem = Math.Round((double)Estatico.ERROSQUEST5 / Estatico.TOTALRESPOSTASQUEST5 * 100, 1);
                            lblTotalPessoasQuestao5.Text = porcentagem + "% das pessoas que passaram por esta pergunta, erraram";
                            break;

                        default:
                            MessageBox.Show("Sem frase\nNumeração: " + ii);
                            break;
                    }

                    break;

            }

        }

        public void ProximaPagina()
        {
            switch (pagina)
            {
                case 1:

                    lblSuasRespostas.Visible = true;

                    lblPerguntaNumeracao1.Visible = true;
                    lblPerguntaNumeracao2.Visible = true;
                    lblPerguntaNumeracao3.Visible = true;
                    lblPerguntaNumeracao4.Visible = true;
                    lblPerguntaNumeracao5.Visible = true;


                    lblRespostaUsuario1.Visible = true;
                    lblRespostaUsuario2.Visible = true;
                    lblRespostaUsuario3.Visible = true;
                    lblRespostaUsuario4.Visible = true;
                    lblRespostaUsuario5.Visible = true;


                    lblEstatisticas.Visible = false;


                    lblTotalPessoasQuestao1.Visible = false;
                    lblTotalPessoasQuestao2.Visible = false;
                    lblTotalPessoasQuestao3.Visible = false;
                    lblTotalPessoasQuestao4.Visible = false;
                    lblTotalPessoasQuestao5.Visible = false;


                    lblTotalAcertos.Visible = false;
                    lblTotalErros.Visible = false;

                    break;

                case 2:

                    lblSuasRespostas.Visible = false;

                    lblPerguntaNumeracao1.Visible = true;
                    lblPerguntaNumeracao2.Visible = true;
                    lblPerguntaNumeracao3.Visible = true;
                    lblPerguntaNumeracao4.Visible = true;
                    lblPerguntaNumeracao5.Visible = true;

                    lblPerguntaNumeracao1.Location = new Point(12, 84);
                    lblPerguntaNumeracao2.Location = new Point(12, 156);
                    lblPerguntaNumeracao3.Location = new Point(12, 229);
                    lblPerguntaNumeracao4.Location = new Point(12, 301);
                    lblPerguntaNumeracao5.Location = new Point(12, 377);


                    lblRespostaUsuario1.Visible = false;
                    lblRespostaUsuario2.Visible = false;
                    lblRespostaUsuario3.Visible = false;
                    lblRespostaUsuario4.Visible = false;
                    lblRespostaUsuario5.Visible = false;


                    lblRespostaCerta1.Visible = false;
                    lblRespostaCerta2.Visible = false;
                    lblRespostaCerta3.Visible = false;
                    lblRespostaCerta4.Visible = false;
                    lblRespostaCerta5.Visible = false;


                    lblEstatisticas.Visible = true;
                    lblEstatisticas.Location = new Point(12, 9);


                    lblTotalPessoasQuestao1.Visible = true;
                    lblTotalPessoasQuestao2.Visible = true;
                    lblTotalPessoasQuestao3.Visible = true;
                    lblTotalPessoasQuestao4.Visible = true;
                    lblTotalPessoasQuestao5.Visible = true;

                    lblTotalPessoasQuestao1.Location = new Point(91, 84 + 15);
                    lblTotalPessoasQuestao2.Location = new Point(91, 156 + 15);
                    lblTotalPessoasQuestao3.Location = new Point(91, 229 + 15);
                    lblTotalPessoasQuestao4.Location = new Point(91, 301 + 15);
                    lblTotalPessoasQuestao5.Location = new Point(91, 377 + 15);


                    lblTotalAcertos.Visible = true;
                    lblTotalErros.Visible = true;

                    lblTotalAcertos.Location = new Point(12, 535);
                    lblTotalErros.Location = new Point(12, 625);

                    break;

                default:
                    this.Close();
                    break;
            }
        }
        private void pbxBotaoContinuar_Click(object sender, EventArgs e)
        {
            ResetTimer();
            pagina++;
            ProximaPagina();
        }

        public void ResetTimer()
        {
            tmrTempoAusencia.Enabled = false;
            tmrTempoAusencia.Enabled = true;
        }

        private void tmrTempoAusencia_Tick(object sender, EventArgs e)
        {
            pagina++;
            ProximaPagina();
        }

        private void Estatisticas_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }
    }
}
