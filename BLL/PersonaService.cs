using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class PersonaService
    {
        private PersonaRepository personaRepository;
        

        public PersonaService()
        {
            personaRepository = new PersonaRepository();

        }

        public void CalcularPulsaciones (Persona persona) {

            if (persona.sexo.ToUpper().Equals("F"))

            {
                persona.Pulsaciones =((210 - persona.edad)) / 10;
            }
            else
            {
                if (persona.sexo.ToUpper().Equals("M"))

                {
                    persona.Pulsaciones = ((220 - persona.edad)) / 10;
                }
            }
        

        }

        public void Guardar(Persona persona) {

            personaRepository.Guardar(persona);
        
        }

        public List<Persona> Consultar() {

            return personaRepository.Consultar();
        }
                           

        
        }


   
        
 
}
