using Entity.Concretes;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ITeamTournamentService
    {
        List<TeamTournamentDetailsDTO> GetDetailsDTOs();
        TeamTournament FindByTeamAndTournamentId(int teamId, int tournamentId);
        void Update(TeamTournament teamTournament);
    }
}
