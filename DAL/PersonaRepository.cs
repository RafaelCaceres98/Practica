using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
    public class PersonaRepository
    {
        public List<Persona> personas;


        public String ruta = "Persona.txt";

        public void Guardar(Persona persona) {

            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{persona.id};{persona.nombre};{persona.edad};{persona.sexo};{persona.Pulsaciones}");
            escritor.Close();
            file.Close();


        }

        public List<Persona> Consultar() {

            personas = new List<Persona>();
            FileStream origen = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(origen);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                Persona persona = Mapear(linea);
                personas.Add(persona);
            }
            reader.Close();
            origen.Close();
            return personas;
        
        }

        private Persona Mapear(string linea)
        {
            string[] datos = linea.Split(';');
            Persona persona = new Persona();
            persona.id = datos[0];
            persona.nombre = datos[1];
            persona.edad = Int32.Parse(datos[2]);
            persona.sexo = datos[3];
            
            persona.Pulsaciones = decimal.Parse(datos[4]);
            return persona;
        }

    }
}
