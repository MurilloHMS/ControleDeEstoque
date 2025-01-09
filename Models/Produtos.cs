using ClosedXML.Excel;
using ControleDeEstoqueProauto.Migrations;
using SQLitePCL;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ControleDeEstoqueProauto.Models
{
    public class Produtos
    {
        [Required]
        public int IDSistema { get; set; }
        [Required]
        public string Descricao { get; set; }
        public int ? EstoqueMinimo { get; set; }

        public override string ToString()
        {
            return Descricao;
        }

    }
    
}
