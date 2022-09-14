using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorEstoque
{
    public interface IEstoque
    {
        void Exibir();
        void AdicionarEntrada();
        void AdicionarSaida();
    }
}