using Business.Abstracts;
using DataAccess.Abstracts;
using Entity.Concretes;

namespace Business.Concretes
{
    public class GameManager : IGameService
    {
        private readonly IGameDal _gameDal;

        public GameManager(IGameDal gameDal)
        {
            _gameDal = gameDal;
        }

        public void Add(Game game)
        {
            _gameDal.Add(game);
        }
    }
}
