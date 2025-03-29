using Core.DataAccess;
using DataAccess.Abstracts;
using Entity.Concretes;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfTeamTournamentDal : EfEntityRepository<TeamTournament, TournamentDbContext>, ITeamTournamentDal
    {
        public List<TeamTournamentDetailsDTO> GetDetailsDTOs()
        {
            using (var context = new TournamentDbContext())
            {
                var result = from tt in context.TeamsTournaments
                             join t in context.Teams
                             on tt.TeamId equals t.Id
                             join tou in context.Tournaments
                             on tt.TournamentId equals tou.Id
                             where tou.Id == 1 orderby tt.Score descending
                             select new TeamTournamentDetailsDTO { Id = tt.Id, TeamId = t.Id , TeamName = t.Name, Score = tt.Score};

                return result.ToList();
            }
            
        }
    }
}
