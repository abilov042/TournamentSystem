using Entity.Concretes;
using Entity.DTOs;
using System.Collections.Generic;

namespace Business.Abstracts
{
    public interface IGameService
    {
        void Add(Game game);
        List<GameDetailsDTO> GetGameDetailsDTOs();
    }
}
