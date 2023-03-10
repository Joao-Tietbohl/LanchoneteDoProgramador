using LanchoneteDoProgramador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteDoProgramador.Repositorios
{
    public class RepositorioVenda : RepositorioGenerico<Venda>
    {
        public Venda BuscarPorId(int id)
        {
            return (Venda)_listaDeObjetos.Where(x => x.Id == id);
        }
    }
}
