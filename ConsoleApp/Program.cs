using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entity.Concretes;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITeamTournamentDal teamTournamentDal = new EfTeamTournamentDal();

            List<TeamTournamentDetailsDTO> teamTournamentDetailsDTOs = teamTournamentDal.GetDetailsDTOs();

            foreach(TeamTournamentDetailsDTO teamTournamentDetailsDTO in teamTournamentDetailsDTOs)
            {
                Console.WriteLine(teamTournamentDetailsDTO.TeamName + " " + teamTournamentDetailsDTO.Score);
            }



        }
    }
}
