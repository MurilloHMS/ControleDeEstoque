using ControleDeEstoqueProauto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
