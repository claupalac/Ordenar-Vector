using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_con_ceros
{
    class ListaDeNumeros
    {
        private int[] listaNumeros;
        private int posFinal;

        public ListaDeNumeros(int tamanoLista)
        {
            posFinal = tamanoLista - 1;
            
        }
        public void cargar()
        {
            listaNumeros = new int[posFinal + 1];
            for (int cont = 0; cont <= posFinal; cont++)
            {
                Console.Write("Ingrese Valor[" + cont + "]=");
                string numEntrada;
                numEntrada = Console.ReadLine();
                listaNumeros[cont] = int.Parse(numEntrada);
            }
        }
        public void imprimir()
        {
            for (int cont = 0; cont <= posFinal; cont++)
            {
                Console.WriteLine(listaNumeros[cont]);
            }
            Console.ReadKey();
        }

        public void OrdenarListaPorValor(int valorCondicion )
        {
            int ultimaPos = posFinal;
            for (int cont = 0; cont <= ultimaPos; cont++)
            {
                if(listaNumeros[cont] == valorCondicion)
                {
                    CambiarDosPosiciones(cont, ultimaPos);
                    ultimaPos--;
                }
            }
        }

        public void CambiarDosPosiciones(int posicion1, int posicion2)
        {
            int valorAux = listaNumeros[posicion1];
            listaNumeros[posicion1] = listaNumeros[posicion2];
            listaNumeros[posicion2] = valorAux;
        }

       
    }
}
