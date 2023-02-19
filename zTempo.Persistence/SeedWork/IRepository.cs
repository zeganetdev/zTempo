namespace zTempo.Persistence.SeedWork
{
    public interface IRepository<T> where T : class
    {
        void SaveChanges(List<T> entity);
        List<T> GetList();
    }
}