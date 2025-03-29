using Core.DataAccess;
using DataAccess.Abstracts;
using Entity.Concretes;

namespace DataAccess.Concretes
{
    public class EfGameDal : EfEntityRepository<Game, TournamentDbContext>, IGameDal
    {
    }
}
