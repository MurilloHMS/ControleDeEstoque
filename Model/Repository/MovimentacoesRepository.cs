using ControleDeEstoqueProauto.Data;
using ControleDeEstoqueProauto.Interface;
using ControleDeEstoqueProauto.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoqueProauto.Model.Repository
{
    internal class MovimentacoesRepository : IMovimentacoesRepository
    {
        private readonly AppDbContext _context = new AppDbContext();
        public Task<IEnumerable<Movimentacoes>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Movimentacoes GetById(int id)
        {
            var movimentacoes = _context.movimentacoes.Where(m => m.IDSistema == id).OrderByDescending(m => m.Data).FirstOrDefault();
            return movimentacoes;
        }

        public async Task<Movimentacoes> GetByProductName(string name)
        {
            var produto = await _context.produtos.FirstOrDefaultAsync(p => p.Descricao == name);
            var mov = await _context.movimentacoes.FirstOrDefaultAsync(m => m.IDSistema == produto.IDSistema);
            return mov;
        }

        public async void Save( Movimentacoes movimentacoes)
        {
            await _context.movimentacoes.AddAsync(movimentacoes);
            _context.SaveChanges();
        }
    }
}
