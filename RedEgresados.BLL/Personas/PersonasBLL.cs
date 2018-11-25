using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedEgresados.DAL;

namespace RedEgresados.BLL
{
   public class PersonasBLL
    {
       PersonasDAL personasDAL = new PersonasDAL();

       public List<Personas> ObtenerListaPersonas()
       {
           List<Personas> listaPersonas = new List<Personas>();
           listaPersonas = personasDAL.ObtenerListaPersonas();
           return listaPersonas;
       }
    }
}
