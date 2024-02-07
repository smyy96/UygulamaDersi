namespace ClassLibrary1.Abstract
{
    public interface IRepository<T> where T : IEntity
    {
        string FilePath { get; set; }
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);

        T GetById(int id);
    }

}
