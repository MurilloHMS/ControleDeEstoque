using ControleDeEstoqueProauto.Models;

namespace ControleDeEstoqueProauto.Interface
{
    public interface IMovimentacoesRepository
    {
        Task<IEnumerable<Movimentacoes>> GetAll();
        Movimentacoes GetById(int id);
        Task<Movimentacoes> GetByProductName(string name);
        void Save(Movimentacoes movimentacoes);
        Task<IList<Movimentacoes>> GetForName(string name);
        Task DeleteById(int id);
    }
}
