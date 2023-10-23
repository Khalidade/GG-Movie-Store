using GGStores.Data.Interface;
using GGStores.Models;
using Microsoft.EntityFrameworkCore;

namespace GGStores.Data.Implementations
{
    public class ActorsServicecs : IActorsService
    {
        private readonly StoreDbContext _dbContext;

        public ActorsServicecs(StoreDbContext storeDbContext)
        {
            _dbContext = storeDbContext;
        }
        public async Task AddAsync(ActorModel actor)
        {
            await _dbContext.Actors.AddAsync(actor);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var singleActor = await _dbContext.Actors.SingleOrDefaultAsync(x => x.Id == id);
            _dbContext.Actors.Remove(singleActor);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<ActorModel>> GetAllAsync()
        {
            var allActors = await _dbContext.Actors.ToListAsync();

            return allActors;
        }

        public async Task<ActorModel> GetByIdAsync(int id)
        {
            var singleActor = await _dbContext.Actors.FirstOrDefaultAsync(x => x.Id == id);

            return singleActor;
        }

        public async Task<ActorModel> UpdateAsync(int id, ActorModel NewActor)
        {
            _dbContext.Update(NewActor);
            await _dbContext.SaveChangesAsync();
            return NewActor;
        }


    }
}
