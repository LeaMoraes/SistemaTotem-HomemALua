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
    public partial class RelatorioPerguntas : Form
    {
        public RelatorioPerguntas()
        {
            InitializeComponent();
            AtualizarInformacoes();
        }

        public void AtualizarInformacoes()
        {
            lblTotalRespostas1.Text += Estatico.TOTALRESPOSTASQUEST1;
            lblTotalAcertos1.Text += Estatico.ACERTOSQUEST1;
            lblTotalErros1.Text += Estatico.ERROSQUEST1;
            if (Estatico.ACERTOSQUEST1.Equals(0) && Estatico.ERROSQUEST1.Equals(0))
            {
                lblRecado1.Text = "Não tivemos nenhuma resposta";
            }
            else if (Estatico.ACERTOSQUEST1.Equals(0) && Estatico.ACERTOSQUEST1 < Estatico.ERROSQUEST1)
            {
                lblRecado1.Text = "Somente respostas erradas\ntalvez estejam\ncom dificuldade";
            }
            else if (Estatico.ACERTOSQUEST1 > Estatico.ERROSQUEST1 && Estatico.ERROSQUEST1.Equals(0))
            {
                lblRecado1.Text = "Somente respostas certas \ntalvez acharam\nfacil demais";
            }
            else if (Estatico.ACERTOSQUEST1 > Estatico.ERROSQUEST1)
            {
                lblRecado1.Text = "As pessoas tiveram mais\nfacilidade com esta questão";
            }
            else if (Estatico.ACERTOSQUEST1 < Estatico.ERROSQUEST1)
            {
                lblRecado1.Text = "As pessoas tiveram mais\ndificuldade com esta questão";
            }

            else if (Estatico.ACERTOSQUEST1 == Estatico.ERROSQUEST1)
            {
                lblRecado1.Text = "Equilibrio nas respostas";
            }
            else
            {
                lblRecado1.Text = "Algo de errado, não esta certo";
            }

            lblTotalRespostas2.Text += Estatico.TOTALRESPOSTASQUEST2;
            lblTotalAcertos2.Text += Estatico.ACERTOSQUEST2;
            lblTotalErros2.Text += Estatico.ERROSQUEST2;
            if (Estatico.ACERTOSQUEST2.Equals(0) && Estatico.ERROSQUEST2.Equals(0))
            {
                lblRecado2.Text = "Não tivemos nenhuma resposta";
            }
            else if (Estatico.ACERTOSQUEST2.Equals(0) && Estatico.ACERTOSQUEST2 < Estatico.ERROSQUEST2)
            {
                lblRecado2.Text = "Somente respostas erradas\ntalvez estejam\ncom dificuldade";
            }
            else if (Estatico.ACERTOSQUEST2 > Estatico.ERROSQUEST2 && Estatico.ERROSQUEST2.Equals(0))
            {
                lblRecado2.Text = "Somente respostas certas \ntalvez acharam\nfacil demais";
            }
            else if (Estatico.ACERTOSQUEST2 > Estatico.ERROSQUEST2)
            {
                lblRecado2.Text = "As pessoas tiveram mais\nfacilidade com esta questão";
            }
            else if (Estatico.ACERTOSQUEST2 < Estatico.ERROSQUEST2)
            {
                lblRecado2.Text = "As pessoas tiveram mais\ndificuldade com esta questão";
            }

            else if (Estatico.ACERTOSQUEST2 == Estatico.ERROSQUEST2)
            {
                lblRecado2.Text = "Equilibrio nas respostas";
            }
            else
            {
                lblRecado2.Text = "Algo de errado, não esta certo";
            }

            lblTotalRespostas3.Text += Estatico.TOTALRESPOSTASQUEST3;
            lblTotalAcertos3.Text += Estatico.ACERTOSQUEST3;
            lblTotalErros3.Text += Estatico.ERROSQUEST3;
            if (Estatico.ACERTOSQUEST3.Equals(0) && Estatico.ERROSQUEST3.Equals(0))
            {
                lblRecado3.Text = "Não tivemos nenhuma resposta";
            }
            else if (Estatico.ACERTOSQUEST3.Equals(0) && Estatico.ACERTOSQUEST3 < Estatico.ERROSQUEST3)
            {
                lblRecado3.Text = "Somente respostas erradas\ntalvez estejam\ncom dificuldade";
            }
            else if (Estatico.ACERTOSQUEST3 > Estatico.ERROSQUEST3 && Estatico.ERROSQUEST3.Equals(0))
            {
                lblRecado3.Text = "Somente respostas certas \ntalvez acharam\nfacil demais";
            }
            else if (Estatico.ACERTOSQUEST3 > Estatico.ERROSQUEST3)
            {
                lblRecado3.Text = "As pessoas tiveram mais\nfacilidade com esta questão";
            }
            else if (Estatico.ACERTOSQUEST3 < Estatico.ERROSQUEST3)
            {
                lblRecado3.Text = "As pessoas tiveram mais\ndificuldade com esta questão";
            }

            else if (Estatico.ACERTOSQUEST3 == Estatico.ERROSQUEST3)
            {
                lblRecado3.Text = "Equilibrio nas respostas";
            }
            else
            {
                lblRecado3.Text = "Algo de errado, não esta certo";
            }

            lblTotalRespostas4.Text += Estatico.TOTALRESPOSTASQUEST4;
            lblTotalAcertos4.Text += Estatico.ACERTOSQUEST4;
            lblTotalErros4.Text += Estatico.ERROSQUEST4;
            if (Estatico.ACERTOSQUEST4.Equals(0) && Estatico.ERROSQUEST4.Equals(0))
            {
                lblRecado4.Text = "Não tivemos nenhuma resposta";
            }
            else if (Estatico.ACERTOSQUEST4.Equals(0) && Estatico.ACERTOSQUEST4 < Estatico.ERROSQUEST4)
            {
                lblRecado4.Text = "Somente respostas erradas\ntalvez estejam\ncom dificuldade";
            }
            else if (Estatico.ACERTOSQUEST4 > Estatico.ERROSQUEST4 && Estatico.ERROSQUEST4.Equals(0))
            {
                lblRecado4.Text = "Somente respostas certas \ntalvez acharam\nfacil demais";
            }
            else if (Estatico.ACERTOSQUEST4 > Estatico.ERROSQUEST4)
            {
                lblRecado4.Text = "As pessoas tiveram mais\nfacilidade com esta questão";
            }
            else if (Estatico.ACERTOSQUEST4 < Estatico.ERROSQUEST4)
            {
                lblRecado4.Text = "As pessoas tiveram mais\ndificuldade com esta questão";
            }

            else if (Estatico.ACERTOSQUEST4 == Estatico.ERROSQUEST4)
            {
                lblRecado4.Text = "Equilibrio nas respostas";
            }
            else
            {
                lblRecado4.Text = "Algo de errado, não esta certo";
            }

            lblTotalRespostas5.Text += Estatico.TOTALRESPOSTASQUEST5;
            lblTotalAcertos5.Text += Estatico.ACERTOSQUEST5;
            lblTotalErros5.Text += Estatico.ERROSQUEST5;
            if (Estatico.ACERTOSQUEST5.Equals(0) && Estatico.ERROSQUEST5.Equals(0))
            {
                lblRecado5.Text = "Não tivemos nenhuma resposta";
            }
            else if (Estatico.ACERTOSQUEST5.Equals(0) && Estatico.ACERTOSQUEST5 < Estatico.ERROSQUEST5)
            {
                lblRecado5.Text = "Somente respostas erradas\ntalvez estejam\ncom dificuldade";
            }
            else if (Estatico.ACERTOSQUEST5 > Estatico.ERROSQUEST5 && Estatico.ERROSQUEST5.Equals(0))
            {
                lblRecado5.Text = "Somente respostas certas \ntalvez acharam\nfacil demais";
            }
            else if (Estatico.ACERTOSQUEST5 > Estatico.ERROSQUEST5)
            {
                lblRecado5.Text = "As pessoas tiveram mais\nfacilidade com esta questão";
            }
            else if (Estatico.ACERTOSQUEST5 < Estatico.ERROSQUEST5)
            {
                lblRecado5.Text = "As pessoas tiveram mais\ndificuldade com esta questão";
            }
            
            else if (Estatico.ACERTOSQUEST5 == Estatico.ERROSQUEST5)
            {
                lblRecado5.Text = "Equilibrio nas respostas";
            }
            else
            {
                lblRecado5.Text = "Algo de errado, não esta certo";
            }

            lblTotalAcertadas.Text += Estatico.TOTALACERTOS;
            lblTotalErradas.Text += Estatico.TOTALERROS;
        }



        private void pbxBotaoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
