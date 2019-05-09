using System;
using System.Collections.Generic;
using HelloXamarin.Models;

namespace HelloXamarin.Services
{
    public class PersonaServices
    {
        public List<Persona> GetPersonas()
        {
            return new List<Persona>
                {
                    new Persona("Ivan","Chavez"),
                    new Persona("Wilson","Perez"),
                    new Persona("Magda","Rivera")
                };
        }
    }
}
