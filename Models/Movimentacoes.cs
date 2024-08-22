using DocumentFormat.OpenXml.Office.PowerPoint.Y2021.M06.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoqueProauto.Models
{
    public class Movimentacoes
    {
        public int ID { get; set; }
        public int IDSistema { get; set; }
        public DateTime Data {  get; set; }
        public int Quantidade { get; set; }

        private readonly DAL<Movimentacoes> _dal = new DAL<Movimentacoes>();
        

        #region Crud
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

        public async Task<IEnumerable<Movimentacoes>> GetAll()
        {
            return await _dal.GetAllAsync();
        }

        public async Task<Movimentacoes> GetForIDSistema(int id)
        {
            return await _dal.GetForAsync(x => x.IDSistema.Equals(id));
        }
        public async Task<Movimentacoes> GetForID(int id)
        {
            return await _dal.GetForAsync(x => x.ID.Equals(id));
        }

        public async Task<IEnumerable<Movimentacoes>> GetListForID(int id)
        {
            return await _dal.GetListForAsync(x => x.IDSistema.Equals(id));
        }

        public async Task<IEnumerable<Movimentacoes>> GetListForDate(DateTime dataDe, DateTime dataAte)
        {
            return await _dal.GetListForAsync(x => x.Data >= dataDe && x.Data <= dataAte);
        }

        #endregion
    }
}
