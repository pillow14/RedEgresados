using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedEgresados.DAL
{
    public class UsuariosDAL
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuariosBo"></param>
        /// <returns></returns>
        public Usuarios ObtenerListaUsuarios(UsuariosBO usuariosBo)
        {
            using (var db = new redegresados_Entities())
            {
                var query = (from a in db.Usuarios.Include("Personas")
                             where a.Rol == usuariosBo.rol &&
                             a.Password == usuariosBo.password
                             select a);

                return query.FirstOrDefault();
            }
        }
    }
}