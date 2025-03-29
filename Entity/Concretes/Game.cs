using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    [Table("games")]
    public class Game :IEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("team1_id")]
        public int Team1Id { get; set; }

        [Column("team2_id")]
        public int Team2Id { get; set; }

        [Column("score1")]
        public int Score1 {  get; set; }

        [Column("score2")]
        public int Score2 { get; set; }
    }
}
