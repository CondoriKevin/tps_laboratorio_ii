using Entidades;
using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaTP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Nacional nacional = new Nacional(EMaquina.AMano, "Nacional", "Javier", 1000, ECalidadTela.Excelente);
            Nacional nacionalIgual = new Nacional(EMaquina.AMano, "Nacional", "Javier", 1000, ECalidadTela.Excelente);
            Importada importada = new Importada(EMaquina.Cortadora, "Importada", "Lucas", 333, ECalidadTela.Excelente);
            Nacional nacionalMismosDatosImportada = new Nacional(EMaquina.Cortadora, "Nacional", "Lucas", 333, ECalidadTela.Excelente);
            Importada importadaIgual = new Importada(EMaquina.Cortadora, "Importada", "Lucas", 333, ECalidadTela.Excelente);
            Importada importadaOtro = new Importada(EMaquina.Estampado, "Importada", "Javier", 222, ECalidadTela.Malo);

            Stock stock = new Stock("Lista");
            stock = stock + nacional;
            stock = stock + nacionalIgual;   //NO SE DEBERIA SUMAR
            stock = stock + nacionalMismosDatosImportada; //con diferente tipo de dato 
            stock = stock + importada;
            stock = stock + importadaIgual; //NO SE DEBERIA SUMAR
            stock = stock + importadaOtro;
            Console.WriteLine(stock.ListaDeTelas.Count);
            foreach (Tela item in stock.ListaDeTelas)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
