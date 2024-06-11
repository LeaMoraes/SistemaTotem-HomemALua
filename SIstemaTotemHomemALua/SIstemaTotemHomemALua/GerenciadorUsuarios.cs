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
    public partial class GerenciadorUsuarios : Form
    {

        List<Usuarios> usuarios = new List<Usuarios>();

        public GerenciadorUsuarios()
        {
            InitializeComponent();
            dgvDev.DataSource = usuarios;

            //Codigo para preencher a tabela para a apresentação

            if (File.Exists(@"C:\LIT\BancoDeDados\usuarios.json"))
            {
                JsonControle jsonControle = new JsonControle();
                usuarios = jsonControle.DeserializarLista(@"C:\LIT\BancoDeDados\usuarios.json");
                dgvDev.DataSource = null;
                dgvDev.DataSource = usuarios;
            }


        }

        public void AdicionarPessoaPreencherTabela(string nome, int idade, int questionarioNota, string comentario)
        {
                usuarios.Add(new Usuarios() { Nome = nome, Idade = idade, QuestionarioNota = questionarioNota, Comentario = comentario });

                usuarios = usuarios.OrderByDescending(u => u.QuestionarioNota).ToList();
                for (int i = 0; i < usuarios.Count; i++)
                {
                    usuarios[i].Posicao = i;
                }

                dgvDev.DataSource = null;
                dgvDev.DataSource = usuarios;
        }

        public void AdicionarPessoa(string mensagemForm1, string nome, int idade, int questionarioNota, string comentario)
        {
            if (mensagemForm1.Equals("Armazenar"))
            {                
                usuarios.Add(new Usuarios() { Nome = nome, Idade = idade, QuestionarioNota = questionarioNota, Comentario = comentario });
                ArmazenarEstatisticas();

                usuarios = usuarios.OrderByDescending(u => u.QuestionarioNota).ToList();
                for (int i = 0; i < usuarios.Count; i++)
                {
                    usuarios[i].Posicao = i;
                }

                dgvDev.DataSource = null;
                dgvDev.DataSource = usuarios;

            }
        }

        public void ArmazenarEstatisticas()
        {

            //Armazenar diferentes notas de avaliação ao museu

            Estatico.TOTALRESPOSTASQUEST1 += Estatico.TEMPACERTOSQUEST1 + Estatico.TEMPERROSQUEST1;
            Estatico.TOTALRESPOSTASQUEST2 += Estatico.TEMPACERTOSQUEST2 + Estatico.TEMPERROSQUEST2;
            Estatico.TOTALRESPOSTASQUEST3 += Estatico.TEMPACERTOSQUEST3 + Estatico.TEMPERROSQUEST3;
            Estatico.TOTALRESPOSTASQUEST4 += Estatico.TEMPACERTOSQUEST4 + Estatico.TEMPERROSQUEST4;
            Estatico.TOTALRESPOSTASQUEST5 += Estatico.TEMPACERTOSQUEST5 + Estatico.TEMPERROSQUEST5;

            Estatico.ACERTOSQUEST1 += Estatico.TEMPACERTOSQUEST1;
            Estatico.ACERTOSQUEST2 += Estatico.TEMPACERTOSQUEST2;
            Estatico.ACERTOSQUEST3 += Estatico.TEMPACERTOSQUEST3;
            Estatico.ACERTOSQUEST4 += Estatico.TEMPACERTOSQUEST4;
            Estatico.ACERTOSQUEST5 += Estatico.TEMPACERTOSQUEST5;

            Estatico.ERROSQUEST1 += Estatico.TEMPERROSQUEST1;
            Estatico.ERROSQUEST2 += Estatico.TEMPERROSQUEST2;
            Estatico.ERROSQUEST3 += Estatico.TEMPERROSQUEST3;
            Estatico.ERROSQUEST4 += Estatico.TEMPERROSQUEST4;
            Estatico.ERROSQUEST5 += Estatico.TEMPERROSQUEST5;

            Estatico.TOTALERROS = Estatico.ERROSQUEST1 + Estatico.ERROSQUEST2 + Estatico.ERROSQUEST3 + Estatico.ERROSQUEST4 + Estatico.ERROSQUEST5;
            Estatico.TOTALACERTOS = Estatico.ACERTOSQUEST1 + Estatico.ACERTOSQUEST2 + Estatico.ACERTOSQUEST3 + Estatico.ACERTOSQUEST4 + Estatico.ACERTOSQUEST5;

        }

        public void SalvarSerializar(string caminhoDiretorio, string caminhoArquivo)
        {
            JsonControle jsonControle = new JsonControle();
            jsonControle.SerializarLista(usuarios, caminhoDiretorio, caminhoArquivo);
        }

    }
}
