namespace SIstemaTotemHomemALua.Modelos
{
    internal class Validacao
    {

        private string mensagem = "";



        public int ValidarResposta(int idPergunta, string Resposta)
        {

            switch (idPergunta)
            {

                case 1:
                    Estatico.TEMPRESPOSTAQUEST1 = Resposta;
                    if (Resposta.Equals("D) 1969"))
                    {
                        return 1;
                    }

                    break;

                case 2:
                    Estatico.TEMPRESPOSTAQUEST2 = Resposta;
                    if (Resposta.Equals("C) Saturn V"))
                    {
                        return 1;
                    }
                    break;

                case 3:
                    Estatico.TEMPRESPOSTAQUEST3 = Resposta;
                    if (Resposta.Equals("A) Edwin E. Aldrin Jr."))
                    {
                        return 1;
                    }
                    break;

                case 4:
                    Estatico.TEMPRESPOSTAQUEST4 = Resposta;
                    if (Resposta.Equals("B) Early Apollo Scientific Experiments Package"))
                    {
                        return 1;
                    }
                    break;

                case 5:
                    Estatico.TEMPRESPOSTAQUEST5 = Resposta;
                    if (Resposta.Equals("C) Michael Collins"))
                    {
                        return 1;
                    }
                    break;

                default:

                    break;

            }

            return 0;

        }

        public void ValidarNome(string nome)
        {
            mensagem = "";
            if (!nome.Equals(""))
            {
                Estatico.NOMEUSUARIO = nome;
            }
            else
            {
                mensagem = "Inserir Nome";
            }

        }
        public void ValidarIdade(string idade)
        {
            mensagem = "";
            if (!idade.Equals(""))
            {
                try
                {
                    Estatico.IDADEUSUARIO = Convert.ToInt32(idade);
                }
                catch (Exception e)
                {
                    mensagem = "Inserir Somente Numero";
                }
            }
            else
            {
                mensagem = "Inserir Idade";
            }
        }

        public string Mensagem { get => mensagem; }
    }
}
