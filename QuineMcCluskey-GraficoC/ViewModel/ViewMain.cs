using System.Collections.Generic;

namespace QuineMcCluskey_GraficoC.ViewModel
{
    class ViewMain
    {
        public static int numVariaveis = 0;

        public static List<Mintermo> CarregarMintermosDoTXT(string caminhoArquivo)
        {
            ArquivoTXT arquivo = new ArquivoTXT(caminhoArquivo);

            List<Mintermo> ColunaMintermos = arquivo.CarregarMintermos();

            numVariaveis = arquivo.PegarNumeroVariaveis();

            return ColunaMintermos;
        }
    }
}
