using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class GameDetailsDTO : IDto
    {
        public int Id { get; set; }
        public int Team1Id { get; set; }
        public string Team1Name { get; set; }
        public int Team2Id { get; set; }
        public string Team2Name { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
    }
}
