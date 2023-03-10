using LanchoneteDoProgramador.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteDoProgramador.Servicos
{
    public class ServicoVenda
    {
        RepositorioVenda repositorioVenda;
        Linguagem linguagem;

        public ServicoVenda(RepositorioVenda repositorioVenda, Linguagem linguagem)
        {
            this.repositorioVenda = repositorioVenda;
            this.linguagem = linguagem;

        }

    }
}
