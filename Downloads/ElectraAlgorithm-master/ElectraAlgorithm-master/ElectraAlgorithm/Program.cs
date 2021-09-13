using System;
using System.Collections.Generic;
using ParetoAlgorithm;

namespace ElectraAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new List<ElectraTable>()
            {
                new ElectraTable("Цена           ",     4,  "1-2,2-3,3-4,4-5",  "1,2,3,4", "min"),
                new ElectraTable("Расход топлива ",     5,  "Выс,средн,низк ",  "15,10,5", "min"),
                new ElectraTable("Оценка безопасн",     5,  "Выс,средн,низк ",  "15,10,5", "max"),
                new ElectraTable("Оценка качества",     4,  "Выс,средн,низк ",  "15,10,5", "max"),
                new ElectraTable("Рейтинг        ",     3,  "Выс,средн,низк ",  "15,10,5", "max")
            };
            var MainCollection = new List<Auto>
            {
                new Auto("Honda",  2.5f, 7,  5, 8, 7),
                new Auto("Audi",   3.7f, 10, 5, 7, 6),
                new Auto("Mini",   3.2f, 6,  4, 8, 6),
                new Auto("Dodge",  2.5f, 15, 7, 6, 5),
                new Auto("Lexus",  4.7f, 10, 6, 8, 6),
                new Auto("Nissan", 3.1f, 8,  6, 7, 6),
                new Auto("Ford",   1.5f, 7,  4, 5, 5),
                new Auto("Jeep",   2.8f, 13, 6, 6, 7),
                new Auto("Volvo",  3.5f, 10, 7, 8, 8)
            };

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in MainCollection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var matrix = new string[9, 9];
            Algorithms algorithms = new Algorithms();
            matrix = algorithms.PairComparison(matrix, MainCollection);
            Matrix.CreateMatrix(matrix);

            Console.Write("Установить ограничение C: ");
            float C = float.Parse(Console.ReadLine());
            matrix = algorithms.Ogranich(matrix, C);
            Matrix.CreateMatrix(matrix);
            algorithms.Graph(matrix);
        }
    }
}
