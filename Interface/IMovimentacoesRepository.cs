using ControleDeEstoqueProauto.Models;

namespace ControleDeEstoqueProauto.Interface
{
    public interface IMovimentacoesRepository
    {
        Task<IEnumerable<Movimentacoes>> GetAll();
        Movimentacoes GetById(int id);
        Task<Movimentacoes> GetByProductName(string name);
        void Save(Movimentacoes movimentacoes);
    }
}
