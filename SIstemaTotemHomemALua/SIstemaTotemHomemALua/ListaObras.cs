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
    public partial class ListaObras : Form
    {
        public ListaObras()
        {
            InitializeComponent();
            MudarObras();
        }

        int paginaID = 1;
        int idQuadro1 = 1;
        int idQuadro2 = 2;


        private void pcbQuadroId1_Click(object sender, EventArgs e)
        {
            tmrTempoAusencia.Enabled = false;
            ObrasDescricoes obrasDescricoes = new ObrasDescricoes(idQuadro1);
            obrasDescricoes.ShowDialog();
            tmrTempoAusencia.Enabled = true;

        }

        private void pcbQuadroId2_Click(object sender, EventArgs e)
        {
            tmrTempoAusencia.Enabled = false;
            ObrasDescricoes obrasDescricoes = new ObrasDescricoes(idQuadro2);
            obrasDescricoes.ShowDialog();
            tmrTempoAusencia.Enabled = true;
        }


        private void pbxBotaoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ResetTimer()
        {
            tmrTempoAusencia.Enabled = false;
            tmrTempoAusencia.Enabled = true;
        }

        public void MudarPagina()
        {

            switch (paginaID)
            {

                case 1:

                    idQuadro1 = 1;
                    idQuadro2 = 2;
                    

                    MudarObras();

                    pbxBotaoPaginaUp.Visible = false;
                    pbxBotaoPaginaDown.Visible = true;


                    break;

                case 2:

                    idQuadro1 = 3;
                    idQuadro2 = 4;
                    

                    MudarObras();

                    pbxBotaoPaginaUp.Visible = true;
                    pbxBotaoPaginaDown.Visible = true;


                    break;

                case 3:

                    idQuadro1 = 5;
                    idQuadro2 = 6;
                    

                    MudarObras();

                    pbxBotaoPaginaUp.Visible = true;
                    pbxBotaoPaginaDown.Visible = true;


                    break;

                case 4:
                    idQuadro1 = 7;
                    idQuadro2 = 8;
                    MudarObras();


                    pbxBotaoPaginaUp.Visible = true;
                    pbxBotaoPaginaDown.Visible = true;
                    break;

                case 5:
                    idQuadro1 = 9;
                    idQuadro2 = 10;
                    MudarObras();

                    pbxBotaoPaginaUp.Visible = true;
                    pbxBotaoPaginaDown.Visible = false;
                    break;

                default:
                    paginaID = 1;
                    MudarPagina();
                    MudarObras();
                    MessageBox.Show("Não tem mais pagina, voltando para a pagina 1");
                    break;

            }

        }

        public void MudarObras()
        {

            switch (paginaID)
            {
                case 1:
                    pcbQuadroId1.ImageLocation = "Imagens/Obras/Astronauta Neil Armstrong.jpg";
                    pcbQuadroId2.ImageLocation = "Imagens/Obras/Astronauta Edwin E. Aldrin Jr.jpg";
                    

                    lblQuadroId1.Text = "Astronauta Neil Armstrong";
                    lblQuadroId2.Text = "Astronauta Edwin E. Aldrin Jr";                    
                    break;

                case 2:
                    pcbQuadroId1.ImageLocation = "Imagens/Obras/Astronauta Michael Collins.jpg";
                    pcbQuadroId2.ImageLocation = "Imagens/Obras/A tripulação da Apollo 11.jpg";

                    

                    lblQuadroId1.Text = "Astronauta Michael\nCollins";
                    lblQuadroId2.Text = "A tripulação da Apollo 11";                    
                    break;

                case 3:
                    pcbQuadroId1.ImageLocation = "Imagens/Obras/Saturn V Ventures.jpg";
                    pcbQuadroId2.ImageLocation = "Imagens/Obras/Programa Saturno Apollo.jpg";
                    

                    lblQuadroId1.Text = "Saturn V Venture";
                    lblQuadroId2.Text = "Programa Saturno Apollo";
                    break;

                case 4:
                    pcbQuadroId1.ImageLocation = "Imagens/Obras/Módulo Lunar Apollo.jpg";
                    pcbQuadroId2.ImageLocation = "Imagens/Obras/Módulo Lunar da Apollo 11 na superfície lunar.jpg";

                    lblQuadroId1.Text = "Módulo Lunar Apollo";
                    lblQuadroId2.Text = "Módulo Lunar da Apollo 11\nna superfice lunar";
                    break;

                case 5:
                    pcbQuadroId1.ImageLocation = "Imagens/Obras/Pegada no solo lunar.jpg";
                    pcbQuadroId2.ImageLocation = "Imagens/Obras/Vista da lua.jpg";

                    lblQuadroId1.Text = "Pegada no solo lunar";
                    lblQuadroId2.Text = "Vista da lua";
                    break;

                default:

                    break;

            }

        }

        private void pbxBotaoPaginaUp_Click(object sender, EventArgs e)
        {

            ResetTimer();

            paginaID -= 1;
            MudarPagina();
        }


        private void pbxBotaoPaginaDown_Click(object sender, EventArgs e)
        {
            ResetTimer();

            paginaID += 1;
            MudarPagina();
            
        }

        private void ListaObras_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void tmrTempoAusencia_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
