using System.Collections.Generic;

namespace TMSWebAPI.Repositories
{
    /// <summary>
    /// Interface for a generic repository.
    /// </summary>
    public interface IRepository<T>
    {
        void Add(T item);
        T Get(int id);
        IEnumerable<T> GetAll();
        void Update(T item);
        void Delete(int id);
    }
}
