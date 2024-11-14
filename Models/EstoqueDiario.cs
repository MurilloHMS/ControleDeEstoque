using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoqueProauto.Models
{
    public class EstoqueDiario
    {
        public int Id { get; set; }
        public int IdSistema { get; set; }
        public int Produto {  get; set; }
        public DateTime Data { get; set; }
        public int Quantidade { get; set; }

        private readonly DAL<EstoqueDiario> _dal = new DAL<EstoqueDiario>();
        public async Task Add()
        {
            await _dal.AddAsync(this);
        }

        public async Task Update()
        {
            await _dal.UpdateAsync(this);
        }

        public async Task Delete()
        {
            await _dal.DeleteAsync(this);
        }
    }
}
