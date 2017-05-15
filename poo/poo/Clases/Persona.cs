using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace poo.Clases
{
    public class Persona
    {
        public string nombre { get; set; }
        public string dpi { get; set; }

        public Persona() { }

        public Persona(string nombre, string dpi)
        {
            this.nombre = nombre;
            this.dpi = dpi;
        }
    }
}
