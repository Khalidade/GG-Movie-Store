using GGStores.Models;

namespace GGStores.Data.Interface
{
    public interface IActorsService
    {
        Task<IEnumerable<ActorModel>> GetAllAsync();
        Task<ActorModel> GetByIdAsync(int id);


        Task AddAsync(ActorModel actor);
        Task<ActorModel> UpdateAsync(int id, ActorModel NewActor);

        Task DeleteAsync(int id);

    }
}
