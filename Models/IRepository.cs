namespace ControleDeEstoqueProauto;

public interface IRepository<T> where T : class
{
   Task Add(T t);
   Task<IEnumerable<T>> GetAll();
   Task<T> GetById(int id);
   Task Update(T t);
   Task Delete(int id);
}
