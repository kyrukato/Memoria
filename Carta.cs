using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memoria
{
    internal class Carta
    {
        List<string> lista2 = new List<string>();
        List<string> listaletras = new List<string>();
        Random rnd = new Random();
        public void CartaAleatoria(int num)
        {
            /*string letra;
            string[] letras = { "A", "B", "C", "D", "M", "N", "S", "T", "U", "V", "W" };
            for(int i = 0; i<num; i++)
            {
                do
                {
                    int indice = rnd.Next(letras.Length);
                    letra = letras[indice];
                } while (listaletras.Contains(letra));
                listaletras.Add(letra);
            }*/
            string letra;
            string[] letras = { "A", "B", "C", "D", "M", "N", "S", "T", "U", "V", "W" };
            for (int i = 0; i < num; i++)
            {
                do
                {
                    int indice = rnd.Next(letras.Length);
                    letra = letras[indice];
                } while (listaletras.Contains(letra));
                listaletras.Add(letra);
                lista2.Add(letra);
            }
        }

        public string[,] AcomodarMatriz(int ren, int col, int num)
        {
            /*CartaAleatoria(num);
            string[,] matriz;
            matriz = new string[ren,col];
            for(int i = 0; i < num; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int r, c;
                    do
                    {
                        r = rnd.Next(ren);
                        c = rnd.Next(col);
                    } while (matriz[r, c] != null);
                    matriz[r, c] = listaletras[i];
                }
            }*/
            string[,] matriz;
            matriz = new string[ren, col];
            for (int i = 0; i < num; i++)
            {
                int r, c;
                do
                {
                    r = rnd.Next(ren);
                    c = rnd.Next(col);
                } while (matriz[r, c] != null);
                matriz[r, c] = listaletras[i];
            }
            for (int i = 0; i < num; i++)
            {
                int r, c;
                do
                {
                    r = rnd.Next(ren);
                    c = rnd.Next(col);
                } while (matriz[r, c] != null);
                matriz[r, c] = lista2[i];
            }
            return matriz;
        }
    }
}
