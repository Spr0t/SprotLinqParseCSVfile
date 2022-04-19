using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprotLinqParseCSVfile
{
     class Program
    {
        static void Main(string[] args)
        {

            //Используя файл с ТОП100 шахматных игроков, найти всех игроков из России
            //    и отсортировать их по году рождения по возрастанию.

            
            RusPlayerSortBirthYear("C:\\Users\\Dell\\source\\repos\\SprotLinqParseCSVfile\\SprotLinqParseCSVfile\\Top100ChessPlayers.csv");
            Console.ReadLine();
        }

        static void RusPlayerSortBirthYear(string file)
        {

            List<ChessPlayers> list = File.ReadAllLines(file)
                                          .Skip(1)
                                          .Select(x => ChessPlayers.ParseFideCsv(x))
                                          .Where(player => player.Country == "RUS")
                                          .OrderBy(player => player.BirthYear)
                                          .ToList();
            list.ForEach(Console.WriteLine);


        }
    }
}
