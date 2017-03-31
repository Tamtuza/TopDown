/* 
 * Aluna: Tamillys Pantuza
 * 
 * Descrição: Utilizando a estratégia Top-down (Programação Dinâmica), implemente um algoritmo que seja capaz de 
 *            destacar trechos semelhantes entre duas palavras. 
 *            
 * */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // Arraylists que irão armazenar as palavras digitadas pelo usuário
        ArrayList p1 = new ArrayList();
        ArrayList p2 = new ArrayList();

        // Arraylist utilizado para armazenar os trechos em comum
        ArrayList semelhancas;

        // Variáveis que vão receber o tamanho das palavras para definir o tamanho da matriz
        int largura = 0;
        int altura = 0;

        // String usada para printar a matriz na tela
        string saida = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            // Armazena em um arraylist a primeira e a segunda palavra digitada
            foreach (char c in txtBoxPalavra1.Text) { p1.Add(c); }
            foreach (char c in txtBoxPalavra2.Text) { p2.Add(c); }

            // Inverte a segunda palavra para realizar a análise
            p2.Reverse(0, p2.Count);

            // Define altura e largura da matriz
            largura = p2.Count;
            altura = p1.Count;

            // Array que irá montar a matriz de semelhanças
            int[,] semelhanca = new int[largura, altura];

            // Preenche a matriz com 0 ou 1
            Comparar(semelhanca);

            // Printa a matriz na tela
            for (int i = 0; i < largura; i++)
            {
                saida += ("|  ");
                for (int j = 0; j < altura; j++ )
                {
                    saida += (semelhanca[i, j] + " ");
                }
                saida += (" |\n");
            }
            lblSaida.Text = (saida);

            // Chama função que busca igualdades
            Subpalavras(semelhanca);

            // Printa resultado na tela
            lblSaida.Text += ("\n\nOs trechos semelhantes são:\n\n"); 
                      
            for(int i = 0; i < semelhancas.Count; i++){
                lblSaida.Text += semelhancas[i];
            }
        }

        // Função que compara as strings e gera a matriz de semelhanças
        private void Comparar(int[,] matriz)
        {
            for (int x = 0; x < p2.Count; x++)
            {
                for (int y = 0; y < p1.Count; y++)
                {  
                    // Acrescenta "0" se não houver semelhança
                    if (!p1[y].Equals(p2[x]))
                        matriz[x, y] = 0;

                    // Acrescenta "1" se houver semelhança
                    else
                        matriz[x, y] = 1;
                }
            }
        }

        // Função que verifica quais as sequências formadas
        private void Subpalavras(int[,] matriz)
        {
            semelhancas = new ArrayList();
          
            for(int i = 0; i < p2.Count; i++)
            {
                for(int j = 0; j < p1.Count; j++)
                {
                    String retorno = topDown(i, j, matriz);

                    // Verifica se o retorno é uma sequência de tamanho maior que 1
                    if(retorno.Length > 1)
                    {
                        String aux = "";
                        for (int a = retorno.Length - 1; a >= 0; a--)
                        {
                            aux += retorno[a];
                        } 
                        semelhancas.Add(aux + ", ");
                    }
                }
            }
        }

        // Função que encontra as letras que ocorrem em comum nas duas palavras
        private String topDown(int i, int j, int[,] matriz)
        {        
            String retorno = "";

            if (matriz[i, j] == 1)
            {
                matriz[i, j] = -1; // Flag
                retorno = (p2[i] + "");

                // Verifica se os índices estão dentro do limite da matriz
                if((i < p2.Count - 1) && (j > 0))
                {
                    // Chamada recursiva
                    retorno += topDown(i + 1, j - 1, matriz);
                }
                return (retorno);
            }
            return "";
        }
    }
}
