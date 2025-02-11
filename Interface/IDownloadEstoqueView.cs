using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoqueProauto.Interface
{
    public interface IDownloadEstoqueView
    {
        DateTime DataSelecionada { get; set; }

        Presenter.DownloadEstoquePresenter Presenter { get; set; }
    }
}
