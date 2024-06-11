using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using SIstemaTotemHomemALua.Modelos;

namespace SIstemaTotemHomemALua
{
    public partial class Form1 : Form
    {

        public GerenciadorUsuarios gerUsuarios;
        public Relatorio rel;
        public Form1()
        {
            InitializeComponent();
            gerUsuarios = new GerenciadorUsuarios();
            gerUsuarios.Show();
            gerUsuarios.Visible = false;
        }

        string caminhoDiretorio = @"C:\LIT\BancoDeDados";
        string caminhoArquivo = @"C:\LIT\BancoDeDados\usuarios.json";

        private void pcbObras_Click(object sender, EventArgs e)
        {
            ListaObras listaObras = new ListaObras();
            listaObras.ShowDialog();
            this.Visible = true;
        }

        private void pcbQuestionario_Click(object sender, EventArgs e)
        {
            Questionario questionario = new Questionario();
            questionario.ShowDialog();

            if (questionario.mensagemForm1.Equals("Armazenar"))
            {

                gerUsuarios.AdicionarPessoa(questionario.mensagemForm1, Estatico.NOMEUSUARIO, Estatico.IDADEUSUARIO, Estatico.QUESTIONARIOUOTAUSUARIO, Estatico.COMENTARIOUSUARIO);
                gerUsuarios.SalvarSerializar(caminhoDiretorio, caminhoArquivo);
                Estatisticas estatisticas = new Estatisticas();
                estatisticas.ShowDialog();
                TabelaDeLideranca tabLideranca = new TabelaDeLideranca(caminhoArquivo);
                tabLideranca.ShowDialog();
            }

            this.Visible = true;
        }

        private void pcbMapa_Click(object sender, EventArgs e)
        {
            Mapa mapa = new Mapa();
            mapa.ShowDialog();
            this.Visible = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                rel = new Relatorio(caminhoArquivo);
                rel.ShowDialog();
                if (rel.mensagemForm1.Equals("FinalizarSistema"))
                {
                    this.Close();
                }
            }
        }

        private void pcbPreencherTabela_Click(object sender, EventArgs e)
        {
            gerUsuarios.AdicionarPessoaPreencherTabela("Isac", 21, 4, "Achei Fraco, me traga algo mais desafiador");
            gerUsuarios.AdicionarPessoaPreencherTabela("Thais", 25, 3, "LEGAL");
            gerUsuarios.AdicionarPessoaPreencherTabela("Roberta", 20, 4, "Muito bom as obras");
            gerUsuarios.AdicionarPessoaPreencherTabela("Waldir", 98, 5, "Bom, isso me lembra quando o apollo 11 veio para o Brasil");
            gerUsuarios.AdicionarPessoaPreencherTabela("Sophia Morelli", 15, 4, "Achei divertido demais");
            gerUsuarios.AdicionarPessoaPreencherTabela("Roger", 33, 3, "Muito informativo");
            gerUsuarios.AdicionarPessoaPreencherTabela("Julia Pereira", 16, 2, "Tipo, achei legal sabe");
            gerUsuarios.AdicionarPessoaPreencherTabela("Luiza", 14, 0, "");
            gerUsuarios.AdicionarPessoaPreencherTabela("Ana", 17, 1, "");
            gerUsuarios.AdicionarPessoaPreencherTabela("Richard", 20, 1, "Achei as perguntas dificil demais");
            gerUsuarios.AdicionarPessoaPreencherTabela("Sofia Guedes", 15, 0, "");
            gerUsuarios.AdicionarPessoaPreencherTabela("Paula", 42, 5, "Interessante");
            gerUsuarios.AdicionarPessoaPreencherTabela("Renata Assumpção", 45, 4, "");

            Estatico.SOMATOTALQUALIDADEOBRAS += 64;
            Estatico.NUMEROAVALIACOESQUALIDADEOBRAS += 14;

            Estatico.SOMATOTALVISITAMUSEU += 57;
            Estatico.NUMEROAVALIACOESVISITAMUSEU += 14;

            Estatico.SOMATOTALRECOMENDACAO = 61;
            Estatico.NUMEROAVALIACOESRECOMENDACAO += 14;            

            Estatico.ACERTOSQUEST1 += 5;
            Estatico.ACERTOSQUEST2 += 9;
            Estatico.ACERTOSQUEST3 += 4;
            Estatico.ACERTOSQUEST4 += 8;
            Estatico.ACERTOSQUEST5 += 8;

            Estatico.ERROSQUEST1 += 9;
            Estatico.ERROSQUEST2 += 5;
            Estatico.ERROSQUEST3 += 10;
            Estatico.ERROSQUEST4 += 6;
            Estatico.ERROSQUEST5 += 6;

            Estatico.TOTALRESPOSTASQUEST1 += Estatico.ACERTOSQUEST1 + Estatico.ERROSQUEST1;
            Estatico.TOTALRESPOSTASQUEST2 += Estatico.ACERTOSQUEST2 + Estatico.ERROSQUEST2;
            Estatico.TOTALRESPOSTASQUEST3 += Estatico.ACERTOSQUEST3 + Estatico.ERROSQUEST3;
            Estatico.TOTALRESPOSTASQUEST4 += Estatico.ACERTOSQUEST4 + Estatico.ERROSQUEST4;
            Estatico.TOTALRESPOSTASQUEST5 += Estatico.ACERTOSQUEST5 + Estatico.ERROSQUEST5;

            Estatico.TOTALERROS = Estatico.ERROSQUEST1 + Estatico.ERROSQUEST2 + Estatico.ERROSQUEST3 + Estatico.ERROSQUEST4 + Estatico.ERROSQUEST5;
            Estatico.TOTALACERTOS = Estatico.ACERTOSQUEST1 + Estatico.ACERTOSQUEST2 + Estatico.ACERTOSQUEST3 + Estatico.ACERTOSQUEST4 + Estatico.ACERTOSQUEST5;

            gerUsuarios.SalvarSerializar(caminhoDiretorio, caminhoArquivo);

            pcbPreencherTabela.Visible = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete(caminhoArquivo);
        }

        
    }
}
