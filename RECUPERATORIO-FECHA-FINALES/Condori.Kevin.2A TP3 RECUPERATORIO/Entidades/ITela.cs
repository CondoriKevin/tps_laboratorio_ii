using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaz
{
    interface ITela<T>
    {
        float CalcularGanancia(T tela);
        bool EsValioso(T tela);
    }
}
