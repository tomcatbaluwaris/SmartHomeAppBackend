namespace SmartHomeAppBackend;

public interface IAreaRepository : IBaseRepository<Area>
{
    IEnumerable<Area> GetAll();
    IEnumerable<Area> GetAllById(int id);
}

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    public IEnumerable<T> GetAll()
    {
        return GetAll();
    }

    public IEnumerable<T> GetAllById(int id)
    {
        return GetAllById(id);
    }
}

public interface IBaseRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    
    IEnumerable<T> GetAllById(int id);
}