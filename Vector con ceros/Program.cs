using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_con_ceros
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeNumeros miLista = new ListaDeNumeros(10);          
            miLista.cargar();
            miLista.OrdenarListaPorValor(0);
            miLista.imprimir();
        }
    }
}
