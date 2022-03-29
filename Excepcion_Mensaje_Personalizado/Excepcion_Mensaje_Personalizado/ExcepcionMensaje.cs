using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion_Mensaje_Personalizado
{
    internal class ExcepcionMensaje : Exception
    {
        public ExcepcionMensaje(string MensajePersonalizado) 
        {
            Console.WriteLine(MensajePersonalizado);
        }
    }
}
