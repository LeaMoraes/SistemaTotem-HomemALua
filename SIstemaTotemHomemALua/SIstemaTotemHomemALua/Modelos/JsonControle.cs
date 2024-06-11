using Newtonsoft.Json;


namespace SIstemaTotemHomemALua.Modelos
{
    internal sealed class JsonControle
    {


        public List<Usuarios> DeserializarLista(string caminhoArquivo)
        {
            string json = File.ReadAllText(caminhoArquivo);
            return JsonConvert.DeserializeObject<List<Usuarios>>(json);
            return null;
        }

        public void SerializarLista(List<Usuarios> usuarios, string caminhoDiretorio, string caminhoArquivo)
        {
            if (Directory.Exists(caminhoDiretorio))
            {
                try
                {
                    var strJson = JsonConvert.SerializeObject(usuarios, Formatting.Indented);
                    SalvarArquivo(strJson, caminhoArquivo);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro na função de SerializarLista");
                }
            }
            else
            {
                Directory.CreateDirectory(caminhoDiretorio);
                SerializarLista(usuarios, caminhoDiretorio, caminhoArquivo);
            }
        }

        public void SalvarArquivo(string strJson, string caminhoArquivo)
        {
            try
            {
                File.WriteAllText(caminhoArquivo, strJson);
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro na função SalvarArquivo");
            }

        }

    }
}
