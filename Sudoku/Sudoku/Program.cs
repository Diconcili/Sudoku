using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            string sudoku = "1 3 2 5 7 9 4 6 8 " +
                            "4 9 8 2 6 1 3 7 5 " +
                            "7 5 6 3 8 4 2 1 9 " +
                            "6 4 3 1 5 8 7 9 2 " +
                            "5 2 1 7 9 3 8 4 6 " +
                            "9 8 7 4 2 6 5 3 1 " +
                            "2 1 4 9 3 5 6 8 7 " +
                            "3 6 5 8 1 7 9 2 4 " +
                            "8 7 9 6 4 2 1 5 3";

            string[] caracteresSudoku = sudoku.Split(' ');

            int[] numerosSudoku = Array.ConvertAll(caracteresSudoku, int.Parse);

            int[,] matrizSudoku = new int[9, 9];

            DefineLinhasEColunas(numerosSudoku, matrizSudoku);
            ValidaSudoku(matrizSudoku);

            Console.ReadLine();

            #region
            /*for (int i = 1; i < 8; i++)
            {                

                for (int j = 2; j < 7; j++)
                {                   

                    for (int k = 3; k < 6; k++)
                    {                       

                        for (int l = 4; l < 6; l++)
                        {
                            if (numerosLinha1[i] == numerosLinha1[i - 1] || numerosLinha1[i + 1] == numerosLinha1[i] || numerosLinha1[i + 1] == numerosLinha1[i - 1])
                            {
                                Console.WriteLine("NÃO");
                            } 
                        }
                    }
                }                 
            }

            for (int i = 1; i < 8; i++)
            {

                for (int j = 2; j < 7; j++)
                {

                    for (int k = 3; k < 6; k++)
                    {

                        for (int l = 4; l < 6; l++)
                        {
                            if (numerosLinha2[i] == numerosLinha2[i - 1] || numerosLinha2[i + 1] == numerosLinha2[i] || numerosLinha2[i + 1] == numerosLinha2[i - 1])
                            {
                                Console.WriteLine("NÃO");
                            }                           
                        }
                    }
                }
            }

            for (int i = 1; i < 8; i++)
            {

                for (int j = 2; j < 7; j++)
                {

                    for (int k = 3; k < 6; k++)
                    {

                        for (int l = 4; l < 6; l++)
                        {
                            if (numerosLinha3[i] == numerosLinha3[i - 1] || numerosLinha3[i + 1] == numerosLinha3[i] || numerosLinha3[i + 1] == numerosLinha3[i - 1])
                            {
                                Console.WriteLine("NÃO");
                            }                           
                        }
                    }
                }
            }

            for (int i = 1; i < 8; i++)
            {

                for (int j = 2; j < 7; j++)
                {

                    for (int k = 3; k < 6; k++)
                    {

                        for (int l = 4; l < 6; l++)
                        {
                            if (numerosLinha4[i] == numerosLinha4[i - 1] || numerosLinha4[i + 1] == numerosLinha4[i] || numerosLinha4[i + 1] == numerosLinha4[i - 1])
                            {
                                Console.WriteLine("NÃO");
                            }                            
                        }
                    }
                }
            }

            for (int i = 1; i < 8; i++)
            {

                for (int j = 2; j < 7; j++)
                {

                    for (int k = 3; k < 6; k++)
                    {

                        for (int l = 4; l < 6; l++)
                        {
                            if (numerosLinha5[i] == numerosLinha5[i - 1] || numerosLinha5[i + 1] == numerosLinha5[i] || numerosLinha5[i + 1] == numerosLinha5[i - 1])
                            {
                                Console.WriteLine("NÃO");
                            }                           
                        }
                    }
                }
            }

            for (int i = 1; i < 8; i++)
            {

                for (int j = 2; j < 7; j++)
                {

                    for (int k = 3; k < 6; k++)
                    {

                        for (int l = 4; l < 6; l++)
                        {
                            if (numerosLinha6[i] == numerosLinha6[i - 1] || numerosLinha6[i + 1] == numerosLinha6[i] || numerosLinha6[i + 1] == numerosLinha6[i - 1])
                            {
                                Console.WriteLine("NÃO");
                            }                            
                        }
                    }
                }
            }

            for (int i = 1; i < 8; i++)
            {

                for (int j = 2; j < 7; j++)
                {

                    for (int k = 3; k < 6; k++)
                    {

                        for (int l = 4; l < 6; l++)
                        {
                            if (numerosLinha7[i] == numerosLinha7[i - 1] || numerosLinha7[i + 1] == numerosLinha7[i] || numerosLinha7[i + 1] == numerosLinha7[i - 1])
                            {
                                Console.WriteLine("NÃO");
                            }                           
                        }
                    }
                }
            }

            for (int i = 1; i < 8; i++)
            {

                for (int j = 2; j < 7; j++)
                {

                    for (int k = 3; k < 6; k++)
                    {

                        for (int l = 4; l < 6; l++)
                        {
                            if (numerosLinha8[i] == numerosLinha8[i - 1] || numerosLinha8[i + 1] == numerosLinha8[i] || numerosLinha8[i + 1] == numerosLinha8[i - 1])
                            {
                                Console.WriteLine("NÃO");
                            }                            
                        }
                    }
                }
            }

            for (int i = 1; i < 8; i++)
            {

                for (int j = 2; j < 7; j++)
                {

                    for (int k = 3; k < 6; k++)
                    {

                        for (int l = 4; l < 6; l++)
                        {
                            if (numerosLinha9[i] == numerosLinha9[i - 1] || numerosLinha9[i + 1] == numerosLinha9[i] || numerosLinha9[i + 1] == numerosLinha9[i - 1])
                            {
                                Console.WriteLine("NÃO");
                            }
                            else
                            {
                                Console.WriteLine("SIM");
                            }
                        }
                    }
                }
            } */
            #endregion

        }

        private static void ValidaSudoku(int[,] matrizSudoku)
        {
            VerificaLinhas(matrizSudoku);
            VerificaColunas(matrizSudoku);
            VerificaBlocos(matrizSudoku);
            
        }

        private static void VerificaBlocos(int[,] matrizSudoku)
        {            
            int ajeitaValorLinha = 0;
            int ajeitaValorColuna = 0;
            int verificaSoma = 0;

            for (int linhas = 0; linhas < 9; linhas++)
            {
                for (int colunas = 0; colunas < 9; colunas++)
                {
                    ajeitaValorLinha = linhas * 3;
                    ajeitaValorColuna = colunas * 3;                    

                    for (int i = ajeitaValorLinha; i < ajeitaValorLinha + 3; ajeitaValorLinha++)
                    {
                        for (int j = ajeitaValorColuna; j < ajeitaValorColuna + 3; ajeitaValorColuna++)
                        {
                            verificaSoma = matrizSudoku[i, j]++;
                        }
                    }
                    if (verificaSoma != 45)
                    {
                        Console.WriteLine("NÃO");
                    } 
                }
            }            
        }

        private static void VerificaColunas(int[,] matrizSudoku)
        {
            int verificadorColuna = 0;
            for (int linhas = 0; linhas < 9; linhas++)
            {
                for (int colunas = 0; colunas < 9; colunas++)
                {
                    for (int q = 0; q < 9; q++)
                    {
                        if (matrizSudoku[colunas, linhas] == matrizSudoku[q, linhas] && colunas != q)
                        {
                            verificadorColuna = 1;
                        }
                    }
                }
            }
              if (verificadorColuna == 1)
              {
                  Console.WriteLine("NÃO");
              }             
        }

        private static void VerificaLinhas(int[,] matrizSudoku)
        {
            int verificadorLinha = 0;
            for (int linhas = 0; linhas < 9; linhas++)
            {
                for (int colunas = 0; colunas < 9; colunas++)
                {
                    for (int q = 0; q < 9; q++)
                    {
                        if (matrizSudoku[linhas, colunas] == matrizSudoku[linhas, q] && colunas != q)
                        {
                            verificadorLinha = 1;
                        }
                    }
                }
            }
             if (verificadorLinha == 1)
              {
                  Console.WriteLine("NÃO");
              }             
        }

        private static void DefineLinhasEColunas(int[] numerosSudoku, int[,] matrizSudoku)
        {
            int contador = 0;
            for (int linhas = 0; linhas < 9; linhas++)
            {
                for (int colunas = 0; colunas < 9; colunas++)
                {
                    matrizSudoku[linhas, colunas] = numerosSudoku[contador];
                    contador++;
                    Console.Write(matrizSudoku[linhas, colunas]);
                }
                Console.WriteLine(" ");
            }
        }        
    }
        }
    