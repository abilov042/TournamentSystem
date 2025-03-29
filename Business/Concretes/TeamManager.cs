using Business.Abstracts;
using DataAccess.Abstracts;
using Entity.Concretes;
using System.Collections.Generic;

namespace Business.Concretes
{
    public class TeamManager : ITeamService
    {
        private readonly ITeamDal _teamDal;
        public TeamManager(ITeamDal teamDal) 
        {
            _teamDal = teamDal;
        }
        public List<Team> GetAll()
        {
            return _teamDal.GetAll();
        }
    }
}
