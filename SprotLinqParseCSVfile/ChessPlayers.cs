using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprotLinqParseCSVfile
{
    public class ChessPlayers
    {
        public string Country { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int Rating { get; set; }
        public int Id { get; set; }


        public override string ToString()
        {
            return $"Full name {FirstName} {LastName}, Rating = {Rating}, from {Country}, born in {BirthYear}  ";
        }
        public static ChessPlayers ParseFideCsv(string line)
        {
            string[] parts = line.Split(';');
            return new ChessPlayers()
            {
                Id = int.Parse(parts[0]),
                LastName = parts[1],
                FirstName = parts[2],
                Country = parts[4],
                Rating = int.Parse(parts[5]),
                BirthYear = int.Parse(parts[7])
            };
        }

      

    }
}
