﻿using Core.DataAccess;
using Entity.Concretes;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ITeamTournamentDal : IEntityRepository<TeamTournament>
    {
        List<TeamTournamentDetailsDTO> GetDetailsDTOs();
    }
}
