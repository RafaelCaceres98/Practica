using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Persona
    {
        public string id { get; set; }

        public string nombre { get; set; }
        
        public int edad { get; set; }
        public string sexo { get; set; }

        public decimal Pulsaciones { get; set; }
    }
}
