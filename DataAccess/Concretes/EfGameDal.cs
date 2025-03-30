using Core.DataAccess;
using DataAccess.Abstracts;
using Entity.Concretes;
using Entity.DTOs;
using Microsoft.SqlServer.Server;
using Npgsql.TypeHandlers.FullTextSearchHandlers;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concretes
{
    public class EfGameDal : EfEntityRepository<Game, TournamentDbContext>, IGameDal
    {
        public List<GameDetailsDTO> GetDetailsDTOs()
        {
            using (var context = new TournamentDbContext())
            {
                var result = from g in context.Games
                             join t1 in context.Teams on g.Team1Id equals t1.Id
                             join t2 in context.Teams on g.Team2Id equals t2.Id
                             select new GameDetailsDTO
                             {
                                 Id = g.Id,
                                 Team1Id = t1.Id,
                                 Team1Name = t1.Name,
                                 Team2Id = t2.Id,
                                 Team2Name = t2.Name,
                                 Score1 = g.Score1,
                                 Score2 = g.Score2
                             };
                return result.ToList();
            }
        }
    }
}
