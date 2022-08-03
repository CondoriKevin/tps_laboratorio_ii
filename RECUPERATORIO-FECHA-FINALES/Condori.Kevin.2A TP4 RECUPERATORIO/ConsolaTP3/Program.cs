using Entidades;
using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serializable;

namespace ConsolaTP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Nacional nacional = new Nacional(1, "AMano", "Nacional", "Javier", 1000, "Excelente");
            Nacional nacionalIgual = new Nacional(1, "AMano", "Nacional", "Javier", 1000, "Excelente");
            Importada importada = new Importada(2, "Cortadora", "Importada", "Lucas", 333, "Excelente");
            Nacional nacionalMismosDatosImportada = new Nacional(3, "Cortadora", "Nacional", "Lucas", 333, "Excelente");
            Importada importadaIgual = new Importada(4, "Cortadora", "Importada", "Lucas", 333, "Excelente");
            Importada importadaOtro = new Importada(5, "Estampado", "Importada", "Javier", 222, "Malo");

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
            Console.WriteLine("\nENTER para --> carga de XML");
            Console.ReadKey();
            foreach (Mensaje item in Mensaje.CargarXml())
            {
                Console.WriteLine(item.MostrarCampos());
            }
            Console.ReadKey();
        }
    }
}
