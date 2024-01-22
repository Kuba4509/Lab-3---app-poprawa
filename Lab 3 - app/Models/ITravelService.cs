using Data.Entities;
using System.Collections.Generic;

namespace Lab_3___app.Models
{
    public interface ITravelService
    {
        int Add(Travel travel);
        void Delete(int id);
        void Update(Travel travel);
        List<Travel> FindAll();
        Travel? FindById(int id);
        List<ParticipantEntity> FindAllParticipants();
    }
}
