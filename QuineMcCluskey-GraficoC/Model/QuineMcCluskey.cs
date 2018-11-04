﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuineMcCluskey_GraficoC.Model
{
    class QuineMcCluskey
    {
        private static int numVariaveis;
        
        private static string logConsole = "";

        public QuineMcCluskey(int numeroVariaveis)
        {
            numVariaveis = numeroVariaveis;
        }

        public void Executa(List<Mintermo> ColunaMintermos, TextBox txtLog)
        {
            logConsole = "Algoritmo de Quine McCluskey";
            // Cria uma Coluna/lista de Mintermos ordenados por número de 1's
            List<List<Mintermo>> ColunaMintermosAgrupados = CriaMatrizColunasMintermosCheia(ColunaMintermos);

            // Cria uma Matriz Tridimensional de Colunas com Mintermos para comparações
            List<List<List<Coluna>>> MatrizColunasComparacao = CriaMatrizColunasComparacaoVazia(ColunaMintermosAgrupados); /* Aloca memória */

            // Roda o algoritmo de comparações e retorna uma lista de Expressões não simplificadas a serem transportadas para a Tabela de Cobertura
            List<Coluna> ExpressoesNaoSimplificadas = RodaAlgoritmoComparacao(ColunaMintermosAgrupados, MatrizColunasComparacao);

            // Transporta as Expressões não simplificadas para a Tabela de Cobertura e Imprime o resultado na Tela
            TransportaParaTabelaCobertura(ColunaMintermos, ExpressoesNaoSimplificadas);
            
            txtLog.Text = logConsole;
        }

        private static void ImprimeMintermosAgrupados(List<List<Mintermo>> ColunaMintermosAgrupados)
        {
            // Imprime na Tela os Conjuntos de Mintermos agrupados por quantidade de 1's 
            logConsole += Environment.NewLine;
            logConsole += Environment.NewLine;
            logConsole += "*******************************************************************";
            logConsole += Environment.NewLine;
            logConsole += "Conjuntos de Mintermos agrupados por quantidade de 1's:  0 | 1 | 2 ";

            for (int numeroMintermo = 0; numeroMintermo < ColunaMintermosAgrupados.Count; numeroMintermo++)
            {
                logConsole += Environment.NewLine;

                foreach (var mintermo in ColunaMintermosAgrupados[numeroMintermo])
                {
                    logConsole += Environment.NewLine;
                    logConsole += "'" + numeroMintermo + "' - " + mintermo.Variaveis + "(" + mintermo.Posicao + ")";
                }

            }

            logConsole += Environment.NewLine;
            logConsole += "-------------------------------------------------------------------";
        }

        private static void ImprimeMatrizColunasComparacao(List<List<List<Coluna>>> MatrizColunasComparacao)
        {
            // Imprime na Tela as Colunas de Comparação com seus Mintermos

            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            logConsole += Environment.NewLine;
            logConsole += Environment.NewLine;
            logConsole += "*******************************************************************";
            logConsole += Environment.NewLine;
            logConsole += "Colunas de Comparações por nível na Matriz:  > - > - >";

            for (int i = 0; i < MatrizColunasComparacao.Count; i++)
            {
                for (int j = 0; j < MatrizColunasComparacao[i].Count; j++)
                {

                    for (int k = 0; k < MatrizColunasComparacao[i][j].Count; k++)
                    {
                        logConsole += Environment.NewLine;
                        logConsole += alfabeto[i].ToString() + j + " - " + MatrizColunasComparacao[i][j][k].Variaveis;

                        foreach (var mintermo in MatrizColunasComparacao[i][j][k].Mintermos)
                        {
                            logConsole += " (" + mintermo + ")";
                        }
                    }

                    logConsole += Environment.NewLine;
                }

                logConsole += "-------------------------------------------------------------------";
            }

        }

        private static void ImprimeExpressoesNaoSimplificadas(List<Coluna> ExpressoesNaoSimplificadas)
        {
            // Imprime na Tela todas as Expressões não simplificadas resultante das comparações

            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            bool ehPrimeiro = true;

            logConsole += Environment.NewLine;
            logConsole += Environment.NewLine;
            logConsole += "*******************************************************************";
            logConsole += Environment.NewLine;
            logConsole += "Resultado Parcial: Expressões não simplificadas  -> ->";
            logConsole += Environment.NewLine;
            logConsole += Environment.NewLine;

            foreach (var expressao in ExpressoesNaoSimplificadas)
            {
                logConsole += expressao.Variaveis + " (";

                for (int i = 0; i < expressao.Variaveis.Length; i++)
                {
                    if (!ehPrimeiro && expressao.Variaveis[i].ToString() != "_")
                        logConsole += " + ";

                    if (expressao.Variaveis[i].ToString() != "_")
                    {
                        if (expressao.Variaveis[i].ToString() == "0")
                        {
                            ehPrimeiro = false;
                            logConsole += "!" + alfabeto[i].ToString();
                        }
                        else
                        {
                            ehPrimeiro = false;
                            logConsole += alfabeto[i].ToString();
                        }
                    }

                    if (i == expressao.Variaveis.Length - 1)
                        logConsole += ")";
                }

                ehPrimeiro = true;
                logConsole += Environment.NewLine;
            }

            ImprimeTextoTransportando();
        }

        private static void ImprimeTextoTransportando()
        {
            logConsole += Environment.NewLine;
            logConsole += "Transportando para Tabela de Cobertura:  -> -> / ->";
        }

        private static void ImprimeExpressoesSimplificadas(List<Coluna> ExpressoesSimplificadas)
        {
            // Imprime na Tela todas as Expressões simplificadas resultante do transporte da Tabela de Cobertura

            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            bool ehPrimeiro = true;

            logConsole += Environment.NewLine;
            logConsole += Environment.NewLine;
            logConsole += "Resultado Final: Expressões simplificadas  ->";
            logConsole += Environment.NewLine;
            logConsole += Environment.NewLine;

            foreach (var expressao in ExpressoesSimplificadas)
            {
                if (expressao.Marcado)
                {
                    logConsole += expressao.Variaveis + " (";

                    for (int i = 0; i < expressao.Variaveis.Length; i++)
                    {
                        if (!ehPrimeiro && expressao.Variaveis[i].ToString() != "_")
                            logConsole += " + ";

                        if (expressao.Variaveis[i].ToString() != "_")
                        {
                            if (expressao.Variaveis[i].ToString() == "0")
                            {
                                ehPrimeiro = false;
                                logConsole += "!" + alfabeto[i].ToString();
                            }
                            else
                            {
                                ehPrimeiro = false;
                                logConsole += alfabeto[i].ToString();
                            }
                        }

                        if (i == expressao.Variaveis.Length - 1)
                            logConsole += ")";
                    }

                    ehPrimeiro = true;
                    logConsole += Environment.NewLine;
                }
            }

            logConsole += "-------------------------------------------------------------------";
        }

        private static void TransportaParaTabelaCobertura(List<Mintermo> ColunaMintermos, List<Coluna> ExpressoesNaoSimplificadas)
        {
            // Coloca na Tabela de Cobertura todas as Expressões não simplificadas, e então separa aquelas que já são cobertas por outras Expressões

            List<int> TabelaCobertura = new List<int>();
            bool estaCoberto = false;

            foreach (var expressao in ExpressoesNaoSimplificadas)
            {
                foreach (var mintermo in expressao.Mintermos)
                {
                    foreach (var mintermoCoberto in TabelaCobertura)
                    {
                        if (mintermo == mintermoCoberto)
                            estaCoberto = true;
                    }

                    if (estaCoberto == false)
                    {
                        if (ColunaMintermos[mintermo].Valor == 1)
                            TabelaCobertura.Add(mintermo);
                    }

                    estaCoberto = false;
                }
            }

            List<int> DontCares = new List<int>();

            bool ehDontCare = true;
            foreach (var expressao in ExpressoesNaoSimplificadas)
            {
                foreach (var mintermo in expressao.Mintermos)
                {
                    ehDontCare = true;
                    foreach (var mintermoCobertura in TabelaCobertura)
                    {
                        if (mintermo == mintermoCobertura)
                            ehDontCare = false;
                    }

                    if (ehDontCare == true)
                    {
                        if (!DontCares.Contains(mintermo))
                            DontCares.Add(mintermo);
                    }
                }

            }

            bool terminouDontCares = false;
            bool terminouFor = false;

            var contador = 0;

            while (terminouDontCares == false)
            {
                contador = 0;

                foreach (var expressao in ExpressoesNaoSimplificadas)
                {
                    foreach (var mintermo in expressao.Mintermos)
                    {
                        terminouFor = false;
                        foreach (var dontCare in DontCares)
                        {
                            if (mintermo == dontCare)
                            {
                                expressao.Mintermos.Remove(mintermo);
                                terminouFor = true;
                                contador += 1;
                                break;
                            }
                        }

                        if (terminouFor)
                            break;
                    }
                }

                if (contador == 0)
                    terminouDontCares = true;
            }

            List<Coluna> Conjuntos = new List<Coluna>();
            bool ehMaior = true;

            while (ExpressoesNaoSimplificadas.Count > 0)
            {
                foreach (var expressao in ExpressoesNaoSimplificadas)
                {
                    ehMaior = true;

                    foreach (var expressaoAux in ExpressoesNaoSimplificadas)
                    {
                        if (expressao.Mintermos.Count < expressaoAux.Mintermos.Count)
                            ehMaior = false;

                    }

                    if (ehMaior == true)
                    {
                        Conjuntos.Add(expressao);
                        ExpressoesNaoSimplificadas.Remove(expressao);
                        break;
                    }
                }
            }

            ExpressoesNaoSimplificadas = Conjuntos;
            TabelaCobertura.Sort();

            foreach (var expressao in ExpressoesNaoSimplificadas)
            {
                foreach (var mintermo in expressao.Mintermos)
                {
                    if (TabelaCobertura.Contains(mintermo))
                    {
                        expressao.Marcado = true;
                        TabelaCobertura.Remove(mintermo);
                    }
                }
            }

            List<Coluna> ExpressoesSimplificadas = ExpressoesNaoSimplificadas;

            ImprimeExpressoesSimplificadas(ExpressoesSimplificadas);
        }
    
        private static List<List<Mintermo>> CriaMatrizColunasMintermosCheia(List<Mintermo> ColunaMintermos)
        {
            List<List<Mintermo>> ColunaMintermosAgrupados = new List<List<Mintermo>>();

            // '<=' Porque são feitas colunas para os mintermos que não tem 1's
            for (int i = 0; i <= numVariaveis; i++)
            {
                List<Mintermo> listaColunas = new List<Mintermo>();

                ColunaMintermosAgrupados.Add(listaColunas);
            }

            // Preenche a Matriz de Mintermos de acordo com os 1's
            foreach (var mintermo in ColunaMintermos)
            {
                if (mintermo.Valor == 1 || mintermo.Valor == 2)
                {
                    short contadorUnsMintermo = 0;

                    foreach (char caracter in mintermo.Variaveis)
                    {
                        if (caracter == '1')
                        {
                            contadorUnsMintermo += 1;
                        }
                    }

                    ColunaMintermosAgrupados[contadorUnsMintermo].Add(mintermo);
                }
            }

            //Boolean temZerado = true;

            //while (temZerado)
            //{
            //    temZerado = false;

            //    foreach (var Coluna in ColunaMintermosAgrupados)
            //    {
            //        if (Coluna.Count == 0)
            //        {
            //            ColunaMintermosAgrupados.Remove(Coluna);
            //            temZerado = true;

            //            break;
            //        }
            //    }
            //}

            ImprimeMintermosAgrupados(ColunaMintermosAgrupados); /* Imprime as Colunas de Mintermos de forma agrupada no Console */

            return ColunaMintermosAgrupados;
        }

        private static List<Coluna> RodaAlgoritmoComparacao(List<List<Mintermo>> ColunaMintermosAgrupados, List<List<List<Coluna>>> MatrizColunasComparacao)
        {
            var numeroConjuntos = ColunaMintermosAgrupados.Count - 1;

            for (int i = 0; i < ColunaMintermosAgrupados.Count - 1; i++)
            {
                for (int j = 0; j < numeroConjuntos; j++)
                {
                    List<Coluna> ListaConjuntos = new List<Coluna>();
                    MatrizColunasComparacao[i].Add(ListaConjuntos);
                }

                numeroConjuntos -= 1;
            }

            // For que preenche a primeira Coluna da Matriz, a partir das Colunas de 1's
            for (int i = 0; i < ColunaMintermosAgrupados.Count; i++)
            {
                if (i + 1 < ColunaMintermosAgrupados.Count)
                {
                    foreach (Mintermo mintermo in ColunaMintermosAgrupados[i])
                    {
                        foreach (Mintermo mintermoAux in ColunaMintermosAgrupados[i + 1])
                        {
                            string variaveisAux = "";
                            short contador = 0;

                            for (int j = 0; j < numVariaveis; j++)
                            {
                                var caracter = mintermo.Variaveis.Substring(j, 1);
                                var caracterAux = mintermoAux.Variaveis.Substring(j, 1);

                                if (caracter == caracterAux)
                                {
                                    variaveisAux += caracter;
                                }
                                else
                                {
                                    variaveisAux += "_";
                                    contador += 1;
                                }
                            }

                            if (contador == 1)
                            {
                                Coluna coluna = new Coluna();
                                coluna.Variaveis = variaveisAux;

                                coluna.Mintermos.Add(mintermo.Posicao);
                                coluna.Mintermos.Add(mintermoAux.Posicao);

                                MatrizColunasComparacao[0][i].Add(coluna);
                            }
                        }
                    }

                }
            }

            var numeroDiferencas = 1;

            for (int i = 0; i < MatrizColunasComparacao.Count - 1; i++) // For mais externo, de acordo com o número de colunas..
            {
                for (int j = 0; j < MatrizColunasComparacao[i].Count; j++)
                {
                    if (j + 1 < MatrizColunasComparacao[i].Count)
                    {
                        for (int k = 0; k < MatrizColunasComparacao[i][j].Count; k++)
                        {
                            var ListaMintermos = MatrizColunasComparacao[i][j][k];

                            for (int h = 0; h < MatrizColunasComparacao[i][j + 1].Count; h++)
                            {
                                var ColunaMintermosAux = MatrizColunasComparacao[i][j + 1][h];

                                string variaveisAux = "";
                                short contador = 0;

                                for (int quantCaracteres = 0; quantCaracteres < numVariaveis; quantCaracteres++)
                                {
                                    var caracter = ListaMintermos.Variaveis.Substring(quantCaracteres, 1);
                                    var caracterAux = ColunaMintermosAux.Variaveis.Substring(quantCaracteres, 1);

                                    if (caracter == caracterAux)
                                    {
                                        variaveisAux += caracter;
                                    }
                                    else
                                    {
                                        variaveisAux += "_";
                                        contador += 1;
                                    }
                                }

                                if (contador == numeroDiferencas)
                                {
                                    ListaMintermos.Marcado = true;
                                    ColunaMintermosAux.Marcado = true;

                                    Coluna coluna = new Coluna();
                                    coluna.Variaveis = variaveisAux;

                                    var naoTem = false;

                                    foreach (var item in MatrizColunasComparacao[i + 1][j])
                                    {
                                        if (variaveisAux == item.Variaveis)
                                        {
                                            naoTem = true;
                                        }
                                    }

                                    if (!naoTem)
                                    {
                                        foreach (var mintermo in ListaMintermos.Mintermos)
                                        {
                                            coluna.Mintermos.Add(mintermo);
                                        }

                                        foreach (var mintermoAux in ColunaMintermosAux.Mintermos)
                                        {
                                            coluna.Mintermos.Add(mintermoAux);
                                        }

                                        MatrizColunasComparacao[i + 1][j].Add(coluna);
                                    }
                                }
                            }
                        }
                    }
                }
            }


            MatrizColunasComparacao = DeletaColunasVazias(MatrizColunasComparacao);

            ImprimeMatrizColunasComparacao(MatrizColunasComparacao);


            List<Coluna> ExpressoesNaoSimplificadas = new List<Coluna>();

            foreach (var listas in MatrizColunasComparacao)
            {
                foreach (var mintermos in listas)
                {
                    foreach (var item in mintermos)
                    {
                        if (!item.Marcado)
                        {
                            ExpressoesNaoSimplificadas.Add(item);
                        }
                    }
                }
            }

            ImprimeExpressoesNaoSimplificadas(ExpressoesNaoSimplificadas);

            return ExpressoesNaoSimplificadas;
        }

        private static List<List<List<Coluna>>> CriaMatrizColunasComparacaoVazia(List<List<Mintermo>> ColunaMintermosAgrupados)
        {
            List<List<List<Coluna>>> MatrizColunasComparacao = new List<List<List<Coluna>>>();

            for (int i = 0; i < ColunaMintermosAgrupados.Count - 1; i++)
            {
                List<List<Coluna>> listaColunas = new List<List<Coluna>>();

                MatrizColunasComparacao.Add(listaColunas);
            }

            return MatrizColunasComparacao;
        }

        private static List<List<List<Coluna>>> DeletaColunasVazias(List<List<List<Coluna>>> MatrizColunasComparacao)
        {
            Boolean temZerado = true;

            while (temZerado)
            {
                temZerado = false;

                for (int i = 0; i < MatrizColunasComparacao.Count; i++) // For mais externo, de acordo com o número de colunas..
                {
                    for (int j = 0; j < MatrizColunasComparacao[i].Count; j++)
                    {
                        for (int k = 0; k < MatrizColunasComparacao[i][j].Count; k++)
                        {
                            if (MatrizColunasComparacao[i][j][k].Mintermos.Count == 0)
                            {
                                temZerado = true;
                                MatrizColunasComparacao[i][j].Remove(MatrizColunasComparacao[i][j][k]);
                            }
                        }

                        if (MatrizColunasComparacao[i][j].Count == 0)
                        {
                            temZerado = true;
                            MatrizColunasComparacao[i].Remove(MatrizColunasComparacao[i][j]);
                        }
                    }

                    if (MatrizColunasComparacao[i].Count == 0)
                    {
                        temZerado = true;
                        MatrizColunasComparacao.Remove(MatrizColunasComparacao[i]);
                    }
                }
            }

            return MatrizColunasComparacao;
        }
    }
}
