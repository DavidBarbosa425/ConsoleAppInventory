using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInventory
{
    interface IEstoque
    {
        void Exibir();

        void AdicionarEntrada();

        void AdicionarSaida();
    }
}
