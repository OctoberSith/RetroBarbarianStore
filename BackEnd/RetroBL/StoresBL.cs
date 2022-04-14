using RetroModels;
using RetroDL;

namespace RetroBL;
public class StoresBL : IRetroBL<Stores>
{
    private readonly DbContextStoresRepo _repo;

    public StoresBL(DbContextStoresRepo repo)
    {
        _repo = repo;
    }

    public async Task<Stores> Add(Stores p_resource)
    {
        return await _repo.Add(p_resource);
    }

    public async Task<Stores> Delete(Stores p_resource)
    {
        return await _repo.Delete(p_resource);
    }

    public List<Stores> GetAll()
    {
        return _repo.GetAll();
    }

    public async Task<Stores> Update(Stores p_resource)
    {
        return await _repo.Update(p_resource);
    }
}
