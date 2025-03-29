using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    [Table("teams_tournaments")]
    public class TeamTournament : IEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("team_id")]
        public int TeamId { get; set; }

        [Column("tournament_id")]
        public int TournamentId { get; set; }

        [Column("score")]
        public int Score { get; set; }
    }
}
