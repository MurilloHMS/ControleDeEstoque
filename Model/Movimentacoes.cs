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
    }
}
