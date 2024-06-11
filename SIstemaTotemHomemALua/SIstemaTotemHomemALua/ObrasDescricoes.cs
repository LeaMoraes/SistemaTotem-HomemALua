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
    public partial class ObrasDescricoes : Form
    {
        public ObrasDescricoes(int id)
        {
            InitializeComponent();
            AtualizarTela(id);
        }

        public void ResetTimer()
        {
            tmrTempoAusencia.Enabled = false;
            tmrTempoAusencia.Enabled = true;
        }


        public void AtualizarTela(int id)
        {

            switch (id)
            {
                case 1:
                    pcbObraImagem.ImageLocation = "Imagens/Obras/Astronauta Neil Armstrong.jpg";
                    lblObraTitulo.Text = "Astronauta Neil Armstrong";
                    lblObraDescricao.Text = "Neil Armstrong, vestido com seu traje espacial\nposa para seu retrato oficial da Apollo 11.";
                    break;

                case 2:
                    pcbObraImagem.ImageLocation = "Imagens/Obras/Astronauta Edwin E. Aldrin Jr.jpg";
                    lblObraTitulo.Text = "Astronauta Edwin E. Aldrin Jr";
                    lblObraDescricao.Text = "Astronauta Edwin E. Aldrin Jr. Aldrin\nfoi piloto do módulo lunar da missão de pouso lunar Apollo 11";
                    break;

                case 3:
                    pcbObraImagem.ImageLocation = "Imagens/Obras/Astronauta Michael Collins.jpg";
                    lblObraTitulo.Text = "Astronauta Michael Collins";
                    lblObraDescricao.Text = "Collins renunciou ao programa espacial da NASA\ndesde que esta foto foi tirada";
                    break;

                case 4:
                    pcbObraImagem.ImageLocation = "Imagens/Obras/A tripulação da Apollo 11.jpg";
                    lblObraTitulo.Text = "A tripulação da Apollo 11";
                    lblObraDescricao.Text = "A tripulação da Apollo 11 realiza uma verificação funcional\ne de ajuste do compartimento da tripulação, dos equipamentos\ne locais de armazenamento, em seu módulo de comando";
                    break;

                case 5:
                    pcbObraImagem.ImageLocation = "Imagens/Obras/Saturn V Ventures.jpg";
                    lblObraTitulo.Text = "Saturn V Venture";
                    lblObraDescricao.Text = "Carregando o foguete Apollo 11 Saturn V e o lançador móvel\no rastreador avança lentamente ao longo da jornada de cinco quilômetros\naté a plataforma de lançamento 39A";
                    break;

                case 6:
                    pcbObraImagem.ImageLocation = "Imagens/Obras/Programa Saturno Apollo.jpg";
                    lblObraTitulo.Text = "Programa Saturno Apollo";
                    lblObraDescricao.Text = "Esta fotografia mostra o veículo de lançamento Saturn V (SA-506)\npara a decolagem da missão Apollo 11 às 8h32 CDT, 16 de julho de 1969\ndo complexo de lançamento 39A no Centro Espacial Kennedy";
                    break;

                case 7:
                    pcbObraImagem.ImageLocation = "Imagens/Obras/Módulo Lunar Apollo.jpg";
                    lblObraTitulo.Text = "Módulo Lunar Apollo";
                    lblObraDescricao.Text = "O estágio de subida do Módulo Lunar da Apollo 11, com os astronautas\nNeil A. Armstrong e Edwin E. Aldrin Jr. a bordo\né fotografado dos Módulos de Comando e Serviço (CSM)\ndurante o encontro na órbita lunar";
                    break;

                case 8:
                    pcbObraImagem.ImageLocation = "Imagens/Obras/Módulo Lunar da Apollo 11 na superfície lunar.jpg";
                    lblObraTitulo.Text = "Módulo Lunar da Apollo 11 na superfice lunar";
                    lblObraDescricao.Text = "O astronauta Edwin E. Aldrin Jr., piloto do módulo lunar\nse prepara para implantar o\nEarly Apollo Scientific Experiments Package (EASEP)\ndurante a atividade extraveicular da superfície lunar (EVA) da Apollo 11";
                    break;

                case 9:
                    pcbObraImagem.ImageLocation = "Imagens/Obras/Pegada no solo lunar.jpg";
                    lblObraTitulo.Text = "Pegada no solo lunar";
                    lblObraDescricao.Text = "Uma visão aproximada da bota e da pegada de um astronauta no solo lunar\nfotografada com uma câmera de superfície lunar de 70 mm\ndurante a atividade extraveicular da superfície lunar (EVA) da Apollo 11";
                    break;

                case 10:
                    pcbObraImagem.ImageLocation = "Imagens/Obras/Vista da lua.jpg";
                    lblObraTitulo.Text = "Vista da lua";
                    lblObraDescricao.Text = "Esta vista da espaçonave Apollo 11 mostra a Terra elevando-se\nacima do horizonte da lua. O terreno lunar retratado está na área do\nMar de Smyth, no lado mais próximo";
                    break;

                default:
                    MessageBox.Show("Nenhuma Obra Selecionada, Selecione uma!!");
                    this.Close();
                    break;
            }

        }

        private void pbxBotaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrTempoAusencia_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ObrasDescricoes_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void lblObraDescricao_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void pcbObraImagem_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void lblObraTitulo_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }
    }
}
