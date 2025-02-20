using ControleDeEstoqueProauto.Models;

namespace ControleDeEstoqueProauto.Interface
{
    public interface IProdutosRepository
    {
        Task<IEnumerable<Produtos>> GetAll();
        Produtos GetById(int id);
        Task<Produtos> GetByName(string name);
        void SaveProduct(Produtos produto);
        void SaveNewProduct(Produtos produto);
        Task InsertOrUpdate(Produtos produto);
        Task<IEnumerable<Produtos>> GetListByFilter(string name);

    }
}
