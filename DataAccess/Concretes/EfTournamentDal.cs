using Core.DataAccess;
using DataAccess.Abstracts;
using Entity.Concretes;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfTournamentDal : EfEntityRepository<Tournament, TournamentDbContext>, ITournamentDal
    {
    }
}
