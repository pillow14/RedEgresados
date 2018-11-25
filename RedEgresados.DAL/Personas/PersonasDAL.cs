using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedEgresados.DAL
{
    public class PersonasDAL
    {
        public List<Personas> ObtenerListaPersonas()
        {
            using (var db = new redegresados_Entities())
            {
                var query = from a in db.Personas.Include("Ex_Alumnos").Include("Usuarios")
                            select a;

                return query.ToList();
            }
        }
    }
}
