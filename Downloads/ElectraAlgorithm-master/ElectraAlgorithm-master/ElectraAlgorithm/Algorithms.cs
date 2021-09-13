using System;
using System.Collections.Generic;
using ParetoAlgorithm;


namespace ElectraAlgorithm 
{
    class Algorithms  
    {
        public string[,] PairComparison(string[,] matrix, List<Auto> collection)
        {
            var arrayOfField = new string[] { "Цена", "Расход топлива", "Оценка безопасности", "Оценка качества", "Рейтинг" };
            var arrayOfWeight = new int[] { 4, 5, 5, 4, 3 };


            int score = collection.Count;
            float P = 0;
            float N = 0;
            float D = 0;

            for (int P_line = 0; P_line < score; P_line++)
            {
                for (int N_line = 1; N_line <= score - 1; N_line++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (arrayOfField[k] == "Цена" || arrayOfField[k] == "Расход топлива")
                        {
                            if (collection[P_line].GetField(arrayOfField[k]) > collection[N_line].GetField(arrayOfField[k]))
                            {
                                P += 0;
                                N += arrayOfWeight[k];
                            }
                            else if (collection[P_line].GetField(arrayOfField[k]) < collection[N_line].GetField(arrayOfField[k]))
                            {
                                N += 0;
                                P += arrayOfWeight[k];
                            }
                            else if (collection[P_line].GetField(arrayOfField[k]) == collection[N_line].GetField(arrayOfField[k]))
                            {
                                P += 0;
                                N += 0;
                            }
                        }
                        else
                        if (collection[P_line].GetField(arrayOfField[k]) > collection[N_line].GetField(arrayOfField[k]))
                        {
                             P += arrayOfWeight[k];
                             N += 0;
                        }
                        else if (collection[P_line].GetField(arrayOfField[k]) < collection[N_line].GetField(arrayOfField[k]))
                        { 
                             N += arrayOfWeight[k];
                             P += 0;
                        }
                        else if (collection[P_line].GetField(arrayOfField[k]) == collection[N_line].GetField(arrayOfField[k]))
                        {
                             P += 0;
                             N += 0;
                        }
                    }

                    if (P == 0 || N == 0)
                    {
                        if (P == 0 && N != 0)
                        {
                            matrix[P_line, N_line] = "oo";
                            matrix[N_line, P_line] = "-";
                        }
                        else if (N == 0 && P != 0)
                        {
                            matrix[P_line, N_line] = "-";
                            matrix[N_line, P_line] = "oo";
                        }
                    }
                    else if (P == 0 && N == 0)
                    {
                        matrix[P_line, N_line] = "-";
                        matrix[N_line, P_line] = "-";
                    }
                    else if (P != 0 && N != 0)
                    {
                        D = P / N;
                        if (D > 1)
                        {
                            matrix[P_line, N_line] = Convert.ToString(Math.Round(D, 1));
                            
                            matrix[N_line, P_line] = "-";
                        }
                        else if (D <= 1)
                        {
                            D = N / P;
                            matrix[N_line, P_line] = Convert.ToString(Math.Round(D, 1));
                            matrix[P_line, N_line] = "-";
                        }
                    }
                    P = 0;
                    N = 0;
                    D = 0;
                }
            }
            return matrix;
        }

        public string[,] Ogranich(string[,] matrix, float C)
        {
            for (int line = 0; line < matrix.GetLength(0); line++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    if (matrix[line,row] == "-" || matrix[line, row] == "oo" || matrix[line, row] == "X")
                    {
                        continue;
                    }
                    else
                    {
                        float value = Convert.ToSingle(matrix[line, row]);
                        if (value < C)
                        {
                            matrix[line, row] = "-";
                        }
                        else continue;
                    }
                }
            }
            return matrix;
        }


        public void Graph(string[,] matrix)
        {
            for (int line = 0; line < matrix.GetLength(0); line++)
            {
                Console.Write($"Проект {line+1} лучше проектов: ");
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    if (matrix[line, row] == "-" || matrix[line, row] == "oo" || matrix[line, row] == "X")
                    {
                        continue;
                    }
                    else Console.Write($"({row + 1})");
                }
                Console.WriteLine();
            }
        }
    }
}
