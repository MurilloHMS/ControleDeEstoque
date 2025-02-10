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
        
    }
}
