﻿using ControleDeEstoqueProauto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoqueProauto.Interface
{
    public interface IProdutosRepository
    {
        Task<IEnumerable<Produtos>> GetAll();
        Produtos GetById(int id);
        Produtos GetByName(string name);
        void SaveProduct(int id, Produtos produto);
    }
}
