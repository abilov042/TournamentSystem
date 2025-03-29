using Business.Abstracts;
using DataAccess.Abstracts;
using Entity.Concretes;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class TeamTournamentManager : ITeamTournamentService
    {
        private readonly ITeamTournamentDal _teamTournamentDal;
        public TeamTournamentManager(ITeamTournamentDal teamTournamentDal)
        {
            _teamTournamentDal = teamTournamentDal;
        }

        public TeamTournament FindByTeamAndTournamentId(int teamId, int tournamentId)
        {
            return _teamTournamentDal.Get((teamTournament) => 
            teamTournament.TeamId == teamId && teamTournament.TournamentId == tournamentId);
        }

        public List<TeamTournamentDetailsDTO> GetDetailsDTOs()
        {
            return _teamTournamentDal.GetDetailsDTOs();
        }

        public void Update(TeamTournament teamTournament)
        {
            _teamTournamentDal.Update(teamTournament);
        }
    }
}
