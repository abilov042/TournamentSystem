﻿using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Concretes;

namespace DataAccess.Abstracts
{
    public interface ITeamDal : IEntityRepository<Team>
    {
    }
}
