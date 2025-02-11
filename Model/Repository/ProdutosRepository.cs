using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleDeEstoqueProauto.Interface;
using ControleDeEstoqueProauto.Models;
using ControleDeEstoqueProauto.Data;
using Microsoft.EntityFrameworkCore;

namespace ControleDeEstoqueProauto.Model.Repository
{
    internal class ProdutosRepository : IProdutosRepository
    {

        private readonly AppDbContext _context = new AppDbContext();
        public async Task<IEnumerable<Produtos>> GetAll()
        {
            var produtos = await _context.produtos.ToListAsync();
            return produtos;
        }

        public Produtos GetById(int id)
        {
            var produto = _context.produtos.FirstOrDefault(p => p.IDSistema == id);
            return produto ?? null;
        }

        public async Task<Produtos> GetByName(string name)
        {
            var produtos = await _context.produtos.FirstOrDefaultAsync(p => p.Descricao == name);
            return produtos ?? null;
        }

        public void SaveProduct(Produtos produto)
        {
             _context.produtos.Update(produto);
            _context.SaveChanges();
        }
        public void SaveNewProduct(Produtos produto)
        {
            _context.produtos.Add(produto);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Produtos>> GetListByFilter(string name)
        {
            var produtos = await _context.produtos.Where(p => p.Descricao.ToLower().Contains(name)).ToListAsync();
            return produtos;
        }
    }
}
