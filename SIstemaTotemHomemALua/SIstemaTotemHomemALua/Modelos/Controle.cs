namespace SIstemaTotemHomemALua.Modelos
{
    internal class Controle
    {

        private string mensagem = "";
        private string mensagemForm1 = "";

        public void ValidarResposta(int idPergunta, string Resposta)
        {
            Validacao validacao = new Validacao();
            int i = validacao.ValidarResposta(idPergunta, Resposta);
            switch (i)
            {
                case 0:
                    switch (idPergunta)
                    {
                        case 1:
                            Estatico.TEMPERROSQUEST1 = 1;
                            break;

                        case 2:
                            Estatico.TEMPERROSQUEST2 = 1;
                            break;

                        case 3:
                            Estatico.TEMPERROSQUEST3 = 1;
                            break;

                        case 4:
                            Estatico.TEMPERROSQUEST4 = 1;
                            break;

                        case 5:
                            Estatico.TEMPERROSQUEST5 = 1;
                            break;
                    }
                    break;

                case 1:
                    Estatico.QUESTIONARIOUOTAUSUARIO += i;
                    switch (idPergunta)
                    {
                        case 1:
                            Estatico.TEMPACERTOSQUEST1 = 1;
                            break;

                        case 2:
                            Estatico.TEMPACERTOSQUEST2 = 1;
                            break;

                        case 3:
                            Estatico.TEMPACERTOSQUEST3 = 1;
                            break;

                        case 4:
                            Estatico.TEMPACERTOSQUEST4 = 1;
                            break;

                        case 5:
                            Estatico.TEMPACERTOSQUEST5 = 1;
                            break;
                    }
                    break;
            }
            
        }

        public void ArmazenarNomeIdade(string usuarioNome, string usuarioIdade)
        {
            mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarNome(usuarioNome);
            if (!validacao.Mensagem.Equals(""))
            {
                mensagem = validacao.Mensagem;
            }
            else
            {
                validacao.ValidarIdade(usuarioIdade);
                if (!validacao.Mensagem.Equals(""))
                {
                    mensagem = validacao.Mensagem;
                }
            }
        }

        public void ArmazenarAvaliacoesComentario(int notaQualidadeObras, int notaVisitaMuseu, int notaRecomendacao, string usuarioComentario)
        {

            Estatico.SOMATOTALQUALIDADEOBRAS += notaQualidadeObras;
            Estatico.NUMEROAVALIACOESQUALIDADEOBRAS++;

            Estatico.SOMATOTALVISITAMUSEU += notaVisitaMuseu;
            Estatico.NUMEROAVALIACOESVISITAMUSEU++;

            Estatico.SOMATOTALRECOMENDACAO += notaRecomendacao;
            Estatico.NUMEROAVALIACOESRECOMENDACAO++;

            Estatico.COMENTARIOUSUARIO = usuarioComentario;

        }

        public void ConcluirCadastro(int notaQualidadeObras, int notaVisitaMuseu, int notaRecomendacao, string usuarioComentario)
        {

            ArmazenarAvaliacoesComentario(notaQualidadeObras, notaVisitaMuseu, notaRecomendacao, usuarioComentario);
            mensagemForm1 = "Armazenar";
        }

        public string Teclado(int KeyID)
        {
            switch (KeyID)
            {
                #region Letras Maiusculas
                case 1: return "A"; break;
                case 2: return "B"; break;
                case 3: return "C"; break;
                case 4: return "D"; break;
                case 5: return "E"; break;
                case 6: return "F"; break;
                case 7: return "G"; break;
                case 8: return "H"; break;
                case 9: return "I"; break;
                case 10: return "J"; break;
                case 11: return "K"; break;
                case 12: return "L"; break;
                case 13: return "M"; break;
                case 14: return "N"; break;
                case 15: return "O"; break;
                case 16: return "P"; break;
                case 17: return "Q"; break;
                case 18: return "R"; break;
                case 19: return "S"; break;
                case 20: return "T"; break;
                case 21: return "U"; break;
                case 22: return "V"; break;
                case 23: return "W"; break;
                case 24: return "X"; break;
                case 25: return "Y"; break;
                case 26: return "Z"; break;
                #endregion

                #region Letras Minusculas
                case 27: return "a"; break;
                case 28: return "b"; break;
                case 29: return "c"; break;
                case 30: return "d"; break;
                case 31: return "e"; break;
                case 32: return "f"; break;
                case 33: return "g"; break;
                case 34: return "h"; break;
                case 35: return "i"; break;
                case 36: return "j"; break;
                case 37: return "k"; break;
                case 38: return "l"; break;
                case 39: return "m"; break;
                case 40: return "n"; break;
                case 41: return "o"; break;
                case 42: return "p"; break;
                case 43: return "q"; break;
                case 44: return "r"; break;
                case 45: return "s"; break;
                case 46: return "t"; break;
                case 47: return "u"; break;
                case 48: return "v"; break;
                case 49: return "w"; break;
                case 50: return "x"; break;
                case 51: return "y"; break;
                case 52: return "z"; break;
                #endregion

                #region Teclas Especiais
                case 53: return ","; break;
                case 54: return "."; break;
                case 55: return " "; break;
                case 56: return "Ç"; break;
                case 57: return "ç"; break;
                #endregion

                #region Numeros
                case 58: return "1"; break;
                case 59: return "2"; break;
                case 60: return "3"; break;
                case 61: return "4"; break;
                case 62: return "5"; break;
                case 63: return "6"; break;
                case 64: return "7"; break;
                case 65: return "8"; break;
                case 66: return "9"; break;
                case 67: return "0"; break;
                #endregion

                default: return " "; break;
            }

            return " ";
        }

        public string Mensagem { get => mensagem; }
        public string MensagemForm1 { get => mensagemForm1; }
    }

}



